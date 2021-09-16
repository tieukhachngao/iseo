using System.Net;
using System.Security.Cryptography;

namespace Google.GData.Client
{
	public class AuthSubAuthenticator : Authenticator
	{
		private string string_2;

		private AsymmetricAlgorithm asymmetricAlgorithm_0;

		public string Token => string_2;

		public AsymmetricAlgorithm PrivateKey => asymmetricAlgorithm_0;

		public AuthSubAuthenticator(string applicationName, string authSubToken)
			: this(applicationName, authSubToken, null)
		{
		}

		public AuthSubAuthenticator(string applicationName, string authSubToken, AsymmetricAlgorithm privateKey)
			: base(applicationName)
		{
			asymmetricAlgorithm_0 = privateKey;
			string_2 = authSubToken;
		}

		public override void ApplyAuthenticationToRequest(HttpWebRequest request)
		{
			base.ApplyAuthenticationToRequest(request);
			string header = AuthSubUtil.formAuthorizationHeader(Token, PrivateKey, request.RequestUri, request.Method);
			request.Headers.Add(header);
		}
	}
}
