using System;

namespace Google.GData.Client
{
	public interface IGDataRequestFactory
	{
		bool UseGZip { get; set; }

		bool UseSSL { get; set; }

		IGDataRequest CreateRequest(GDataRequestType type, Uri uriTarget);
	}
}
