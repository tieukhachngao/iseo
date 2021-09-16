namespace CookComputing.XmlRpc
{
	public class XmlRpcInt
	{
		private int int_0;

		public XmlRpcInt()
		{
			int_0 = 0;
		}

		public XmlRpcInt(int val)
		{
			int_0 = val;
		}

		public override string ToString()
		{
			return int_0.ToString();
		}

		public override int GetHashCode()
		{
			return int_0.GetHashCode();
		}

		public override bool Equals(object o)
		{
			if (o != null && o is XmlRpcInt)
			{
				XmlRpcInt xmlRpcInt = o as XmlRpcInt;
				return xmlRpcInt.int_0 == int_0;
			}
			return false;
		}

		public static bool operator ==(XmlRpcInt xi, XmlRpcInt xj)
		{
			if ((object)xi == null && (object)xj == null)
			{
				return true;
			}
			if ((object)xi != null && (object)xj != null)
			{
				return xi.int_0 == xj.int_0;
			}
			return false;
		}

		public static bool operator !=(XmlRpcInt xi, XmlRpcInt xj)
		{
			return !(xi == xj);
		}

		public static implicit operator int(XmlRpcInt x)
		{
			return x.int_0;
		}

		public static implicit operator XmlRpcInt(int x)
		{
			return new XmlRpcInt(x);
		}
	}
}
