using System;
using System.Net;

namespace Google.GData.Client
{
	public class GAuthSubRequest : GDataGAuthRequest
	{
		private GAuthSubRequestFactory gauthSubRequestFactory_0;

		internal GAuthSubRequest(GDataRequestType A_0, Uri A_1, GAuthSubRequestFactory A_2)
			: base(A_0, A_1, A_2)
		{
			gauthSubRequestFactory_0 = A_2;
		}

		protected override void EnsureCredentials()
		{
			HttpWebRequest httpWebRequest = base.Request as HttpWebRequest;
			string header = AuthSubUtil.formAuthorizationHeader(gauthSubRequestFactory_0.Token, gauthSubRequestFactory_0.PrivateKey, httpWebRequest.RequestUri, httpWebRequest.Method);
			base.Request.Headers.Add(header);
		}
	}
}
