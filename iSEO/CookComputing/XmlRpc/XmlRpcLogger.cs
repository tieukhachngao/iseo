namespace CookComputing.XmlRpc
{
	public abstract class XmlRpcLogger
	{
		public void Attach(XmlRpcClientProtocol proxy)
		{
			proxy.RequestEvent += OnRequest;
			proxy.ResponseEvent += OnResponse;
		}

		public void Attach(IXmlRpcProxy proxy)
		{
			proxy.RequestEvent += OnRequest;
			proxy.ResponseEvent += OnResponse;
		}

		public void Detach(XmlRpcClientProtocol proxy)
		{
			proxy.RequestEvent -= OnRequest;
			proxy.ResponseEvent -= OnResponse;
		}

		public void Detach(IXmlRpcProxy proxy)
		{
			proxy.RequestEvent -= OnRequest;
			proxy.ResponseEvent -= OnResponse;
		}

		protected virtual void OnRequest(object sender, XmlRpcRequestEventArgs e)
		{
		}

		protected virtual void OnResponse(object sender, XmlRpcResponseEventArgs e)
		{
		}
	}
}
