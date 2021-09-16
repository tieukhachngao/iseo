using System;

namespace Google.GData.Client
{
	public class AtomUri : IComparable
	{
		private string string_0;

		public string Content
		{
			get
			{
				return string_0;
			}
			set
			{
				string_0 = value;
			}
		}

		public AtomUri(Uri uri)
		{
			if (uri == null)
			{
				throw new ArgumentNullException("uri");
			}
			string_0 = HttpUtility.UrlDecode(uri.ToString());
		}

		public AtomUri(string str)
		{
			string_0 = str;
		}

		public override string ToString()
		{
			return string_0;
		}

		public static int Compare(AtomUri oneAtomUri, AtomUri anotherAtomUri)
		{
			if (oneAtomUri != null)
			{
				return oneAtomUri.CompareTo(anotherAtomUri);
			}
			if (anotherAtomUri == null)
			{
				return 0;
			}
			return -1;
		}

		public override int GetHashCode()
		{
			return ToString().GetHashCode();
		}

		public int CompareTo(object obj)
		{
			if (obj == null)
			{
				return -1;
			}
			if (!(obj is AtomUri))
			{
				return -1;
			}
			return string.Compare(ToString(), obj.ToString());
		}

		public override bool Equals(object obj)
		{
			return CompareTo(obj) == 0;
		}

		public static bool operator ==(AtomUri a, AtomUri b)
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

		public static bool operator !=(AtomUri a, AtomUri b)
		{
			return !(a == b);
		}

		public static bool operator >(AtomUri a, AtomUri b)
		{
			if (a != null)
			{
				return a.CompareTo(b) > 0;
			}
			return false;
		}

		public static bool operator <(AtomUri a, AtomUri b)
		{
			if (a != null)
			{
				return a.CompareTo(b) < 0;
			}
			return true;
		}

		public static bool operator >=(AtomUri a, AtomUri b)
		{
			if (a != null)
			{
				if (a.CompareTo(b) <= 0)
				{
					return a.Equals(b);
				}
				return true;
			}
			if (b == null)
			{
				return true;
			}
			return false;
		}

		public static bool operator <=(AtomUri a, AtomUri b)
		{
			if (a != null)
			{
				if (a.CompareTo(b) >= 0)
				{
					return a.Equals(b);
				}
				return true;
			}
			return true;
		}

		public static implicit operator AtomUri(string s)
		{
			return new AtomUri(s);
		}

		public static implicit operator AtomUri(Uri u)
		{
			return new AtomUri(u);
		}
	}
}
