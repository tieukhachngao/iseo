using System.Globalization;
using System.Xml;

namespace Google.GData.Client
{
	public class AtomLink : AtomBase
	{
		public const string HTML_TYPE = "text/html";

		public const string ATOM_TYPE = "application/atom+xml";

		private AtomUri atomUri_2;

		private string string_1;

		private string string_2;

		private string string_3;

		private string string_4;

		private int int_0;

		public AtomUri HRef
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

		public string AbsoluteUri
		{
			get
			{
				if (HRef != null)
				{
					return GetAbsoluteUri(HRef.ToString());
				}
				return null;
			}
		}

		public string Rel
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

		public string Type
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

		public string HRefLang
		{
			get
			{
				return string_3;
			}
			set
			{
				base.Dirty = true;
				string_3 = value;
			}
		}

		public int Length
		{
			get
			{
				return int_0;
			}
			set
			{
				base.Dirty = true;
				int_0 = value;
			}
		}

		public string Title
		{
			get
			{
				return string_4;
			}
			set
			{
				base.Dirty = true;
				string_4 = value;
			}
		}

		public override string XmlName => "link";

		public AtomLink()
		{
		}

		public AtomLink(string link)
		{
			HRef = new AtomUri(link);
		}

		public AtomLink(string type, string rel)
		{
			Type = type;
			Rel = rel;
		}

		protected override void SaveXmlAttributes(XmlWriter writer)
		{
			AtomBase.WriteEncodedAttributeString(writer, "href", HRef);
			AtomBase.WriteEncodedAttributeString(writer, "hreflang", HRefLang);
			AtomBase.WriteEncodedAttributeString(writer, "rel", Rel);
			AtomBase.WriteEncodedAttributeString(writer, "type", Type);
			if (int_0 > 0)
			{
				AtomBase.WriteEncodedAttributeString(writer, "length", Length.ToString(CultureInfo.InvariantCulture));
			}
			AtomBase.WriteEncodedAttributeString(writer, "title", Title);
			base.SaveXmlAttributes(writer);
		}

		public override bool ShouldBePersisted()
		{
			if (base.ShouldBePersisted())
			{
				return true;
			}
			if (Utilities.IsPersistable(atomUri_2))
			{
				return true;
			}
			if (Utilities.IsPersistable(string_3))
			{
				return true;
			}
			if (Utilities.IsPersistable(string_1))
			{
				return true;
			}
			if (Utilities.IsPersistable(string_2))
			{
				return true;
			}
			if (Utilities.IsPersistable(Length))
			{
				return true;
			}
			if (Utilities.IsPersistable(string_4))
			{
				return true;
			}
			return false;
		}
	}
}
