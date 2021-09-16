using System;
using System.IO;
using System.Threading;

namespace Google.GData.Client
{
	public class AsyncSendData : AsyncData, IAsyncEntryData
	{
		private AtomEntry atomEntry_0;

		private GDataRequestType gdataRequestType_0;

		private string string_1;

		private string string_2;

		public AtomEntry Entry
		{
			get
			{
				return atomEntry_0;
			}
			set
			{
				atomEntry_0 = value;
			}
		}

		public string ContentType => string_1;

		public string SlugHeader => string_2;

		public GDataRequestType Type => gdataRequestType_0;

		private AsyncSendData(AsyncDataHandler A_0, Uri A_1, AtomEntry A_2, AtomFeed A_3, SendOrPostCallback A_4, object A_5, bool A_6)
			: base(A_1, null, A_5, A_4, A_6)
		{
			base.DataHandler = A_0;
			atomEntry_0 = A_2;
			base.Feed = A_3;
		}

		public AsyncSendData(AsyncDataHandler handler, Uri uriToUse, AtomEntry entry, SendOrPostCallback callback, object userData)
			: this(handler, uriToUse, entry, null, callback, userData, A_6: false)
		{
		}

		public AsyncSendData(AsyncDataHandler handler, AtomEntry entry, SendOrPostCallback callback, object userData)
			: this(handler, null, entry, null, callback, userData, A_6: false)
		{
		}

		public AsyncSendData(AsyncDataHandler handler, Uri uriToUse, AtomFeed feed, SendOrPostCallback callback, object userData)
			: this(handler, uriToUse, null, feed, callback, userData, A_6: false)
		{
		}

		public AsyncSendData(AsyncDataHandler handler, Uri uriToUse, Stream stream, GDataRequestType type, string contentType, string slugHeader, SendOrPostCallback callback, object userData, bool parseFeed)
			: this(handler, uriToUse, null, null, callback, userData, parseFeed)
		{
			base.DataStream = stream;
			gdataRequestType_0 = type;
			string_1 = contentType;
			string_2 = slugHeader;
		}
	}
}
