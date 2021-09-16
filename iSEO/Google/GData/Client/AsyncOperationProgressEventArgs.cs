using System;
using System.ComponentModel;

namespace Google.GData.Client
{
	public class AsyncOperationProgressEventArgs : ProgressChangedEventArgs
	{
		private long long_0;

		private long long_1;

		private Uri uri_0;

		private string string_0;

		public long CompleteSize => long_0;

		public long Position => long_1;

		public Uri Uri => uri_0;

		public string HttpVerb => string_0;

		public AsyncOperationProgressEventArgs(long completeSize, long currentPosition, int percentage, Uri targetUri, string httpVerb, object userData)
			: base(percentage, userData)
		{
			long_0 = completeSize;
			long_1 = currentPosition;
			uri_0 = targetUri;
			string_0 = httpVerb;
		}
	}
}
