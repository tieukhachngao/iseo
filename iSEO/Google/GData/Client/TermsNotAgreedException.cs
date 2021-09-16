using System;

namespace Google.GData.Client
{
	[Serializable]
	public class TermsNotAgreedException : AuthenticationException
	{
		public TermsNotAgreedException()
		{
		}

		public TermsNotAgreedException(string msg)
			: base(msg)
		{
		}

		public TermsNotAgreedException(string msg, Exception e)
			: base(msg, e)
		{
		}
	}
}
