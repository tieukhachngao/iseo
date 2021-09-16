using System.Net;

namespace Google.GData.Client
{
	public class OAuth3LeggedAuthenticator : OAuthAuthenticator
	{
		private string string_4;

		private string string_5;

		private OAuthParameters oauthParameters_0;

		public string Token => oauthParameters_0.Token;

		public string TokenSecret => oauthParameters_0.TokenSecret;

		public OAuth3LeggedAuthenticator(string applicationName, string consumerKey, string consumerSecret, string token, string tokenSecret, string scope, string signatureMethod)
			: base(applicationName, consumerKey, consumerSecret)
		{
			oauthParameters_0 = new OAuthParameters
			{
				ConsumerKey = consumerKey,
				ConsumerSecret = consumerSecret,
				Token = token,
				TokenSecret = tokenSecret,
				Scope = scope,
				SignatureMethod = signatureMethod
			};
		}

		public override void ApplyAuthenticationToRequest(HttpWebRequest request)
		{
			base.ApplyAuthenticationToRequest(request);
			string header = OAuthUtil.GenerateHeader(request.RequestUri, request.Method, oauthParameters_0);
			request.Headers.Add(header);
		}
	}
}
