using System.Collections;
using System.Runtime.Remoting.Channels;

namespace CookComputing.XmlRpc
{
	public class XmlRpcServerFormatterSinkProvider : IServerFormatterSinkProvider
	{
		private IServerChannelSinkProvider iserverChannelSinkProvider_0;

		public IServerChannelSinkProvider Next
		{
			get
			{
				return iserverChannelSinkProvider_0;
			}
			set
			{
				iserverChannelSinkProvider_0 = value;
			}
		}

		public XmlRpcServerFormatterSinkProvider(IDictionary properties, ICollection providerData)
		{
		}

		public XmlRpcServerFormatterSinkProvider()
		{
		}

		public IServerChannelSink CreateSink(IChannelReceiver channel)
		{
			IServerChannelSink next = null;
			if (iserverChannelSinkProvider_0 != null)
			{
				next = iserverChannelSinkProvider_0.CreateSink(channel);
			}
			return new XmlRpcServerFormatterSink(next);
		}

		public void GetChannelData(IChannelDataStore channelData)
		{
		}
	}
}
