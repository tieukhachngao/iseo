#define USE_LOGGING
using System;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Google.GData.Client
{
	[Serializable]
	public class LoggedException : Exception
	{
		public LoggedException()
		{
		}

		public LoggedException(string msg)
			: base(msg)
		{
			EnsureLogging();
		}

		public LoggedException(string msg, Exception exception)
			: base(msg, exception)
		{
			EnsureLogging();
		}

		protected LoggedException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		[Conditional("USE_LOGGING")]
		protected static void EnsureLogging()
		{
		}
	}
}
