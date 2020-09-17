using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;

namespace RESToDEMPrinterMigrator
{
    public class DEMPrinterMapping
    {
		[XmlRoot(ElementName = "member")]
		public class Member
		{
			[XmlAttribute(AttributeName = "g")]
			public string G { get; set; }
			[XmlAttribute(AttributeName = "c")]
			public string C { get; set; }
			[XmlAttribute(AttributeName = "s")]
			public string S { get; set; }
		}

		[XmlRoot(ElementName = "not")]
		public class Not
		{
			[XmlElement(ElementName = "member")]
			public Member Member { get; set; }
			[XmlElement(ElementName = "battery")]
			public Battery Battery { get; set; }
		}

		[XmlRoot(ElementName = "ip")]
		public class Ip
		{
			[XmlElement(ElementName = "a")]
			public List<string> A { get; set; }
			[XmlElement(ElementName = "b")]
			public List<string> B { get; set; }
			[XmlElement(ElementName = "c")]
			public List<string> C { get; set; }
			[XmlElement(ElementName = "d")]
			public List<string> D { get; set; }
		}

		[XmlRoot(ElementName = "battery")]
		public class Battery
		{
			[XmlAttribute(AttributeName = "c")]
			public string C { get; set; }
		}

		[XmlRoot(ElementName = "os")]
		public class Os
		{
			[XmlElement(ElementName = "M")]
			public List<string> M { get; set; }
			[XmlAttribute(AttributeName = "w")]
			public string W { get; set; }
		}

		[XmlRoot(ElementName = "tsclient")]
		public class Tsclient
		{
			[XmlAttribute(AttributeName = "v")]
			public string V { get; set; }
			[XmlAttribute(AttributeName = "o")]
			public string O { get; set; }
		}

		[XmlRoot(ElementName = "or")]
		public class Or
		{
			[XmlElement(ElementName = "ip")]
			public Ip Ip { get; set; }
			[XmlElement(ElementName = "not")]
			public Not Not { get; set; }
			[XmlElement(ElementName = "os")]
			public Os Os { get; set; }
			[XmlElement(ElementName = "tsclient")]
			public List<Tsclient> Tsclient { get; set; }

			public Or()
			{
				Tsclient = new List<Tsclient>();
			}
		}

		[XmlRoot(ElementName = "conditions")]
		public class Conditions
		{
			[XmlElement(ElementName = "not", IsNullable = false)]
			public Not Not { get; set; }
			[XmlElement(ElementName = "or", IsNullable = false)]
			public Or Or { get; set; }
			[XmlElement(ElementName = "tsclient", IsNullable = false)]
			public Tsclient Tsclient { get; set; }

		}

		[XmlRoot(ElementName = "setting")]
		public class Setting
		{
			[XmlAttribute(AttributeName = "type")]
			public string Type { get; set; }
			[XmlAttribute(AttributeName = "async")]
			public string Async { get; set; }
			[XmlAttribute(AttributeName = "remote")]
			public string Remote { get; set; }
			[XmlAttribute(AttributeName = "default")]
			public string Default { get; set; }
			[XmlAttribute(AttributeName = "label")]
			public string Label { get; set; }
			[XmlAttribute(AttributeName = "tag")]
			public string Tag { get; set; }
			[XmlAttribute(AttributeName = "undo")]
			public string Undo { get; set; }
			[XmlAttribute(AttributeName = "runOnce")]
			public string runOnce { get; set; }

			public Setting()
			{
				Type = "printerMapping";
				Async = "0";
				Default = "0";
				Undo = "1";
				runOnce = "0";

			}
		}

		[XmlRoot(ElementName = "userEnvironmentSettings")]
		public class UserEnvironmentSettings
		{
			[XmlElement(ElementName = "conditions")]
			public Conditions Conditions { get; set; }
			[XmlElement(ElementName = "setting")]
			public Setting Setting { get; set; }

			public UserEnvironmentSettings()
			{
				Setting = new Setting();
				Conditions = new Conditions();
			}
		}

	}
}
