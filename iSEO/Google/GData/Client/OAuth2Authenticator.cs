using System.Net;

namespace Google.GData.Client
{
	public class OAuth2Authenticator : Authenticator
	{
		private OAuth2Parameters oauth2Parameters_0;

		public OAuth2Authenticator(string applicationName, OAuth2Parameters parameters)
			: base(applicationName)
		{
			oauth2Parameters_0 = parameters;
		}

		public override void ApplyAuthenticationToRequest(HttpWebRequest request)
		{
			base.ApplyAuthenticationToRequest(request);
			if (!string.IsNullOrEmpty(oauth2Parameters_0.AccessCode) && string.IsNullOrEmpty(oauth2Parameters_0.AccessToken))
			{
				OAuthUtil.GetAccessToken(oauth2Parameters_0);
			}
			request.Headers.Set("Authorization", $"{oauth2Parameters_0.TokenType} {oauth2Parameters_0.AccessToken}");
		}
	}
}
