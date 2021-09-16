using System;
using System.Runtime.Serialization;

namespace Google.GData.Client
{
	[Serializable]
	public class GDataBatchRequestException : LoggedException
	{
		private AtomFeed batchResult;

		public AtomFeed BatchResult => batchResult;

		public GDataBatchRequestException()
		{
		}

		public GDataBatchRequestException(AtomFeed batchResult)
		{
			this.batchResult = batchResult;
		}

		public GDataBatchRequestException(string msg)
			: base(msg)
		{
		}

		public GDataBatchRequestException(string msg, Exception innerException)
			: base(msg, innerException)
		{
		}

		protected GDataBatchRequestException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
