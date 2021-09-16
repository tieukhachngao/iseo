using System;
using System.ComponentModel;

namespace Google.GData.Client
{
	[Description("Expand to see the link attributes for the Id.")]
	[TypeConverter(typeof(AtomBaseLinkConverter))]
	public class AtomId : AtomBaseLink, IComparable
	{
		public override string XmlName => "id";

		public AtomId()
		{
		}

		public AtomId(string link)
		{
			base.Uri = new AtomUri(link);
		}

		public override int GetHashCode()
		{
			return base.Uri.GetHashCode();
		}

		public int CompareTo(object obj)
		{
			AtomId atomId = obj as AtomId;
			if (atomId == null)
			{
				return -1;
			}
			if (base.Uri != null)
			{
				return base.Uri.CompareTo(atomId.Uri);
			}
			if (atomId.Uri == null)
			{
				return 0;
			}
			return -1;
		}

		public override bool Equals(object obj)
		{
			return CompareTo(obj) == 0;
		}

		public static bool operator ==(AtomId a, AtomId b)
		{
			if ((object)a == null && (object)b == null)
			{
				return true;
			}
			if ((object)a != null && (object)b != null)
			{
				return a.Equals(b);
			}
			return false;
		}

		public static bool operator !=(AtomId a, AtomId b)
		{
			return !(a == b);
		}
	}
}
