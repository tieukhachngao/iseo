using System.ComponentModel;
using System.Xml;
using Google.GData.Extensions;

namespace Google.GData.Client
{
	[Description("Expand to see the content objectfor the entry.")]
	[TypeConverter(typeof(AtomContentConverter))]
	public class AtomContent : AtomBase
	{
		private string string_1;

		private AtomUri atomUri_2;

		private string string_2;

		public override string XmlName => "content";

		public string Type
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

		public AtomUri Src
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

		public string AbsoluteUri => GetAbsoluteUri(Src.ToString());

		public string Content
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

		public BatchErrors BatchErrors
		{
			get
			{
				return FindExtension("errors", "http://schemas.google.com/g/2005") as BatchErrors;
			}
			set
			{
				ReplaceExtension("errors", "http://schemas.google.com/g/2005", value);
			}
		}

		public AtomContent()
		{
			string_1 = "text";
			AddExtension(new BatchErrors());
		}

		public override bool ShouldBePersisted()
		{
			if (!base.ShouldBePersisted())
			{
				if (!Utilities.IsPersistable(atomUri_2) && !Utilities.IsPersistable(string_1))
				{
					return Utilities.IsPersistable(string_2);
				}
				return true;
			}
			return true;
		}

		protected override void SaveXmlAttributes(XmlWriter writer)
		{
			AtomBase.WriteEncodedAttributeString(writer, "src", Src);
			AtomBase.WriteEncodedAttributeString(writer, "type", Type);
			base.SaveXmlAttributes(writer);
		}

		protected override void SaveInnerXml(XmlWriter writer)
		{
			base.SaveInnerXml(writer);
			if (Utilities.IsPersistable(string_2))
			{
				if (!(string_1 == "html") && !string_1.StartsWith("text"))
				{
					writer.WriteRaw(string_2);
					return;
				}
				string content = HttpUtility.HtmlDecode(string_2);
				AtomBase.WriteEncodedString(writer, content);
			}
		}
	}
}
