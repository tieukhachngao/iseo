using System.ComponentModel;
using System.IO;

namespace Google.GData.Client
{
	public class AsyncOperationCompletedEventArgs : AsyncCompletedEventArgs
	{
		private AtomFeed atomFeed_0;

		private Stream stream_0;

		private AtomEntry atomEntry_0;

		public AtomFeed Feed => atomFeed_0;

		public AtomEntry Entry => atomEntry_0;

		public Stream ResponseStream => stream_0;

		internal AsyncOperationCompletedEventArgs(AsyncData A_0)
			: base(A_0.Exception, cancelled: false, A_0.UserData)
		{
			atomFeed_0 = A_0.Feed;
			stream_0 = A_0.DataStream;
			IAsyncEntryData asyncEntryData = A_0 as IAsyncEntryData;
			if (asyncEntryData != null)
			{
				atomEntry_0 = asyncEntryData.Entry;
			}
		}

		internal AsyncOperationCompletedEventArgs(AsyncData A_0, bool A_1)
			: base(A_0.Exception, A_1, A_0.UserData)
		{
		}
	}
}
