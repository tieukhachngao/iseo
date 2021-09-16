using System;

namespace Google.GData.Client
{
	[Serializable]
	public class AccountDisabledException : AuthenticationException
	{
		public AccountDisabledException()
		{
		}

		public AccountDisabledException(string msg)
			: base(msg)
		{
		}

		public AccountDisabledException(string msg, Exception e)
			: base(msg, e)
		{
		}
	}
}
