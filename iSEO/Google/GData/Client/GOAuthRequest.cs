using System;
using System.Net;

namespace Google.GData.Client
{
	public class GOAuthRequest : GDataGAuthRequest
	{
		private GOAuthRequestFactory goauthRequestFactory_0;

		internal GOAuthRequest(GDataRequestType A_0, Uri A_1, GOAuthRequestFactory A_2)
			: base(A_0, A_1, A_2)
		{
			goauthRequestFactory_0 = A_2;
		}

		protected override void EnsureCredentials()
		{
			HttpWebRequest httpWebRequest = base.Request as HttpWebRequest;
			if (string.IsNullOrEmpty(goauthRequestFactory_0.ConsumerKey) || string.IsNullOrEmpty(goauthRequestFactory_0.ConsumerSecret))
			{
				throw new GDataRequestException("ConsumerKey and ConsumerSecret must be provided to use GOAuthRequestFactory");
			}
			string header = OAuthUtil.GenerateHeader(httpWebRequest.RequestUri, goauthRequestFactory_0.ConsumerKey, goauthRequestFactory_0.ConsumerSecret, goauthRequestFactory_0.Token, goauthRequestFactory_0.TokenSecret, httpWebRequest.Method);
			base.Request.Headers.Remove("Authorization");
			base.Request.Headers.Add(header);
		}
	}
}
