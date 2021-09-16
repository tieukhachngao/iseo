using System;
using System.Net;

namespace Google.GData.Client
{
	public class GOAuth2Request : GDataGAuthRequest
	{
		private GOAuth2RequestFactory goauth2RequestFactory_0;

		internal GOAuth2Request(GDataRequestType A_0, Uri A_1, GOAuth2RequestFactory A_2)
			: base(A_0, A_1, A_2)
		{
			goauth2RequestFactory_0 = A_2;
		}

		protected override void EnsureCredentials()
		{
			_ = base.Request;
			if (string.IsNullOrEmpty(goauth2RequestFactory_0.Parameters.AccessToken))
			{
				throw new GDataRequestException("An access token must be provided to use GOAuthRequestFactory");
			}
			base.Request.Headers.Remove("Authorization");
			base.Request.Headers.Add("Authorization", $"{goauth2RequestFactory_0.Parameters.TokenType} {goauth2RequestFactory_0.Parameters.AccessToken}");
		}

		public override void Execute()
		{
			try
			{
				base.Execute();
			}
			catch (GDataRequestException ex)
			{
				HttpWebResponse httpWebResponse = ex.Response as HttpWebResponse;
				if (httpWebResponse != null && httpWebResponse.StatusCode == HttpStatusCode.Unauthorized)
				{
					Reset();
					try
					{
						OAuthUtil.RefreshAccessToken(goauth2RequestFactory_0.Parameters);
					}
					catch (WebException)
					{
						throw ex;
					}
					base.Execute();
					return;
				}
				throw;
			}
		}
	}
}
