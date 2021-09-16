using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Google.GData.Client
{
	public class RequestSettings
	{
		public enum AuthenticationType
		{
			none,
			clientLogin,
			authSub,
			oAuth,
			oAuth2
		}

		private AuthenticationType authenticationType_0;

		private string string_0;

		private GDataCredentials gdataCredentials_0;

		private string string_1;

		private int int_0 = -1;

		private int int_1 = -1;

		private bool bool_0;

		private int int_2 = -1;

		private string string_2;

		private string string_3;

		private string string_4;

		private string string_5;

		private string string_6;

		private string string_7;

		private AsymmetricAlgorithm asymmetricAlgorithm_0;

		private Uri uri_0;

		private bool bool_1;

		[CompilerGenerated]
		private OAuth2Parameters oauth2Parameters_0;

		public GDataCredentials Credentials => gdataCredentials_0;

		public string AuthSubToken => string_1;

		public AsymmetricAlgorithm PrivateKey => asymmetricAlgorithm_0;

		public string Application => string_0;

		public string ConsumerKey => string_2;

		public string ConsumerSecret => string_3;

		public string Token => string_6;

		public string TokenSecret => string_7;

		public string OAuthUser => string_4;

		public string OAuthDomain => string_5;

		public int PageSize
		{
			get
			{
				return int_0;
			}
			set
			{
				int_0 = value;
			}
		}

		public bool AutoPaging
		{
			get
			{
				return bool_0;
			}
			set
			{
				bool_0 = value;
			}
		}

		public int Maximum
		{
			get
			{
				return int_1;
			}
			set
			{
				if (value < PageSize)
				{
					throw new ArgumentException("Maximum must be greater or equal to PageSize");
				}
				int_1 = value;
			}
		}

		public int Timeout
		{
			get
			{
				return int_2;
			}
			set
			{
				int_2 = value;
			}
		}

		public bool UseSSL
		{
			get
			{
				return bool_1;
			}
			set
			{
				bool_1 = value;
			}
		}

		public Uri ClientLoginHandler
		{
			get
			{
				if (!(uri_0 != null))
				{
					return new Uri("https://www.google.com/accounts/ClientLogin");
				}
				return uri_0;
			}
			set
			{
				uri_0 = value;
			}
		}

		public OAuth2Parameters OAuth2Parameters
		{
			[CompilerGenerated]
			get
			{
				return oauth2Parameters_0;
			}
			[CompilerGenerated]
			set
			{
				oauth2Parameters_0 = value;
			}
		}

		public RequestSettings(string applicationName)
		{
			string_0 = applicationName;
		}

		public RequestSettings(string applicationName, string username, string password)
			: this(applicationName, new GDataCredentials(username, password))
		{
		}

		public RequestSettings(string applicationName, string consumerKey, string consumerSecret, string user, string domain)
			: this(applicationName)
		{
			authenticationType_0 = AuthenticationType.oAuth;
			string_2 = consumerKey;
			string_3 = consumerSecret;
			string_4 = user;
			string_5 = domain;
		}

		public RequestSettings(string applicationName, string consumerKey, string consumerSecret, string token, string tokenSecret, string user, string domain)
			: this(applicationName, consumerKey, consumerSecret, user, domain)
		{
			string_6 = token;
			string_7 = tokenSecret;
		}

		public RequestSettings(string applicationName, GDataCredentials credentials)
		{
			authenticationType_0 = AuthenticationType.clientLogin;
			string_0 = applicationName;
			gdataCredentials_0 = credentials;
		}

		public RequestSettings(string applicationName, string authSubToken)
			: this(applicationName)
		{
			authenticationType_0 = AuthenticationType.authSub;
			string_1 = authSubToken;
		}

		public RequestSettings(string applicationName, string authSubToken, AsymmetricAlgorithm privateKey)
			: this(applicationName)
		{
			authenticationType_0 = AuthenticationType.authSub;
			asymmetricAlgorithm_0 = privateKey;
			string_1 = authSubToken;
		}

		public RequestSettings(string applicationName, OAuth2Parameters parameters)
			: this(applicationName)
		{
			authenticationType_0 = AuthenticationType.oAuth2;
			OAuth2Parameters = parameters;
		}

		public HttpWebRequest CreateHttpWebRequest(string serviceName, string httpMethod, Uri targetUri)
		{
			if (UseSSL && !targetUri.Scheme.ToLower().Equals("https"))
			{
				targetUri = new Uri("https://" + targetUri.Host + targetUri.PathAndQuery);
			}
			HttpWebRequest httpWebRequest = WebRequest.Create(targetUri) as HttpWebRequest;
			if (httpWebRequest == null)
			{
				throw new ArgumentException("targetUri does not resolve to an http request");
			}
			if (authenticationType_0 == AuthenticationType.clientLogin)
			{
				method_0(httpWebRequest, serviceName);
			}
			if (authenticationType_0 == AuthenticationType.authSub)
			{
				method_1(httpWebRequest);
			}
			if (authenticationType_0 == AuthenticationType.oAuth)
			{
				method_2(httpWebRequest);
			}
			return httpWebRequest;
		}

		private void method_0(HttpWebRequest A_0, string A_1)
		{
			if (string.IsNullOrEmpty(Credentials.ClientToken))
			{
				Credentials.ClientToken = Utilities.QueryClientLoginToken(Credentials, A_1, Application, fUseKeepAlive: false, ClientLoginHandler);
			}
			if (!string.IsNullOrEmpty(Credentials.ClientToken))
			{
				string header = "Authorization: GoogleLogin auth=" + Credentials.ClientToken;
				A_0.Headers.Add(header);
			}
		}

		private void method_1(HttpWebRequest A_0)
		{
			string header = AuthSubUtil.formAuthorizationHeader(Token, PrivateKey, A_0.RequestUri, A_0.Method);
			A_0.Headers.Add(header);
		}

		private void method_2(HttpWebRequest A_0)
		{
			string header = OAuthUtil.GenerateHeader(A_0.RequestUri, ConsumerKey, ConsumerSecret, Token, TokenSecret, A_0.Method);
			A_0.Headers.Add(header);
		}
	}
}
