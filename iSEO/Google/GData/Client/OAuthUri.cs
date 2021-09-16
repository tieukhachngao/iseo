using System;

namespace Google.GData.Client
{
	[Obsolete("this is going to be removed in the future and replaced with OAuthAuthenticator")]
	public class OAuthUri : Uri
	{
		public static string OAuthParameter = "xoauth_requestor_id";

		public OAuthUri(string uriString, string userName, string domain)
			: base(uriString + "?" + OAuthParameter + "=" + userName + "%40" + domain)
		{
		}
	}
}
