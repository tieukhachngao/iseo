using System;

namespace Google.GData.Client
{
	[Serializable]
	public class AccountDeletedException : AuthenticationException
	{
		public AccountDeletedException()
		{
		}

		public AccountDeletedException(string msg)
			: base(msg)
		{
		}

		public AccountDeletedException(string msg, Exception e)
			: base(msg, e)
		{
		}
	}
}
