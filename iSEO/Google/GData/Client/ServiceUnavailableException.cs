using System;

namespace Google.GData.Client
{
	[Serializable]
	public class ServiceUnavailableException : AuthenticationException
	{
		public ServiceUnavailableException()
		{
		}

		public ServiceUnavailableException(string msg)
			: base(msg)
		{
		}

		public ServiceUnavailableException(string msg, Exception e)
			: base(msg, e)
		{
		}
	}
}
