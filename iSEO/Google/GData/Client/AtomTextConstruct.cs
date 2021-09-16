using System.ComponentModel;
using System.Xml;

namespace Google.GData.Client
{
	[TypeConverter(typeof(AtomTextConstructConverter))]
	[Description("Expand to see details for this object.")]
	public class AtomTextConstruct : AtomBase
	{
		private AtomTextConstructType atomTextConstructType_0;

		private string string_1;

		private AtomTextConstructElementType atomTextConstructElementType_0;

		public AtomTextConstructType Type
		{
			get
			{
				return atomTextConstructType_0;
			}
			set
			{
				base.Dirty = true;
				atomTextConstructType_0 = value;
			}
		}

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

		public override string XmlName => atomTextConstructElementType_0 switch
		{
			AtomTextConstructElementType.Rights => "rights", 
			AtomTextConstructElementType.Title => "title", 
			AtomTextConstructElementType.Subtitle => "subtitle", 
			AtomTextConstructElementType.Summary => "summary", 
			_ => null, 
		};

		public AtomTextConstruct()
		{
		}

		public AtomTextConstruct(AtomTextConstructElementType elementType)
		{
			atomTextConstructElementType_0 = elementType;
			atomTextConstructType_0 = AtomTextConstructType.text;
		}

		public AtomTextConstruct(AtomTextConstructElementType elementType, string text)
			: this(elementType)
		{
			string_1 = text;
		}

		protected override void SaveXmlAttributes(XmlWriter writer)
		{
			AtomBase.WriteEncodedAttributeString(writer, "type", Type.ToString());
			base.SaveXmlAttributes(writer);
		}

		protected override void SaveInnerXml(XmlWriter writer)
		{
			base.SaveInnerXml(writer);
			if (Type == AtomTextConstructType.xhtml)
			{
				if (Utilities.IsPersistable(string_1))
				{
					writer.WriteRaw(string_1);
				}
			}
			else
			{
				AtomBase.WriteEncodedString(writer, string_1);
			}
		}

		public override bool ShouldBePersisted()
		{
			if (!base.ShouldBePersisted())
			{
				return Utilities.IsPersistable(string_1);
			}
			return true;
		}
	}
}
