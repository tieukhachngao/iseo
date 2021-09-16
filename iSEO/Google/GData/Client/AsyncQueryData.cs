using System;
using System.ComponentModel;
using System.Threading;

namespace Google.GData.Client
{
	public class AsyncQueryData : AsyncData
	{
		private DateTime dateTime_0;

		private bool bool_1;

		public DateTime Modified
		{
			get
			{
				return dateTime_0;
			}
			set
			{
				dateTime_0 = value;
			}
		}

		public AsyncQueryData(Uri uri, DateTime timeStamp, bool doParse, AsyncOperation op, object userData, SendOrPostCallback callback)
			: base(uri, op, userData, callback, doParse)
		{
			dateTime_0 = timeStamp;
			bool_1 = doParse;
		}
	}
}
