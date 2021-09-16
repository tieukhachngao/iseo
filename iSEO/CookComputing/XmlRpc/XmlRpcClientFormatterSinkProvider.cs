using System.Collections;
using System.Runtime.Remoting.Channels;

namespace CookComputing.XmlRpc
{
	public class XmlRpcClientFormatterSinkProvider : IClientFormatterSinkProvider
	{
		private IClientChannelSinkProvider iclientChannelSinkProvider_0;

		public IClientChannelSinkProvider Next
		{
			get
			{
				return iclientChannelSinkProvider_0;
			}
			set
			{
				iclientChannelSinkProvider_0 = value;
			}
		}

		public XmlRpcClientFormatterSinkProvider(IDictionary properties, ICollection providerData)
		{
		}

		public XmlRpcClientFormatterSinkProvider()
		{
		}

		public IClientChannelSink CreateSink(IChannelSender channel, string url, object remoteChannelData)
		{
			IClientChannelSink clientChannelSink = null;
			if (iclientChannelSinkProvider_0 != null)
			{
				clientChannelSink = iclientChannelSinkProvider_0.CreateSink(channel, url, remoteChannelData);
				if (clientChannelSink == null)
				{
					return null;
				}
			}
			return new XmlRpcClientFormatterSink(clientChannelSink);
		}
	}
}
