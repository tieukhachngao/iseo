using System;

namespace Google.GData.Client
{
	[Serializable]
	public class AuthenticationException : LoggedException
	{
		public AuthenticationException()
		{
		}

		public AuthenticationException(string msg)
			: base(msg)
		{
		}

		public AuthenticationException(string msg, Exception e)
			: base(msg, e)
		{
		}
	}
}
