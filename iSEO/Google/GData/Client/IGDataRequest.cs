using System;
using System.IO;

namespace Google.GData.Client
{
	public interface IGDataRequest
	{
		GDataCredentials Credentials { get; set; }

		bool UseGZip { get; set; }

		DateTime IfModifiedSince { get; set; }

		Stream GetRequestStream();

		void Execute();

		Stream GetResponseStream();
	}
}
