using System;
using System.Xml;

namespace Google.GData.Client
{
	public class AtomCategory : AtomBase, IEquatable<AtomCategory>
	{
		private string string_1;

		private AtomUri atomUri_2;

		private string string_2;

		public override string XmlName => "category";

		public string Term
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

		public string Label
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

		public AtomUri Scheme
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

		public string UriString
		{
			get
			{
				string text = string.Empty;
				if (atomUri_2 != null)
				{
					text = string.Concat("{", Scheme, "}");
				}
				if (Utilities.IsPersistable(Term))
				{
					return text + Term;
				}
				return null;
			}
		}

		public AtomCategory()
		{
		}

		public AtomCategory(string term)
		{
			Term = term;
			Scheme = null;
		}

		public AtomCategory(string term, AtomUri scheme)
		{
			Term = term;
			Scheme = scheme;
		}

		public AtomCategory(string term, AtomUri scheme, string label)
		{
			Term = term;
			Scheme = scheme;
			string_2 = label;
		}

		protected override void SaveXmlAttributes(XmlWriter writer)
		{
			AtomBase.WriteEncodedAttributeString(writer, "term", Term);
			AtomBase.WriteEncodedAttributeString(writer, "scheme", Scheme);
			AtomBase.WriteEncodedAttributeString(writer, "label", Label);
			base.SaveXmlAttributes(writer);
		}

		public override bool ShouldBePersisted()
		{
			if (!base.ShouldBePersisted())
			{
				if (!Utilities.IsPersistable(string_1) && !Utilities.IsPersistable(string_2))
				{
					return Utilities.IsPersistable(atomUri_2);
				}
				return true;
			}
			return true;
		}

		public bool Equals(AtomCategory other)
		{
			if (object.ReferenceEquals(null, other))
			{
				return false;
			}
			if (object.ReferenceEquals(this, other))
			{
				return true;
			}
			if (object.Equals(other.string_1, string_1))
			{
				if (!(other.atomUri_2 == null) && !(atomUri_2 == null))
				{
					return object.Equals(other.atomUri_2, atomUri_2);
				}
				return true;
			}
			return false;
		}

		public override bool Equals(object obj)
		{
			if (object.ReferenceEquals(null, obj))
			{
				return false;
			}
			if (object.ReferenceEquals(this, obj))
			{
				return true;
			}
			if ((object)obj.GetType() != typeof(AtomCategory))
			{
				return false;
			}
			return Equals((AtomCategory)obj);
		}

		public override int GetHashCode()
		{
			return (((string_1 != null) ? string_1.GetHashCode() : 0) * 397) ^ ((atomUri_2 != null) ? atomUri_2.GetHashCode() : 0);
		}
	}
}
