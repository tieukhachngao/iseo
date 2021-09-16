using System;
using System.Net;

namespace Google.GData.Client
{
	public class ClientLoginAuthenticator : Authenticator
	{
		private GDataCredentials gdataCredentials_0;

		private Uri uri_0;

		private string string_2;

		public GDataCredentials Credentials => gdataCredentials_0;

		public string Service => string_2;

		public Uri LoginHandler => uri_0;

		public ClientLoginAuthenticator(string applicationName, string serviceName, string username, string password)
			: this(applicationName, serviceName, new GDataCredentials(username, password))
		{
		}

		public ClientLoginAuthenticator(string applicationName, string serviceName, GDataCredentials credentials)
			: this(applicationName, serviceName, credentials, null)
		{
		}

		public ClientLoginAuthenticator(string applicationName, string serviceName, GDataCredentials credentials, Uri clientLoginHandler)
			: base(applicationName)
		{
			gdataCredentials_0 = credentials;
			string_2 = serviceName;
			uri_0 = ((clientLoginHandler == null) ? new Uri("https://www.google.com/accounts/ClientLogin") : clientLoginHandler);
		}

		public override void ApplyAuthenticationToRequest(HttpWebRequest request)
		{
			base.ApplyAuthenticationToRequest(request);
			method_0(request);
			if (!string.IsNullOrEmpty(Credentials.ClientToken))
			{
				string header = "Authorization: GoogleLogin auth=" + Credentials.ClientToken;
				request.Headers.Add(header);
			}
		}

		private void method_0(HttpWebRequest A_0)
		{
			if (string.IsNullOrEmpty(Credentials.ClientToken))
			{
				Credentials.ClientToken = Utilities.QueryClientLoginToken(Credentials, Service, base.Application, fUseKeepAlive: false, LoginHandler);
			}
		}
	}
}
