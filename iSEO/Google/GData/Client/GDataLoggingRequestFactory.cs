using System;

namespace Google.GData.Client
{
	public class GDataLoggingRequestFactory : GDataGAuthRequestFactory
	{
		private string string_10;

		private string string_11;

		private string string_12;

		public string RequestFileName
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

		public string ResponseFileName
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

		public string CombinedLogFileName
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

		public GDataLoggingRequestFactory(string service, string applicationName)
			: base(service, applicationName)
		{
			string_10 = "GDatarequest.xml";
			string_11 = "GDataresponse.xml";
			string_12 = "GDatatraffic.log";
		}

		public override IGDataRequest CreateRequest(GDataRequestType type, Uri uriTarget)
		{
			return new GDataLoggingRequest(type, uriTarget, this, string_10, string_11, string_12);
		}
	}
}
