using System.Collections.Generic;
using System.Xml.Serialization;

namespace RESToDEMPrinterMigrator
{
    public class RESBlock
    {

        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class respowerfuse
        {

            private string versionField;

            private respowerfuseBuildingblock buildingblockField;

            /// <remarks/>
            public string version
            {
                get
                {
                    return this.versionField;
                }
                set
                {
                    this.versionField = value;
                }
            }

            /// <remarks/>
            public respowerfuseBuildingblock buildingblock
            {
                get
                {
                    return this.buildingblockField;
                }
                set
                {
                    this.buildingblockField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class respowerfuseBuildingblock
        {

            private respowerfuseBuildingblockPowerlaunch[] powerlaunchField;

            private respowerfuseBuildingblockWorkspace[] workspacesField;

            private respowerfuseBuildingblockPowerzone[] powerzonesField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("powerlaunch")]
            public respowerfuseBuildingblockPowerlaunch[] powerlaunch
            {
                get
                {
                    return this.powerlaunchField;
                }
                set
                {
                    this.powerlaunchField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("workspace", IsNullable = false)]
            public respowerfuseBuildingblockWorkspace[] workspaces
            {
                get
                {
                    return this.workspacesField;
                }
                set
                {
                    this.workspacesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("powerzone", IsNullable = false)]
            public respowerfuseBuildingblockPowerzone[] powerzones
            {
                get
                {
                    return this.powerzonesField;
                }
                set
                {
                    this.powerzonesField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class respowerfuseBuildingblockPowerlaunch
        {

            private respowerfuseBuildingblockPowerlaunchPrintermapping_settings printermapping_settingsField;

            private respowerfuseBuildingblockPowerlaunchPrintermapping[] printermappingField;

            /// <remarks/>
            public respowerfuseBuildingblockPowerlaunchPrintermapping_settings printermapping_settings
            {
                get
                {
                    return this.printermapping_settingsField;
                }
                set
                {
                    this.printermapping_settingsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("printermapping")]
            public respowerfuseBuildingblockPowerlaunchPrintermapping[] printermapping
            {
                get
                {
                    return this.printermappingField;
                }
                set
                {
                    this.printermappingField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class respowerfuseBuildingblockPowerlaunchPrintermapping_settings
        {

            private string enabledField;

            private string resetprinterField;

            private string disconnectprintersField;

            private string disconnectprinterslogonField;

            private string refreshprintersonreconnectField;

            private string refreshprintersonnetworkchangeField;

            private string refreshprintersonsessionrefreshField;

            private string connectdefaultprinterusingvdxField;

            private string connectallprintersusingvdxField;

            private string skipunmanagedprintersField;

            private string locationbasedprintingmethodField;

            private respowerfuseBuildingblockPowerlaunchPrintermapping_settingsPrintermapping_settings[] exceptionsField;

            /// <remarks/>
            public string enabled
            {
                get
                {
                    return this.enabledField;
                }
                set
                {
                    this.enabledField = value;
                }
            }

            /// <remarks/>
            public string resetprinter
            {
                get
                {
                    return this.resetprinterField;
                }
                set
                {
                    this.resetprinterField = value;
                }
            }

            /// <remarks/>
            public string disconnectprinters
            {
                get
                {
                    return this.disconnectprintersField;
                }
                set
                {
                    this.disconnectprintersField = value;
                }
            }

            /// <remarks/>
            public string disconnectprinterslogon
            {
                get
                {
                    return this.disconnectprinterslogonField;
                }
                set
                {
                    this.disconnectprinterslogonField = value;
                }
            }

            /// <remarks/>
            public string refreshprintersonreconnect
            {
                get
                {
                    return this.refreshprintersonreconnectField;
                }
                set
                {
                    this.refreshprintersonreconnectField = value;
                }
            }

            /// <remarks/>
            public string refreshprintersonnetworkchange
            {
                get
                {
                    return this.refreshprintersonnetworkchangeField;
                }
                set
                {
                    this.refreshprintersonnetworkchangeField = value;
                }
            }

            /// <remarks/>
            public string refreshprintersonsessionrefresh
            {
                get
                {
                    return this.refreshprintersonsessionrefreshField;
                }
                set
                {
                    this.refreshprintersonsessionrefreshField = value;
                }
            }

            /// <remarks/>
            public string connectdefaultprinterusingvdx
            {
                get
                {
                    return this.connectdefaultprinterusingvdxField;
                }
                set
                {
                    this.connectdefaultprinterusingvdxField = value;
                }
            }

            /// <remarks/>
            public string connectallprintersusingvdx
            {
                get
                {
                    return this.connectallprintersusingvdxField;
                }
                set
                {
                    this.connectallprintersusingvdxField = value;
                }
            }

            /// <remarks/>
            public string skipunmanagedprinters
            {
                get
                {
                    return this.skipunmanagedprintersField;
                }
                set
                {
                    this.skipunmanagedprintersField = value;
                }
            }

            /// <remarks/>
            public string locationbasedprintingmethod
            {
                get
                {
                    return this.locationbasedprintingmethodField;
                }
                set
                {
                    this.locationbasedprintingmethodField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("printermapping_settings", IsNullable = false)]
            public respowerfuseBuildingblockPowerlaunchPrintermapping_settingsPrintermapping_settings[] exceptions
            {
                get
                {
                    return this.exceptionsField;
                }
                set
                {
                    this.exceptionsField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class respowerfuseBuildingblockPowerlaunchPrintermapping_settingsPrintermapping_settings
        {

            private string enabledField;

            private string resetprinterField;

            private string disconnectprintersField;

            private string disconnectprinterslogonField;

            private string refreshprintersonreconnectField;

            private string refreshprintersonnetworkchangeField;

            private string refreshprintersonsessionrefreshField;

            private string connectdefaultprinterusingvdxField;

            private string connectallprintersusingvdxField;

            private string skipunmanagedprintersField;

            private string locationbasedprintingmethodField;

            private string workspaceguidField;

            private string workspacenameField;

            private string exceptionenabledField;

            private respowerfuseBuildingblockPowerlaunchPrintermapping_settingsPrintermapping_settingsWorkspacecontrol workspacecontrolField;

            /// <remarks/>
            public string enabled
            {
                get
                {
                    return this.enabledField;
                }
                set
                {
                    this.enabledField = value;
                }
            }

            /// <remarks/>
            public string resetprinter
            {
                get
                {
                    return this.resetprinterField;
                }
                set
                {
                    this.resetprinterField = value;
                }
            }

            /// <remarks/>
            public string disconnectprinters
            {
                get
                {
                    return this.disconnectprintersField;
                }
                set
                {
                    this.disconnectprintersField = value;
                }
            }

            /// <remarks/>
            public string disconnectprinterslogon
            {
                get
                {
                    return this.disconnectprinterslogonField;
                }
                set
                {
                    this.disconnectprinterslogonField = value;
                }
            }

            /// <remarks/>
            public string refreshprintersonreconnect
            {
                get
                {
                    return this.refreshprintersonreconnectField;
                }
                set
                {
                    this.refreshprintersonreconnectField = value;
                }
            }

            /// <remarks/>
            public string refreshprintersonnetworkchange
            {
                get
                {
                    return this.refreshprintersonnetworkchangeField;
                }
                set
                {
                    this.refreshprintersonnetworkchangeField = value;
                }
            }

            /// <remarks/>
            public string refreshprintersonsessionrefresh
            {
                get
                {
                    return this.refreshprintersonsessionrefreshField;
                }
                set
                {
                    this.refreshprintersonsessionrefreshField = value;
                }
            }

            /// <remarks/>
            public string connectdefaultprinterusingvdx
            {
                get
                {
                    return this.connectdefaultprinterusingvdxField;
                }
                set
                {
                    this.connectdefaultprinterusingvdxField = value;
                }
            }

            /// <remarks/>
            public string connectallprintersusingvdx
            {
                get
                {
                    return this.connectallprintersusingvdxField;
                }
                set
                {
                    this.connectallprintersusingvdxField = value;
                }
            }

            /// <remarks/>
            public string skipunmanagedprinters
            {
                get
                {
                    return this.skipunmanagedprintersField;
                }
                set
                {
                    this.skipunmanagedprintersField = value;
                }
            }

            /// <remarks/>
            public string locationbasedprintingmethod
            {
                get
                {
                    return this.locationbasedprintingmethodField;
                }
                set
                {
                    this.locationbasedprintingmethodField = value;
                }
            }

            /// <remarks/>
            public string workspaceguid
            {
                get
                {
                    return this.workspaceguidField;
                }
                set
                {
                    this.workspaceguidField = value;
                }
            }

            /// <remarks/>
            public string workspacename
            {
                get
                {
                    return this.workspacenameField;
                }
                set
                {
                    this.workspacenameField = value;
                }
            }

            /// <remarks/>
            public string exceptionenabled
            {
                get
                {
                    return this.exceptionenabledField;
                }
                set
                {
                    this.exceptionenabledField = value;
                }
            }

            /// <remarks/>
            public respowerfuseBuildingblockPowerlaunchPrintermapping_settingsPrintermapping_settingsWorkspacecontrol workspacecontrol
            {
                get
                {
                    return this.workspacecontrolField;
                }
                set
                {
                    this.workspacecontrolField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class respowerfuseBuildingblockPowerlaunchPrintermapping_settingsPrintermapping_settingsWorkspacecontrol
        {

            private string workspaceField;

            /// <remarks/>
            public string workspace
            {
                get
                {
                    return this.workspaceField;
                }
                set
                {
                    this.workspaceField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class respowerfuseBuildingblockPowerlaunchPrintermapping
        {

            private string printerField;

            private object backupprinterField;

            private string defaultField;

            private string fastconnectField;

            private string failoverField;

            private string printerpreferenceField;

            private string waitfortaskField;

            private string descriptionField;

            private string driverField;

            private string commentField;

            private string locationField;

            private string stateField;

            private respowerfuseBuildingblockPowerlaunchPrintermappingAccesscontrol accesscontrolField;

            private string guidField;

            private string enabledField;

            /// <remarks/>
            public string printer
            {
                get
                {
                    return this.printerField;
                }
                set
                {
                    this.printerField = value;
                }
            }

            /// <remarks/>
            public object backupprinter
            {
                get
                {
                    return this.backupprinterField;
                }
                set
                {
                    this.backupprinterField = value;
                }
            }

            /// <remarks/>
            public string @default
            {
                get
                {
                    return this.defaultField;
                }
                set
                {
                    this.defaultField = value;
                }
            }

            /// <remarks/>
            public string fastconnect
            {
                get
                {
                    return this.fastconnectField;
                }
                set
                {
                    this.fastconnectField = value;
                }
            }

            /// <remarks/>
            public string failover
            {
                get
                {
                    return this.failoverField;
                }
                set
                {
                    this.failoverField = value;
                }
            }

            /// <remarks/>
            public string printerpreference
            {
                get
                {
                    return this.printerpreferenceField;
                }
                set
                {
                    this.printerpreferenceField = value;
                }
            }

            /// <remarks/>
            public string waitfortask
            {
                get
                {
                    return this.waitfortaskField;
                }
                set
                {
                    this.waitfortaskField = value;
                }
            }

            /// <remarks/>
            public string description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            public string driver
            {
                get
                {
                    return this.driverField;
                }
                set
                {
                    this.driverField = value;
                }
            }

            /// <remarks/>
            public string comment
            {
                get
                {
                    return this.commentField;
                }
                set
                {
                    this.commentField = value;
                }
            }

            /// <remarks/>
            public string location
            {
                get
                {
                    return this.locationField;
                }
                set
                {
                    this.locationField = value;
                }
            }

            /// <remarks/>
            public string state
            {
                get
                {
                    return this.stateField;
                }
                set
                {
                    this.stateField = value;
                }
            }

            /// <remarks/>
            public respowerfuseBuildingblockPowerlaunchPrintermappingAccesscontrol accesscontrol
            {
                get
                {
                    return this.accesscontrolField;
                }
                set
                {
                    this.accesscontrolField = value;
                }
            }

            /// <remarks/>
            public string guid
            {
                get
                {
                    return this.guidField;
                }
                set
                {
                    this.guidField = value;
                }
            }

            /// <remarks/>
            public string enabled
            {
                get
                {
                    return this.enabledField;
                }
                set
                {
                    this.enabledField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class respowerfuseBuildingblockPowerlaunchPrintermappingAccesscontrol
        {

            private respowerfuseBuildingblockPowerlaunchPrintermappingAccesscontrolAccess[] accessField;

            private respowerfuseBuildingblockPowerlaunchPrintermappingAccesscontrolDatetimecontrol datetimecontrolField;

            private string access_modeField;

            private string zone_modeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("access")]
            public respowerfuseBuildingblockPowerlaunchPrintermappingAccesscontrolAccess[] access
            {
                get
                {
                    return this.accessField;
                }
                set
                {
                    this.accessField = value;
                }
            }

            /// <remarks/>
            public respowerfuseBuildingblockPowerlaunchPrintermappingAccesscontrolDatetimecontrol datetimecontrol
            {
                get
                {
                    return this.datetimecontrolField;
                }
                set
                {
                    this.datetimecontrolField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string access_mode
            {
                get
                {
                    return this.access_modeField;
                }
                set
                {
                    this.access_modeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string zone_mode
            {
                get
                {
                    return this.zone_modeField;
                }
                set
                {
                    this.zone_modeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class respowerfuseBuildingblockPowerlaunchPrintermappingAccesscontrolAccess
        {

            private string typeField;

            private string objectField;

            /// <remarks/>
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            public string @object
            {
                get
                {
                    return this.objectField;
                }
                set
                {
                    this.objectField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class respowerfuseBuildingblockPowerlaunchPrintermappingAccesscontrolDatetimecontrol
        {

            private respowerfuseBuildingblockPowerlaunchPrintermappingAccesscontrolDatetimecontrolDatetime datetimeField;

            /// <remarks/>
            public respowerfuseBuildingblockPowerlaunchPrintermappingAccesscontrolDatetimecontrolDatetime datetime
            {
                get
                {
                    return this.datetimeField;
                }
                set
                {
                    this.datetimeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class respowerfuseBuildingblockPowerlaunchPrintermappingAccesscontrolDatetimecontrolDatetime
        {

            private ulong startField;

            private ulong endField;

            /// <remarks/>
            public ulong start
            {
                get
                {
                    return this.startField;
                }
                set
                {
                    this.startField = value;
                }
            }

            /// <remarks/>
            public ulong end
            {
                get
                {
                    return this.endField;
                }
                set
                {
                    this.endField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class respowerfuseBuildingblockWorkspace
        {

            private string nameField;

            private object descriptionField;

            private string selectablebyuserField;

            private string includeallcomputersField;

            private respowerfuseBuildingblockWorkspaceAccesscontrol accesscontrolField;

            private string guidField;

            private string enabledField;

            private string requiredField;

            /// <remarks/>
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public object description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            public string selectablebyuser
            {
                get
                {
                    return this.selectablebyuserField;
                }
                set
                {
                    this.selectablebyuserField = value;
                }
            }

            /// <remarks/>
            public string includeallcomputers
            {
                get
                {
                    return this.includeallcomputersField;
                }
                set
                {
                    this.includeallcomputersField = value;
                }
            }

            /// <remarks/>
            public respowerfuseBuildingblockWorkspaceAccesscontrol accesscontrol
            {
                get
                {
                    return this.accesscontrolField;
                }
                set
                {
                    this.accesscontrolField = value;
                }
            }

            /// <remarks/>
            public string guid
            {
                get
                {
                    return this.guidField;
                }
                set
                {
                    this.guidField = value;
                }
            }

            /// <remarks/>
            public string enabled
            {
                get
                {
                    return this.enabledField;
                }
                set
                {
                    this.enabledField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string required
            {
                get
                {
                    return this.requiredField;
                }
                set
                {
                    this.requiredField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class respowerfuseBuildingblockWorkspaceAccesscontrol
        {

            private respowerfuseBuildingblockWorkspaceAccesscontrolAccess[] accessField;

            private string access_modeField;

            private string zone_modeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("access")]
            public respowerfuseBuildingblockWorkspaceAccesscontrolAccess[] access
            {
                get
                {
                    return this.accessField;
                }
                set
                {
                    this.accessField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string access_mode
            {
                get
                {
                    return this.access_modeField;
                }
                set
                {
                    this.access_modeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string zone_mode
            {
                get
                {
                    return this.zone_modeField;
                }
                set
                {
                    this.zone_modeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class respowerfuseBuildingblockWorkspaceAccesscontrolAccess
        {

            private string typeField;

            private string objectField;

            /// <remarks/>
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            public string @object
            {
                get
                {
                    return this.objectField;
                }
                set
                {
                    this.objectField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class respowerfuseBuildingblockPowerzone
        {

            private string nameField;

            private object descriptionField;

            private respowerfuseBuildingblockPowerzoneRule[] powerzonerulesField;

            private string guidField;

            private string enabledField;

            private string requiredField;

            /// <remarks/>
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public object description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("rule", IsNullable = false)]
            public respowerfuseBuildingblockPowerzoneRule[] powerzonerules
            {
                get
                {
                    return this.powerzonerulesField;
                }
                set
                {
                    this.powerzonerulesField = value;
                }
            }

            /// <remarks/>
            public string guid
            {
                get
                {
                    return this.guidField;
                }
                set
                {
                    this.guidField = value;
                }
            }

            /// <remarks/>
            public string enabled
            {
                get
                {
                    return this.enabledField;
                }
                set
                {
                    this.enabledField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string required
            {
                get
                {
                    return this.requiredField;
                }
                set
                {
                    this.requiredField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class respowerfuseBuildingblockPowerzoneRule
        {

            private byte typeField;

            private string filterField;

            private byte type2Field;

            private object filter2Field;

            private object commentsField;

            private string enabledField;

            /// <remarks/>
            public byte type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            public string filter
            {
                get
                {
                    return this.filterField;
                }
                set
                {
                    this.filterField = value;
                }
            }

            /// <remarks/>
            public byte type2
            {
                get
                {
                    return this.type2Field;
                }
                set
                {
                    this.type2Field = value;
                }
            }

            /// <remarks/>
            public object filter2
            {
                get
                {
                    return this.filter2Field;
                }
                set
                {
                    this.filter2Field = value;
                }
            }

            /// <remarks/>
            public object comments
            {
                get
                {
                    return this.commentsField;
                }
                set
                {
                    this.commentsField = value;
                }
            }

            /// <remarks/>
            public string enabled
            {
                get
                {
                    return this.enabledField;
                }
                set
                {
                    this.enabledField = value;
                }
            }
        }



    }
}
