using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Google.GData.Client
{
	public class OAuthUtil
	{
		private static string string_0 = "https://www.google.com/accounts/OAuthGetRequestToken";

		private static string string_1 = "https://www.google.com/accounts/OAuthAuthorizeToken";

		private static string string_2 = "https://www.google.com/accounts/OAuthGetAccessToken";

		public static string GenerateHeader(Uri uri, string consumerKey, string consumerSecret, string httpMethod)
		{
			return GenerateHeader(uri, consumerKey, consumerSecret, string.Empty, string.Empty, httpMethod);
		}

		public static string GenerateHeader(Uri uri, string consumerKey, string consumerSecret, string token, string tokenSecret, string httpMethod)
		{
			OAuthParameters oAuthParameters = new OAuthParameters();
			oAuthParameters.ConsumerKey = consumerKey;
			oAuthParameters.ConsumerSecret = consumerSecret;
			oAuthParameters.Token = token;
			oAuthParameters.TokenSecret = tokenSecret;
			oAuthParameters.SignatureMethod = "HMAC-SHA1";
			OAuthParameters parameters = oAuthParameters;
			return GenerateHeader(uri, httpMethod, parameters);
		}

		public static string GenerateHeader(Uri uri, string httpMethod, OAuthParameters parameters)
		{
			parameters.Timestamp = OAuthBase.GenerateTimeStamp();
			parameters.Nonce = OAuthBase.GenerateNonce();
			string value = OAuthBase.GenerateSignature(uri, httpMethod, parameters);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("Authorization: OAuth {0}=\"{1}\",", OAuthBase.OAuthVersionKey, OAuthBase.OAuthVersion);
			stringBuilder.AppendFormat("{0}=\"{1}\",", OAuthBase.OAuthNonceKey, OAuthBase.EncodingPerRFC3986(parameters.Nonce));
			stringBuilder.AppendFormat("{0}=\"{1}\",", OAuthBase.OAuthTimestampKey, OAuthBase.EncodingPerRFC3986(parameters.Timestamp));
			stringBuilder.AppendFormat("{0}=\"{1}\",", OAuthBase.OAuthConsumerKeyKey, OAuthBase.EncodingPerRFC3986(parameters.ConsumerKey));
			if (parameters.BaseProperties.ContainsKey(OAuthBase.OAuthVerifierKey))
			{
				stringBuilder.AppendFormat("{0}=\"{1}\",", OAuthBase.OAuthVerifierKey, OAuthBase.EncodingPerRFC3986(parameters.BaseProperties[OAuthBase.OAuthVerifierKey]));
			}
			if (!string.IsNullOrEmpty(parameters.Token))
			{
				stringBuilder.AppendFormat("{0}=\"{1}\",", OAuthBase.OAuthTokenKey, OAuthBase.EncodingPerRFC3986(parameters.Token));
			}
			if (parameters.BaseProperties.ContainsKey(OAuthBase.OAuthCallbackKey))
			{
				stringBuilder.AppendFormat("{0}=\"{1}\",", OAuthBase.OAuthCallbackKey, OAuthBase.EncodingPerRFC3986(parameters.BaseProperties[OAuthBase.OAuthCallbackKey]));
			}
			stringBuilder.AppendFormat("{0}=\"{1}\",", OAuthBase.OAuthSignatureMethodKey, "HMAC-SHA1");
			stringBuilder.AppendFormat("{0}=\"{1}\"", OAuthBase.OAuthSignatureKey, OAuthBase.EncodingPerRFC3986(value));
			return stringBuilder.ToString();
		}

		public static void GetUnauthorizedRequestToken(OAuthParameters parameters)
		{
			Uri uri = new Uri($"{string_0}?scope={OAuthBase.EncodingPerRFC3986(parameters.Scope)}");
			bool flag = false;
			if (!string.IsNullOrEmpty(parameters.Callback))
			{
				parameters.BaseProperties.Add(OAuthBase.OAuthCallbackKey, parameters.Callback);
				flag = true;
			}
			string header = GenerateHeader(uri, "GET", parameters);
			WebRequest webRequest = WebRequest.Create(uri);
			webRequest.Headers.Add(header);
			WebResponse response = webRequest.GetResponse();
			string querystring = "";
			if (response != null)
			{
				Stream responseStream = response.GetResponseStream();
				StreamReader streamReader = new StreamReader(responseStream);
				querystring = streamReader.ReadToEnd();
			}
			if (flag)
			{
				parameters.BaseProperties.Remove(OAuthBase.OAuthCallbackKey);
			}
			SortedDictionary<string, string> queryParameters = OAuthBase.GetQueryParameters(querystring);
			parameters.Token = queryParameters[OAuthBase.OAuthTokenKey];
			parameters.TokenSecret = queryParameters[OAuthBase.OAuthTokenSecretKey];
		}

		public static string CreateUserAuthorizationUrl(OAuthParameters parameters)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(string_1);
			stringBuilder.AppendFormat("?{0}={1}", OAuthBase.OAuthTokenKey, OAuthBase.EncodingPerRFC3986(parameters.Token));
			if (!string.IsNullOrEmpty(parameters.Callback))
			{
				stringBuilder.AppendFormat("&{0}={1}", OAuthBase.OAuthCallbackKey, OAuthBase.EncodingPerRFC3986(parameters.Callback));
			}
			return stringBuilder.ToString();
		}

		public static void UpdateOAuthParametersFromCallback(string queryString, OAuthParameters parameters)
		{
			SortedDictionary<string, string> queryParameters = OAuthBase.GetQueryParameters(queryString);
			parameters.Token = queryParameters[OAuthBase.OAuthTokenKey];
			if (queryParameters.ContainsKey(OAuthBase.OAuthTokenSecretKey))
			{
				parameters.TokenSecret = queryParameters[OAuthBase.OAuthTokenSecretKey];
			}
			if (queryParameters.ContainsKey(OAuthBase.OAuthVerifierKey))
			{
				parameters.Verifier = queryParameters[OAuthBase.OAuthVerifierKey];
			}
		}

		public static void GetAccessToken(OAuthParameters parameters)
		{
			Uri uri = new Uri(string_2);
			string header = GenerateHeader(uri, "GET", parameters);
			WebRequest webRequest = WebRequest.Create(uri);
			webRequest.Headers.Add(header);
			WebResponse response = webRequest.GetResponse();
			string querystring = "";
			if (response != null)
			{
				Stream responseStream = response.GetResponseStream();
				StreamReader streamReader = new StreamReader(responseStream);
				querystring = streamReader.ReadToEnd();
			}
			SortedDictionary<string, string> queryParameters = OAuthBase.GetQueryParameters(querystring);
			parameters.Token = queryParameters[OAuthBase.OAuthTokenKey];
			parameters.TokenSecret = queryParameters[OAuthBase.OAuthTokenSecretKey];
		}

		public static string CreateOAuth2AuthorizationUrl(OAuth2Parameters parameters)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(parameters.AuthUri);
			stringBuilder.AppendFormat("?{0}={1}", OAuthBase.OAuth2ResponseType, OAuthBase.EncodingPerRFC3986(parameters.ResponseType));
			stringBuilder.AppendFormat("&{0}={1}", OAuthBase.OAuth2ClientId, OAuthBase.EncodingPerRFC3986(parameters.ClientId));
			stringBuilder.AppendFormat("&{0}={1}", OAuthBase.OAuth2RedirectUri, OAuthBase.EncodingPerRFC3986(parameters.RedirectUri));
			stringBuilder.AppendFormat("&{0}={1}", OAuthBase.OAuthScopeKey, OAuthBase.EncodingPerRFC3986(parameters.Scope));
			stringBuilder.AppendFormat("&{0}={1}", OAuthBase.OAuth2AccessType, OAuthBase.EncodingPerRFC3986(parameters.AccessType));
			stringBuilder.AppendFormat("&{0}={1}", OAuthBase.OAuth2ApprovalPrompt, OAuthBase.EncodingPerRFC3986(parameters.ApprovalPrompt));
			if (!string.IsNullOrEmpty(parameters.State))
			{
				stringBuilder.AppendFormat("&{0}={1}", OAuthBase.OAuth2State, OAuthBase.EncodingPerRFC3986(parameters.State));
			}
			return stringBuilder.ToString();
		}

		public static void GetAccessToken(string queryString, OAuth2Parameters parameters)
		{
			SortedDictionary<string, string> queryParameters = OAuthBase.GetQueryParameters(queryString);
			parameters.AccessCode = queryParameters[OAuthBase.OAuth2AccessCode];
			GetAccessToken(parameters);
		}

		public static void GetAccessToken(OAuth2Parameters parameters)
		{
			OAuthBase.GetOAuth2AccessToken(parameters, OAuthBase.GetExchangeAccessCodeRequestBody(parameters));
		}

		public static void RefreshAccessToken(OAuth2Parameters parameters)
		{
			OAuthBase.GetOAuth2AccessToken(parameters, OAuthBase.GetRefreshAccessTokenRequestBody(parameters));
		}
	}
}
