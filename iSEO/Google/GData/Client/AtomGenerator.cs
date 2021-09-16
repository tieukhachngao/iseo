using System.ComponentModel;
using System.Xml;

namespace Google.GData.Client
{
	[TypeConverter(typeof(AtomGeneratorConverter))]
	[Description("Expand to see the feed generator object.")]
	public class AtomGenerator : AtomBase
	{
		private string string_1;

		private AtomUri atomUri_2;

		private string string_2;

		public override string XmlName => "generator";

		public string Text
		{
			get
			{
				return string_1;
			}
			set
			{
				base.Dirty = true;
				string_1 = value;
			}
		}

		public AtomUri Uri
		{
			get
			{
				return atomUri_2;
			}
			set
			{
				base.Dirty = true;
				atomUri_2 = value;
			}
		}

		public string Version
		{
			get
			{
				return string_2;
			}
			set
			{
				base.Dirty = true;
				string_2 = value;
			}
		}

		public AtomGenerator()
		{
		}

		public AtomGenerator(string text)
		{
			Text = text;
		}

		protected override void SaveXmlAttributes(XmlWriter writer)
		{
			AtomBase.WriteEncodedAttributeString(writer, "uri", Uri);
			AtomBase.WriteEncodedAttributeString(writer, "version", Version);
			base.SaveXmlAttributes(writer);
		}

		protected override void SaveInnerXml(XmlWriter writer)
		{
			base.SaveInnerXml(writer);
			AtomBase.WriteEncodedString(writer, string_1);
		}

		public override bool ShouldBePersisted()
		{
			if (!base.ShouldBePersisted())
			{
				if (atomUri_2 != null && Utilities.IsPersistable(atomUri_2.ToString()))
				{
					return true;
				}
				if (!Utilities.IsPersistable(string_2) && !Utilities.IsPersistable(string_1))
				{
					return false;
				}
				return true;
			}
			return true;
		}
	}
}
