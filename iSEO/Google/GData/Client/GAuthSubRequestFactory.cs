using System;
using System.Security.Cryptography;

namespace Google.GData.Client
{
	public class GAuthSubRequestFactory : GDataGAuthRequestFactory
	{
		private AsymmetricAlgorithm asymmetricAlgorithm_0;

		public string Token
		{
			get
			{
				return base.GAuthToken;
			}
			set
			{
				base.GAuthToken = value;
			}
		}

		public AsymmetricAlgorithm PrivateKey
		{
			get
			{
				return asymmetricAlgorithm_0;
			}
			set
			{
				asymmetricAlgorithm_0 = value;
			}
		}

		public GAuthSubRequestFactory(string service, string applicationName)
			: base(service, applicationName)
		{
		}

		public override IGDataRequest CreateRequest(GDataRequestType type, Uri uriTarget)
		{
			return new GAuthSubRequest(type, uriTarget, this);
		}
	}
}
