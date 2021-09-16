using System;

namespace Google.GData.Client
{
	[Serializable]
	public class CaptchaRequiredException : AuthenticationException
	{
		private string captchaUrl;

		private string captchaToken;

		public string Url => captchaUrl;

		public string Token => captchaToken;

		public CaptchaRequiredException()
		{
		}

		public CaptchaRequiredException(string msg, string url, string token)
			: base(msg)
		{
			captchaUrl = url;
			captchaToken = token;
		}

		public CaptchaRequiredException(string msg, Exception e)
			: base(msg, e)
		{
		}
	}
}
