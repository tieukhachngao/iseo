using System;

namespace Google.GData.Client
{
	[Serializable]
	public class NotVerifiedException : AuthenticationException
	{
		public NotVerifiedException()
		{
		}

		public NotVerifiedException(string msg)
			: base(msg)
		{
		}

		public NotVerifiedException(string msg, Exception e)
			: base(msg, e)
		{
		}
	}
}
