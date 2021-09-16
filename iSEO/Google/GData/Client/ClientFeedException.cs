using System;
using System.Runtime.Serialization;

namespace Google.GData.Client
{
	[Serializable]
	public class ClientFeedException : LoggedException
	{
		public ClientFeedException()
		{
		}

		public ClientFeedException(string msg)
			: base(msg)
		{
		}

		public ClientFeedException(string msg, Exception innerException)
			: base(msg, innerException)
		{
		}

		protected ClientFeedException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
