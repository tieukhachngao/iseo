using System;
using System.Runtime.CompilerServices;

namespace Google.GData.Client
{
	public class GOAuth2RequestFactory : GDataGAuthRequestFactory
	{
		public const string GDataGAuthSubAgent = "GOAuth2RequestFactory-CS/1.0.0";

		[CompilerGenerated]
		private OAuth2Parameters oauth2Parameters_0;

		public OAuth2Parameters Parameters
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

		public GOAuth2RequestFactory(string service, string applicationName, OAuth2Parameters parameters)
			: base(service, applicationName)
		{
			Parameters = parameters;
		}

		public override IGDataRequest CreateRequest(GDataRequestType type, Uri uriTarget)
		{
			return new GOAuth2Request(type, uriTarget, this);
		}
	}
}
