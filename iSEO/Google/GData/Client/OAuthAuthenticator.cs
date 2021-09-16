namespace Google.GData.Client
{
	public abstract class OAuthAuthenticator : Authenticator
	{
		private string string_2;

		private string string_3;

		public string ConsumerKey => string_2;

		public string ConsumerSecret => string_3;

		public OAuthAuthenticator(string applicationName, string consumerKey, string consumerSecret)
			: base(applicationName)
		{
			string_2 = consumerKey;
			string_3 = consumerSecret;
		}
	}
}
