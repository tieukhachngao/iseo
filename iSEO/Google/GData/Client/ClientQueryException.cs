using System;
using System.Runtime.Serialization;

namespace Google.GData.Client
{
	[Serializable]
	public class ClientQueryException : LoggedException
	{
		public ClientQueryException()
		{
		}

		public ClientQueryException(string msg)
			: base(msg)
		{
		}

		public ClientQueryException(string msg, Exception innerException)
			: base(msg, innerException)
		{
		}

		protected ClientQueryException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
