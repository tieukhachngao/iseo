namespace CookComputing.XmlRpc
{
	public class XmlRpcMissingUrl : XmlRpcException
	{
		public XmlRpcMissingUrl()
		{
		}

		public XmlRpcMissingUrl(string msg)
			: base(msg)
		{
		}
	}
}
