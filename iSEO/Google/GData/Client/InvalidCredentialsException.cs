using System;

namespace Google.GData.Client
{
	[Serializable]
	public class InvalidCredentialsException : AuthenticationException
	{
		public InvalidCredentialsException()
		{
		}

		public InvalidCredentialsException(string msg)
			: base(msg)
		{
		}

		public InvalidCredentialsException(string msg, Exception e)
			: base(msg, e)
		{
		}
	}
}
