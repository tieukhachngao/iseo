using System;

namespace CookComputing.XmlRpc
{
	public class XmlRpcDateTime
	{
		private DateTime dateTime_0;

		public XmlRpcDateTime()
		{
			dateTime_0 = default(DateTime);
		}

		public XmlRpcDateTime(DateTime val)
		{
			dateTime_0 = val;
		}

		public override string ToString()
		{
			return dateTime_0.ToString();
		}

		public override int GetHashCode()
		{
			return dateTime_0.GetHashCode();
		}

		public override bool Equals(object o)
		{
			if (o != null && o is XmlRpcDateTime)
			{
				XmlRpcDateTime xmlRpcDateTime = o as XmlRpcDateTime;
				return xmlRpcDateTime.dateTime_0 == dateTime_0;
			}
			return false;
		}

		public static bool operator ==(XmlRpcDateTime xi, XmlRpcDateTime xj)
		{
			if ((object)xi == null && (object)xj == null)
			{
				return true;
			}
			if ((object)xi != null && (object)xj != null)
			{
				return xi.dateTime_0 == xj.dateTime_0;
			}
			return false;
		}

		public static bool operator !=(XmlRpcDateTime xi, XmlRpcDateTime xj)
		{
			return !(xi == xj);
		}

		public static implicit operator DateTime(XmlRpcDateTime x)
		{
			return x.dateTime_0;
		}

		public static implicit operator XmlRpcDateTime(DateTime x)
		{
			return new XmlRpcDateTime(x);
		}
	}
}
