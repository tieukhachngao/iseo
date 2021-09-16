using System;

namespace Google.GData.Client
{
	public class GOAuthRequestFactory : GDataGAuthRequestFactory
	{
		public const string GDataGAuthSubAgent = "GOAuthRequestFactory-CS/1.0.0";

		private string string_10;

		private string string_11;

		private string string_12;

		private string string_13;

		public string ConsumerSecret
		{
			get
			{
				return string_12;
			}
			set
			{
				string_12 = value;
			}
		}

		public string ConsumerKey
		{
			get
			{
				return string_13;
			}
			set
			{
				string_13 = value;
			}
		}

		public string TokenSecret
		{
			get
			{
				return string_10;
			}
			set
			{
				string_10 = value;
			}
		}

		public string Token
		{
			get
			{
				return string_11;
			}
			set
			{
				string_11 = value;
			}
		}

		public GOAuthRequestFactory(string service, string applicationName)
			: base(service, applicationName)
		{
		}

		public GOAuthRequestFactory(string service, string applicationName, OAuthParameters parameters)
			: base(service, applicationName)
		{
			if (parameters.ConsumerKey != null)
			{
				ConsumerKey = parameters.ConsumerKey;
			}
			if (parameters.ConsumerSecret != null)
			{
				ConsumerSecret = parameters.ConsumerSecret;
			}
			if (parameters.Token != null)
			{
				Token = parameters.Token;
			}
			if (parameters.TokenSecret != null)
			{
				TokenSecret = parameters.TokenSecret;
			}
		}

		public override IGDataRequest CreateRequest(GDataRequestType type, Uri uriTarget)
		{
			return new GOAuthRequest(type, uriTarget, this);
		}
	}
}
