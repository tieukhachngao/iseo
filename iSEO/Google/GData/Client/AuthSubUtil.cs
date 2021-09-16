using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace Google.GData.Client
{
	public sealed class AuthSubUtil
	{
		private static string string_0 = "https";

		private static string string_1 = "www.google.com";

		private static string string_2 = "/accounts/AuthSubRequest";

		private AuthSubUtil()
		{
		}

		public static string getRequestUrl(string continueUrl, string scope, bool secure, bool session)
		{
			return getRequestUrl(string_0, string_1, continueUrl, scope, secure, session);
		}

		public static string getRequestUrl(string hostedDomain, string continueUrl, string scope, bool secure, bool session)
		{
			return getRequestUrl(hostedDomain, string_0, string_1, string_2, continueUrl, scope, secure, session);
		}

		public static string getRequestUrl(string protocol, string authenticationDomain, string continueUrl, string scope, bool secure, bool session)
		{
			return getRequestUrl(null, protocol, authenticationDomain, string_2, continueUrl, scope, secure, session);
		}

		public static string getRequestUrl(string protocol, string authenticationDomain, string handler, string continueUrl, string scope, bool secure, bool session)
		{
			return getRequestUrl(null, protocol, authenticationDomain, handler, continueUrl, scope, secure, session);
		}

		public static string getRequestUrl(string hostedDomain, string protocol, string authenticationDomain, string handler, string continueUrl, string scope, bool secure, bool session)
		{
			StringBuilder stringBuilder = new StringBuilder(protocol);
			stringBuilder.Append("://");
			stringBuilder.Append(authenticationDomain);
			stringBuilder.Append(handler);
			stringBuilder.Append("?");
			smethod_0(stringBuilder, "next", continueUrl);
			stringBuilder.Append("&");
			smethod_0(stringBuilder, "scope", scope);
			stringBuilder.Append("&");
			smethod_0(stringBuilder, "secure", secure ? "1" : "0");
			stringBuilder.Append("&");
			smethod_0(stringBuilder, "session", session ? "1" : "0");
			if (hostedDomain != null)
			{
				stringBuilder.Append("&");
				smethod_0(stringBuilder, "hd", hostedDomain);
			}
			return stringBuilder.ToString();
		}

		private static void smethod_0(StringBuilder A_0, string A_1, string A_2)
		{
			A_1 = Utilities.UriEncodeReserved(A_1);
			A_2 = Utilities.UriEncodeReserved(A_2);
			A_0.Append(A_1);
			A_0.Append('=');
			A_0.Append(A_2);
		}

		public static string getSessionTokenUrl()
		{
			return getSessionTokenUrl(string_0, string_1);
		}

		public static string getSessionTokenUrl(string protocol, string domain)
		{
			return protocol + "://" + domain + "/accounts/AuthSubSessionToken";
		}

		public static string getRevokeTokenUrl()
		{
			return getRevokeTokenUrl(string_0, string_1);
		}

		public static string getRevokeTokenUrl(string protocol, string domain)
		{
			return protocol + "://" + domain + "/accounts/AuthSubRevokeToken";
		}

		public static string getTokenFromReply(Uri uri)
		{
			if (uri == null)
			{
				throw new ArgumentNullException("uri");
			}
			char[] delimiters = new char[2] { '?', '&' };
			TokenCollection tokenCollection = new TokenCollection(uri.Query, delimiters);
			foreach (string item in tokenCollection)
			{
				if (item.Length > 0)
				{
					char[] separator = new char[1] { '=' };
					string[] array = item.Split(separator, 2);
					if (array[0] == "token")
					{
						return array[1];
					}
				}
			}
			return null;
		}

		public static string exchangeForSessionToken(string onetimeUseToken, AsymmetricAlgorithm key)
		{
			return exchangeForSessionToken(string_0, string_1, onetimeUseToken, key);
		}

		public static string exchangeForSessionToken(string protocol, string domain, string onetimeUseToken, AsymmetricAlgorithm key)
		{
			HttpWebResponse httpWebResponse = null;
			string result = null;
			try
			{
				string sessionTokenUrl = getSessionTokenUrl(protocol, domain);
				Uri requestUri = new Uri(sessionTokenUrl);
				HttpWebRequest httpWebRequest = WebRequest.Create(requestUri) as HttpWebRequest;
				string header = formAuthorizationHeader(onetimeUseToken, key, requestUri, "GET");
				httpWebRequest.Headers.Add(header);
				httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse;
			}
			catch (WebException exception)
			{
				throw new GDataRequestException("Execution of exchangeForSessionToken", exception);
			}
			if (httpWebResponse != null)
			{
				int statusCode = (int)httpWebResponse.StatusCode;
				if (statusCode != 200)
				{
					throw new GDataRequestException("Execution of exchangeForSessionToken request returned unexpected result: " + statusCode, httpWebResponse);
				}
				result = Utilities.ParseValueFormStream(httpWebResponse.GetResponseStream(), "Token");
			}
			return result;
		}

		public static void revokeToken(string token, AsymmetricAlgorithm key)
		{
			revokeToken(string_0, string_1, token, key);
		}

		public static void revokeToken(string protocol, string domain, string token, AsymmetricAlgorithm key)
		{
			HttpWebResponse httpWebResponse = null;
			try
			{
				string revokeTokenUrl = getRevokeTokenUrl(protocol, domain);
				Uri requestUri = new Uri(revokeTokenUrl);
				HttpWebRequest httpWebRequest = WebRequest.Create(requestUri) as HttpWebRequest;
				string header = formAuthorizationHeader(token, key, requestUri, "GET");
				httpWebRequest.Headers.Add(header);
				httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse;
			}
			catch (WebException exception)
			{
				throw new GDataRequestException("Execution of revokeToken", exception);
			}
			if (httpWebResponse != null)
			{
				int statusCode = (int)httpWebResponse.StatusCode;
				if (statusCode != 200)
				{
					throw new GDataRequestException("Execution of revokeToken request returned unexpected result: " + statusCode, httpWebResponse);
				}
			}
		}

		public static string formAuthorizationHeader(string token, AsymmetricAlgorithm key, Uri requestUri, string requestMethod)
		{
			if (key == null)
			{
				return string.Format(CultureInfo.InvariantCulture, "Authorization: AuthSub token=\"{0}\"", new object[1] { token });
			}
			if (requestUri == null)
			{
				throw new ArgumentNullException("requestUri");
			}
			int num = (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;
			string text = smethod_1();
			string text2 = string.Format(CultureInfo.InvariantCulture, "{0} {1} {2} {3}", requestMethod, requestUri.AbsoluteUri, num.ToString(CultureInfo.InvariantCulture), text);
			byte[] inArray = smethod_2(text2, key);
			string text3 = Convert.ToBase64String(inArray);
			string text4 = ((key is DSACryptoServiceProvider) ? "dsa-sha1" : "rsa-sha1");
			return string.Format(CultureInfo.InvariantCulture, "Authorization: AuthSub token=\"{0}\" data=\"{1}\" sig=\"{2}\" sigalg=\"{3}\"", token, text2, text3, text4);
		}

		public static Dictionary<string, string> GetTokenInfo(string token, AsymmetricAlgorithm key)
		{
			return GetTokenInfo(string_0, string_1, token, key);
		}

		public static Dictionary<string, string> GetTokenInfo(string protocol, string domain, string token, AsymmetricAlgorithm key)
		{
			HttpWebResponse httpWebResponse;
			try
			{
				string uriString = smethod_3(protocol, domain);
				Uri requestUri = new Uri(uriString);
				HttpWebRequest httpWebRequest = WebRequest.Create(requestUri) as HttpWebRequest;
				string header = formAuthorizationHeader(token, key, requestUri, "GET");
				httpWebRequest.Headers.Add(header);
				httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse;
			}
			catch (WebException exception)
			{
				throw new GDataRequestException("Execution of GetTokenInfo", exception);
			}
			if (httpWebResponse != null)
			{
				int statusCode = (int)httpWebResponse.StatusCode;
				if (statusCode != 200)
				{
					throw new GDataRequestException("Execution of revokeToken request returned unexpected result: " + statusCode, httpWebResponse);
				}
				TokenCollection tokenCollection = Utilities.ParseStreamInTokenCollection(httpWebResponse.GetResponseStream());
				if (tokenCollection != null)
				{
					return tokenCollection.CreateDictionary();
				}
			}
			return null;
		}

		private static string smethod_1()
		{
			byte[] array = new byte[20];
			RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
			rNGCryptoServiceProvider.GetBytes(array);
			StringBuilder stringBuilder = new StringBuilder(20);
			for (int i = 0; i < 20; i++)
			{
				if (array[i] != 0 || stringBuilder.Length != 0)
				{
					stringBuilder.Append(Convert.ToInt16(array[i], CultureInfo.InvariantCulture).ToString()[0]);
				}
			}
			return stringBuilder.ToString();
		}

		private static byte[] smethod_2(string A_0, AsymmetricAlgorithm A_1)
		{
			byte[] bytes = new ASCIIEncoding().GetBytes(A_0);
			try
			{
				RSACryptoServiceProvider rSACryptoServiceProvider = A_1 as RSACryptoServiceProvider;
				if (rSACryptoServiceProvider != null)
				{
					return rSACryptoServiceProvider.SignData(bytes, new SHA1CryptoServiceProvider());
				}
				DSACryptoServiceProvider dSACryptoServiceProvider = A_1 as DSACryptoServiceProvider;
				if (dSACryptoServiceProvider != null)
				{
					return dSACryptoServiceProvider.SignData(bytes);
				}
			}
			catch (CryptographicException)
			{
			}
			return null;
		}

		private static string smethod_3(string A_0, string A_1)
		{
			return A_0 + "://" + A_1 + "/accounts/AuthSubTokenInfo";
		}
	}
}
