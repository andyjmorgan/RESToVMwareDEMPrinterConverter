
using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;

namespace RESToDEMPrinterMigrator
{
    class Program
    {

        static string SourceFilePath = "";
        static string TargetDirectoryPath = "";

        static int SuccessCount = 0;
        static int ErrorCount = 0;
        static int RulesProcessed = 0;
        static string BooleanToIntString(bool value)
        {
            return value ? 1.ToString() : 0.ToString();
        }

        static void WriteUsage()
        {
            Console.WriteLine("Usage:");
            Console.WriteLine("");
            Console.WriteLine(@"RESToDEMPrinterMigrator.exe -source=""C:\RESPrinterMaster.xml"" -destination=""C:\RES TO DEM\export""");
            Console.WriteLine("");
            Console.WriteLine("A building block called RESPrinterMaster.xml will be parsed, and each printer will be exported to c:\\RES TO DEM\\Export");
            Environment.Exit(0);
        }
        static void HandleArguments(string[] args)
        {
            foreach (var arg in args)
            {

                if (arg.ToLower().StartsWith("-source="))
                {
                    SourceFilePath = arg.Split("=")[1];
                }
                else if (arg.StartsWith("-destination="))
                {
                    TargetDirectoryPath = arg.Split("=")[1];
                }
                else if (arg.StartsWith("/?") || arg.StartsWith("-?"))
                {
                    WriteUsage();
                }
                else
                {
                    Console.WriteLine("Could not parse argument: {0}", arg);
                    WriteUsage();                

                }
            }
            if (!File.Exists(SourceFilePath))
            {
                
                throw new Exception("Could not find source file path");
            }
            else
            {
                Console.WriteLine("Reading from: {0}", SourceFilePath);
            }
            if (!Directory.Exists(TargetDirectoryPath))
            {
                Console.WriteLine("Target Directory does not exist, press any key to create it. ([ctrl] + [c] to cancel.");
                Console.ReadLine();
                Directory.CreateDirectory(TargetDirectoryPath);
            }
            Console.WriteLine("Exporting to: {0}", TargetDirectoryPath);



        }

        static void Main(string[] args)
        {

            HandleArguments(args);


            XmlSerializer DEMserializer = new XmlSerializer(typeof(DEMPrinterMapping.UserEnvironmentSettings), "");
            XmlSerializer RESserializer = new XmlSerializer(typeof(RESBlock.respowerfuse));

            var ns = new XmlSerializerNamespaces();
            ns.Add("", "");

            RESBlock.respowerfuse BuildingBlock = new RESBlock.respowerfuse();

            using (Stream reader = new FileStream(SourceFilePath, FileMode.Open))
            {
                BuildingBlock = (RESBlock.respowerfuse)RESserializer.Deserialize(reader);
            };


            var AllPrinters = BuildingBlock.buildingblock.powerlaunch.Where(x => x.printermapping != null).SelectMany(x => x.printermapping).ToList();
            var AllPrinterNames = AllPrinters.Select(x => new { PrinterName = string.Format("{0} on {1}", x.printer.Remove(0, 2).Split('\\')[1], x.printer.Remove(0, 2).Split('\\')[0]) }).Select(x => x.PrinterName).ToList();

            Console.WriteLine("Detected: {0} printer mappings. Unique Printers: {1}", AllPrinters.Count(), AllPrinterNames.Distinct().Count());



            foreach (var RPM in AllPrinters.ToList())
            {
                Console.Title = string.Format("Successful: ({0}) - Failed: ({1}) - Rules Processed: ({2})", SuccessCount, ErrorCount, RulesProcessed);
                var printerName = RPM.printer.Remove(0, 2).Split('\\')[1];
                try
                {
                    DEMPrinterMapping.UserEnvironmentSettings NewDEMPrinter = new DEMPrinterMapping.UserEnvironmentSettings();
                    NewDEMPrinter.Setting.Async = BooleanToIntString(RPM.waitfortask.ToLower() == "no");
                    NewDEMPrinter.Setting.Default = BooleanToIntString(RPM.@default.ToLower() == "yes");
                    NewDEMPrinter.Setting.Remote = RPM.printer ?? "";
                    NewDEMPrinter.Setting.Label = RPM.comment ?? "";
                    NewDEMPrinter.Setting.Tag = RPM.location ?? "";


                    if (RPM.accesscontrol.access_mode != "or")
                    {
                        throw new Exception(string.Format("Printer: {0} - Unhandled Access Mode Detected: {1}", printerName, RPM.accesscontrol.access_mode));
                    }

                    var FilteredRules = RPM.accesscontrol.access.Where(x => x.type != "global");
                    if (FilteredRules.Count() <= 0)
                    {
                        throw new Exception(string.Format("Printer: {0} Unhandled NULL access rule event", printerName));
                    }
                    if (FilteredRules.Count() == 1)
                    {
                        NewDEMPrinter.Conditions.Tsclient = ConvertRESPrinterAccessRule(FilteredRules.First());
                    }
                    else
                    {
                        foreach (RESBlock.respowerfuseBuildingblockPowerlaunchPrintermappingAccesscontrolAccess j in RPM.accesscontrol.access.Where(x => x.type != "global"))
                        {
                            if (NewDEMPrinter.Conditions.Or == null)
                            {
                                NewDEMPrinter.Conditions.Or = new DEMPrinterMapping.Or();
                            }
                            NewDEMPrinter.Conditions.Or.Tsclient.Add(ConvertRESPrinterAccessRule(j));
                        }
                    }


                    string PrinterFileName = FindFreePrinterName(TargetDirectoryPath + "\\" + printerName);
                    using (var writer = new StreamWriter(PrinterFileName, false, System.Text.Encoding.UTF8))
                    {

                        DEMserializer.Serialize(writer, NewDEMPrinter, ns);
                    }
                    SuccessCount += 1;
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Failed to map printer: " + RPM.printer + " with Exception: " + ex.Message);
                    ErrorCount += 1;
                }
                


            }

        }

        static DEMPrinterMapping.Tsclient ConvertRESPrinterAccessRule(RESBlock.respowerfuseBuildingblockPowerlaunchPrintermappingAccesscontrolAccess rule)
        {
            DEMPrinterMapping.Tsclient newTsclientEntry = new DEMPrinterMapping.Tsclient();
            if (rule.type != "clientname" && rule.type != "global")
            {
                throw new Exception(string.Format("Unhandled OR Rule Detected: {0}", rule.type));

            }
            if (rule.@object != null)
            {

                if(rule.@object.EndsWith(" "))
                {
                   rule.@object = rule.@object.Remove(rule.@object.Length - 1, 1);
                }
                if (Regex.IsMatch(rule.@object, @"\[|\]"))
                {
                    newTsclientEntry.O = "regex";
                }
                else if (rule.@object.EndsWith("*"))
                {
                    rule.@object = rule.@object.Remove(rule.@object.Length - 1, 1);
                    newTsclientEntry.O = "starts";
                }
                else if (rule.@object.StartsWith("*"))
                {
                    rule.@object = rule.@object.Remove(rule.@object.Length - 1, 1);
                    newTsclientEntry.O = "ends";
                }
                else if (Regex.IsMatch(rule.@object,@"[^a-zA-Z0-9\-_ ]"))
                {
                    throw new Exception("Printer: {0} has unsupported characters in the access rule");
                }
                else if (rule.@object.Contains("*"))
                {
                    throw new Exception(string.Format("printer {0} mapping could not be processed as it contains a wildcard", rule));
                }

                else
                {
                    newTsclientEntry.O = "equals";
                }


                newTsclientEntry.V = rule.@object;
            }
            else
            {
                if (rule.type != "global")
                {
                    throw new Exception(string.Format("Excluded Property {0} due to missing object", rule.type));
                }
            }
            RulesProcessed += 1;
            return newTsclientEntry;
        }

        static string FindFreePrinterName(string PrinterName)
        {
            if (!System.IO.File.Exists(PrinterName + ".xml"))
            {
                return PrinterName + ".xml";
            }
            else
            {
                int increment = 1;
                while (true)
                {
                    var PrinterFileName = string.Format("{0}-{1}.xml", PrinterName, increment);
                    if (!System.IO.File.Exists(PrinterFileName))
                    {
                        return PrinterFileName;
                    }
                    else
                    {
                        increment += 1;
                    }
                }
            }

        }
    }


}
