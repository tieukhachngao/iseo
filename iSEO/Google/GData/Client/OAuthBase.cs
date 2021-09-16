using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;

namespace Google.GData.Client
{
	public class OAuthBase
	{
		public const string HMACSHA1SignatureType = "HMAC-SHA1";

		public const string PlainTextSignatureType = "PLAINTEXT";

		public const string RSASHA1SignatureType = "RSA-SHA1";

		public static string OAuthVersion = "1.0";

		public static string OAuthParameterPrefix = "oauth_";

		public static string OAuthConsumerKeyKey = "oauth_consumer_key";

		public static string OAuthConsumerSecretKey = "oauth_consumer_secret";

		public static string OAuthCallbackKey = "oauth_callback";

		public static string OAuthVersionKey = "oauth_version";

		public static string OAuthSignatureMethodKey = "oauth_signature_method";

		public static string OAuthSignatureKey = "oauth_signature";

		public static string OAuthTimestampKey = "oauth_timestamp";

		public static string OAuthNonceKey = "oauth_nonce";

		public static string OAuthTokenKey = "oauth_token";

		public static string OAuthTokenSecretKey = "oauth_token_secret";

		public static string OAuthVerifierKey = "oauth_verifier";

		public static string OAuthScopeKey = "scope";

		public static string OAuth2ClientId = "client_id";

		public static string OAuth2ClientSecret = "client_secret";

		public static string OAuth2RedirectUri = "redirect_uri";

		public static string OAuth2AccessType = "access_type";

		public static string OAuth2GrantType = "grant_type";

		public static string OAuth2ResponseType = "response_type";

		public static string OAuth2State = "state";

		public static string OAuth2ApprovalPrompt = "approval_prompt";

		public static string OAuth2AccessCode = "code";

		public static string OAuth2AccessToken = "access_token";

		public static string OAuth2TokenType = "token_type";

		public static string OAuth2RefreshToken = "refresh_token";

		public static string OAuth2ExpiresIn = "expires_in";

		protected static string unreservedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_.~";

		private static string smethod_0(HashAlgorithm A_0, string A_1)
		{
			if (A_0 == null)
			{
				throw new ArgumentNullException("hashAlgorithm");
			}
			if (string.IsNullOrEmpty(A_1))
			{
				throw new ArgumentNullException("data");
			}
			byte[] bytes = Encoding.ASCII.GetBytes(A_1);
			byte[] inArray = A_0.ComputeHash(bytes);
			return Convert.ToBase64String(inArray);
		}

		public static SortedDictionary<string, string> GetQueryParameters(string querystring)
		{
			return GetQueryParameters(querystring, null);
		}

		public static SortedDictionary<string, string> GetQueryParameters(string querystring, IDictionary<string, string> dict)
		{
			if (querystring.StartsWith("?"))
			{
				querystring = querystring.Remove(0, 1);
			}
			SortedDictionary<string, string> sortedDictionary = ((dict == null) ? new SortedDictionary<string, string>() : new SortedDictionary<string, string>(dict));
			if (!string.IsNullOrEmpty(querystring))
			{
				string[] array = querystring.Split('&');
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (string.IsNullOrEmpty(text))
					{
						continue;
					}
					if (text.IndexOf('=') > -1)
					{
						string[] array3 = text.Split('=');
						string key = Utilities.UrlDecodedValue(array3[0]);
						string value = Utilities.UrlDecodedValue(array3[1]);
						if (sortedDictionary.ContainsKey(key))
						{
							sortedDictionary[key] = value;
						}
						else
						{
							sortedDictionary.Add(key, value);
						}
					}
					else
					{
						sortedDictionary.Add(Utilities.UrlDecodedValue(text), string.Empty);
					}
				}
			}
			return sortedDictionary;
		}

		public static string EncodingPerRFC3986(string value)
		{
			if (string.IsNullOrEmpty(value))
			{
				return string.Empty;
			}
			StringBuilder stringBuilder = new StringBuilder();
			foreach (char c in value)
			{
				if (unreservedChars.IndexOf(c) != -1)
				{
					stringBuilder.Append(c);
				}
				else
				{
					stringBuilder.Append('%' + $"{(int)c:X2}");
				}
			}
			return stringBuilder.ToString();
		}

		protected static string NormalizeRequestParameters(SortedDictionary<string, string> parameters)
		{
			if (parameters.Count == 0)
			{
				return "";
			}
			bool flag = true;
			StringBuilder stringBuilder = new StringBuilder();
			foreach (KeyValuePair<string, string> parameter in parameters)
			{
				if (!flag)
				{
					stringBuilder.Append("&");
				}
				flag = false;
				stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "{0}={1}", new object[2]
				{
					EncodingPerRFC3986(parameter.Key),
					EncodingPerRFC3986(parameter.Value)
				});
			}
			return stringBuilder.ToString();
		}

		public static string GenerateSignatureBase(Uri url, string consumerKey, string token, string tokenSecret, string httpMethod, string timeStamp, string nonce, string signatureType)
		{
			OAuthParameters oAuthParameters = new OAuthParameters();
			oAuthParameters.ConsumerKey = consumerKey;
			oAuthParameters.Token = token;
			oAuthParameters.TokenSecret = tokenSecret;
			oAuthParameters.Timestamp = timeStamp;
			oAuthParameters.Nonce = nonce;
			oAuthParameters.SignatureMethod = signatureType;
			OAuthParameters parameters = oAuthParameters;
			return GenerateSignatureBase(url, httpMethod, parameters);
		}

		public static string GenerateSignatureBase(Uri url, string httpMethod, OAuthParameters parameters)
		{
			if (string.IsNullOrEmpty(parameters.ConsumerKey))
			{
				throw new ArgumentNullException("consumerKey");
			}
			if (string.IsNullOrEmpty(httpMethod))
			{
				throw new ArgumentNullException("httpMethod");
			}
			if (string.IsNullOrEmpty(parameters.SignatureMethod))
			{
				throw new ArgumentNullException("signatureMethod");
			}
			string text = null;
			string text2 = null;
			SortedDictionary<string, string> queryParameters = GetQueryParameters(url.Query, parameters.BaseProperties);
			if (!queryParameters.ContainsKey(OAuthVersionKey))
			{
				queryParameters.Add(OAuthVersionKey, OAuthVersion);
			}
			text = $"{url.Scheme}://{url.Host}";
			if ((!(url.Scheme == "http") || url.Port != 80) && (!(url.Scheme == "https") || url.Port != 443))
			{
				text = text + ":" + url.Port;
			}
			text += url.AbsolutePath;
			text2 = NormalizeRequestParameters(queryParameters);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "{0}&", new object[1] { httpMethod.ToUpper() });
			stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "{0}&", new object[1] { EncodingPerRFC3986(text) });
			stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "{0}", new object[1] { EncodingPerRFC3986(text2) });
			return stringBuilder.ToString();
		}

		public static string GenerateSignatureUsingHash(string signatureBase, HashAlgorithm hash)
		{
			return smethod_0(hash, signatureBase);
		}

		public static string GenerateSignature(Uri url, string consumerKey, string consumerSecret, string token, string tokenSecret, string httpMethod, string timeStamp, string nonce)
		{
			return GenerateSignature(url, consumerKey, consumerSecret, token, tokenSecret, httpMethod, timeStamp, nonce, "HMAC-SHA1");
		}

		public static string GenerateSignature(Uri url, string consumerKey, string consumerSecret, string token, string tokenSecret, string httpMethod, string timeStamp, string nonce, string signatureMethod)
		{
			OAuthParameters oAuthParameters = new OAuthParameters();
			oAuthParameters.ConsumerKey = consumerKey;
			oAuthParameters.ConsumerSecret = consumerSecret;
			oAuthParameters.Token = token;
			oAuthParameters.TokenSecret = tokenSecret;
			oAuthParameters.Timestamp = timeStamp;
			oAuthParameters.Nonce = nonce;
			oAuthParameters.SignatureMethod = signatureMethod;
			OAuthParameters parameters = oAuthParameters;
			return GenerateSignature(url, httpMethod, parameters);
		}

		public static string GenerateSignature(Uri url, string httpMethod, OAuthParameters parameters)
		{
			switch (parameters.SignatureMethod)
			{
			case "RSA-SHA1":
				throw new NotImplementedException();
			case "HMAC-SHA1":
			{
				string signatureBase = GenerateSignatureBase(url, httpMethod, parameters);
				HMACSHA1 hMACSHA = new HMACSHA1();
				hMACSHA.Key = Encoding.ASCII.GetBytes(GenerateOAuthSignature(parameters.ConsumerSecret, parameters.TokenSecret));
				return GenerateSignatureUsingHash(signatureBase, hMACSHA);
			}
			default:
				throw new ArgumentException("Unknown signature type", "signatureType");
			case "PLAINTEXT":
				return HttpUtility.UrlEncode($"{parameters.ConsumerKey}&{parameters.TokenSecret}");
			}
		}

		public static string GenerateOAuthSignatureEncoded(string consumerSecret, string tokenSecret)
		{
			return EncodingPerRFC3986(GenerateOAuthSignature(consumerSecret, tokenSecret));
		}

		public static string GenerateOAuthSignature(string consumerSecret, string tokenSecret)
		{
			return string.Format("{0}&{1}", EncodingPerRFC3986(consumerSecret), string.IsNullOrEmpty(tokenSecret) ? "" : EncodingPerRFC3986(tokenSecret));
		}

		public static string GenerateTimeStamp()
		{
			string text = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalSeconds.ToString(CultureInfo.InvariantCulture);
			int num = text.IndexOf(".");
			if (num != -1)
			{
				text = text.Substring(0, num);
			}
			return text;
		}

		public static string GenerateNonce()
		{
			return Guid.NewGuid().ToString().ToLower()
				.Replace("-", "");
		}

		public static string GetExchangeAccessCodeRequestBody(OAuth2Parameters parameters)
		{
			if (string.IsNullOrEmpty(parameters.AccessCode))
			{
				throw new ArgumentNullException("access_code");
			}
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("{0}={1}", OAuth2GrantType, "authorization_code");
			stringBuilder.AppendFormat("&{0}={1}", OAuth2ClientId, EncodingPerRFC3986(parameters.ClientId));
			stringBuilder.AppendFormat("&{0}={1}", OAuth2ClientSecret, EncodingPerRFC3986(parameters.ClientSecret));
			stringBuilder.AppendFormat("&{0}={1}", OAuth2AccessCode, EncodingPerRFC3986(parameters.AccessCode));
			stringBuilder.AppendFormat("&{0}={1}", OAuth2RedirectUri, EncodingPerRFC3986(parameters.RedirectUri));
			return stringBuilder.ToString();
		}

		public static string GetRefreshAccessTokenRequestBody(OAuth2Parameters parameters)
		{
			if (string.IsNullOrEmpty(parameters.RefreshToken))
			{
				throw new ArgumentNullException("refresh_token");
			}
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("{0}={1}", OAuth2GrantType, "refresh_token");
			stringBuilder.AppendFormat("&{0}={1}", OAuth2ClientId, EncodingPerRFC3986(parameters.ClientId));
			stringBuilder.AppendFormat("&{0}={1}", OAuth2ClientSecret, EncodingPerRFC3986(parameters.ClientSecret));
			stringBuilder.AppendFormat("&{0}={1}", OAuth2RefreshToken, EncodingPerRFC3986(parameters.RefreshToken));
			return stringBuilder.ToString();
		}

		public static void GetOAuth2AccessToken(OAuth2Parameters parameters, string requestBody)
		{
			Uri requestUri = new Uri(parameters.TokenUri);
			WebRequest webRequest = WebRequest.Create(requestUri);
			webRequest.Method = "POST";
			webRequest.ContentType = "application/x-www-form-urlencoded";
			Stream requestStream = webRequest.GetRequestStream();
			StreamWriter streamWriter = new StreamWriter(requestStream);
			streamWriter.Write(requestBody);
			streamWriter.Flush();
			streamWriter.Close();
			WebResponse response = webRequest.GetResponse();
			string text = "";
			if (response != null)
			{
				Stream responseStream = response.GetResponseStream();
				StreamReader streamReader = new StreamReader(responseStream);
				text = streamReader.ReadToEnd();
				Dictionary<string, string> dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(text);
				if (dictionary.ContainsKey(OAuth2AccessToken))
				{
					parameters.AccessToken = dictionary[OAuth2AccessToken];
				}
				if (dictionary.ContainsKey(OAuth2RefreshToken))
				{
					parameters.RefreshToken = dictionary[OAuth2RefreshToken];
				}
				if (dictionary.ContainsKey(OAuth2TokenType))
				{
					parameters.TokenType = dictionary[OAuth2TokenType];
				}
				if (dictionary.ContainsKey(OAuth2ExpiresIn))
				{
					parameters.TokenExpiry = DateTime.Now.AddSeconds(int.Parse(dictionary[OAuth2ExpiresIn]));
				}
			}
		}
	}
}
