namespace CookComputing.XmlRpc
{
	public class XmlRpcDouble
	{
		private double double_0;

		public XmlRpcDouble()
		{
			double_0 = 0.0;
		}

		public XmlRpcDouble(double val)
		{
			double_0 = val;
		}

		public override string ToString()
		{
			return double_0.ToString();
		}

		public override int GetHashCode()
		{
			return double_0.GetHashCode();
		}

		public override bool Equals(object o)
		{
			if (o != null && o is XmlRpcDouble)
			{
				XmlRpcDouble xmlRpcDouble = o as XmlRpcDouble;
				return xmlRpcDouble.double_0 == double_0;
			}
			return false;
		}

		public static bool operator ==(XmlRpcDouble xi, XmlRpcDouble xj)
		{
			if ((object)xi == null && (object)xj == null)
			{
				return true;
			}
			if ((object)xi != null && (object)xj != null)
			{
				return xi.double_0 == xj.double_0;
			}
			return false;
		}

		public static bool operator !=(XmlRpcDouble xi, XmlRpcDouble xj)
		{
			return !(xi == xj);
		}

		public static implicit operator double(XmlRpcDouble x)
		{
			return x.double_0;
		}

		public static implicit operator XmlRpcDouble(double x)
		{
			return new XmlRpcDouble(x);
		}
	}
}
