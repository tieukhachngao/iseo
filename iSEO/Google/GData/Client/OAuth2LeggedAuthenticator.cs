using System;
using System.Net;

namespace Google.GData.Client
{
	public class OAuth2LeggedAuthenticator : OAuthAuthenticator
	{
		private string string_4;

		private string string_5;

		private OAuthParameters oauthParameters_0;

		public static string OAuthParameter = "xoauth_requestor_id";

		public string OAuthUser => string_4;

		public string OAuthDomain => string_5;

		public OAuth2LeggedAuthenticator(string applicationName, string consumerKey, string consumerSecret, string user, string domain, string signatureMethod)
			: base(applicationName, consumerKey, consumerSecret)
		{
			string_4 = user;
			string_5 = domain;
			oauthParameters_0 = new OAuthParameters
			{
				ConsumerKey = consumerKey,
				ConsumerSecret = consumerSecret,
				SignatureMethod = signatureMethod
			};
		}

		public override void ApplyAuthenticationToRequest(HttpWebRequest request)
		{
			base.ApplyAuthenticationToRequest(request);
			string header = OAuthUtil.GenerateHeader(request.RequestUri, request.Method, oauthParameters_0);
			request.Headers.Add(header);
		}

		public override Uri ApplyAuthenticationToUri(Uri source)
		{
			UriBuilder uriBuilder = new UriBuilder(source);
			string text = OAuthParameter + "=" + string_4 + "%40" + OAuthDomain;
			if (uriBuilder.Query != null && uriBuilder.Query.Length > 1)
			{
				uriBuilder.Query = uriBuilder.Query.Substring(1) + "&" + text;
			}
			else
			{
				uriBuilder.Query = text;
			}
			return uriBuilder.Uri;
		}
	}
}
