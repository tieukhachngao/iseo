namespace CookComputing.XmlRpc
{
	public class XmlRpcResponse
	{
		public object retVal;

		public XmlRpcResponse()
		{
			retVal = null;
		}

		public XmlRpcResponse(object retValue)
		{
			retVal = retValue;
		}
	}
}
