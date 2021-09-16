namespace CookComputing.XmlRpc
{
	public class XmlRpcBoolean
	{
		private bool bool_0;

		public XmlRpcBoolean()
		{
		}

		public XmlRpcBoolean(bool val)
		{
			bool_0 = val;
		}

		public override string ToString()
		{
			return bool_0.ToString();
		}

		public override int GetHashCode()
		{
			return bool_0.GetHashCode();
		}

		public override bool Equals(object o)
		{
			if (o != null && o is XmlRpcBoolean)
			{
				XmlRpcBoolean xmlRpcBoolean = o as XmlRpcBoolean;
				return xmlRpcBoolean.bool_0 == bool_0;
			}
			return false;
		}

		public static bool operator ==(XmlRpcBoolean xi, XmlRpcBoolean xj)
		{
			if ((object)xi == null && (object)xj == null)
			{
				return true;
			}
			if ((object)xi != null && (object)xj != null)
			{
				return xi.bool_0 == xj.bool_0;
			}
			return false;
		}

		public static bool operator !=(XmlRpcBoolean xi, XmlRpcBoolean xj)
		{
			return !(xi == xj);
		}

		public static implicit operator bool(XmlRpcBoolean x)
		{
			return x.bool_0;
		}

		public static implicit operator XmlRpcBoolean(bool x)
		{
			return new XmlRpcBoolean(x);
		}
	}
}
