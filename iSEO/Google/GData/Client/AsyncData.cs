using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Google.GData.Client
{
	public class AsyncData
	{
		private Uri uri_0;

		private object object_0;

		private string string_0;

		private AsyncOperation asyncOperation_0;

		private Exception exception_0;

		private AtomFeed atomFeed_0;

		private Stream stream_0;

		private SendOrPostCallback sendOrPostCallback_0;

		private AsyncDataHandler asyncDataHandler_0;

		[CompilerGenerated]
		private bool bool_0;

		public Uri UriToUse
		{
			get
			{
				return uri_0;
			}
			set
			{
				uri_0 = value;
			}
		}

		public string HttpVerb
		{
			get
			{
				return string_0;
			}
			set
			{
				string_0 = value;
			}
		}

		public AsyncDataHandler DataHandler
		{
			get
			{
				return asyncDataHandler_0;
			}
			set
			{
				asyncDataHandler_0 = value;
			}
		}

		public object UserData => object_0;

		public AtomFeed Feed
		{
			get
			{
				return atomFeed_0;
			}
			set
			{
				atomFeed_0 = value;
			}
		}

		public AsyncOperation Operation
		{
			get
			{
				return asyncOperation_0;
			}
			set
			{
				asyncOperation_0 = value;
			}
		}

		public SendOrPostCallback Delegate => sendOrPostCallback_0;

		public Exception Exception
		{
			get
			{
				return exception_0;
			}
			set
			{
				exception_0 = value;
			}
		}

		public Stream DataStream
		{
			get
			{
				return stream_0;
			}
			set
			{
				stream_0 = value;
			}
		}

		public bool ParseFeed
		{
			[CompilerGenerated]
			get
			{
				return bool_0;
			}
			[CompilerGenerated]
			private set
			{
				bool_0 = value;
			}
		}

		public AsyncData(Uri uri, AsyncOperation op, object userData, SendOrPostCallback callback, bool parseFeed)
		{
			uri_0 = uri;
			asyncOperation_0 = op;
			object_0 = userData;
			sendOrPostCallback_0 = callback;
			ParseFeed = parseFeed;
		}

		public AsyncData(Uri uri, AsyncOperation op, object userData, SendOrPostCallback callback)
			: this(uri, op, userData, callback, parseFeed: false)
		{
		}

		public AsyncData(Uri uri, object userData, SendOrPostCallback callback)
			: this(uri, null, userData, callback)
		{
		}
	}
}
