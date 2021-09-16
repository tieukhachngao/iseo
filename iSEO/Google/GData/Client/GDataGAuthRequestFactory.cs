using System;

namespace Google.GData.Client
{
	public class GDataGAuthRequestFactory : GDataRequestFactory, IVersionAware
	{
		public const string GDataVersion = "GData-Version";

		private const int int_1 = 3;

		private string string_3;

		private string string_4;

		private string string_5;

		private string string_6;

		private bool bool_3;

		private int int_2;

		private bool bool_4;

		private string string_7;

		private string string_8;

		private string string_9;

		private Class59 class59_0 = new Class59();

		public string GAuthToken
		{
			get
			{
				return string_3;
			}
			set
			{
				string_3 = value;
			}
		}

		public override string UserAgent
		{
			get
			{
				return base.UserAgent + (base.UseGZip ? " (gzip)" : "");
			}
			set
			{
				base.UserAgent = value;
			}
		}

		public string ApplicationName
		{
			get
			{
				if (string_6 != null)
				{
					return string_6;
				}
				return "";
			}
			set
			{
				string_6 = value;
			}
		}

		public string Service
		{
			get
			{
				return string_5;
			}
			set
			{
				string_5 = value;
			}
		}

		public bool MethodOverride
		{
			get
			{
				return bool_3;
			}
			set
			{
				bool_3 = value;
			}
		}

		public bool StrictRedirect
		{
			get
			{
				return bool_4;
			}
			set
			{
				bool_4 = value;
			}
		}

		public int NumberOfRetries
		{
			get
			{
				return int_2;
			}
			set
			{
				int_2 = value;
			}
		}

		public string AccountType
		{
			get
			{
				return string_7;
			}
			set
			{
				string_7 = value;
			}
		}

		public string CaptchaAnswer
		{
			get
			{
				return string_8;
			}
			set
			{
				string_8 = value;
			}
		}

		public string CaptchaToken
		{
			get
			{
				return string_9;
			}
			set
			{
				string_9 = value;
			}
		}

		public string Handler
		{
			get
			{
				if (string_4 == null)
				{
					return "https://www.google.com/accounts/ClientLogin";
				}
				return string_4;
			}
			set
			{
				string_4 = value;
			}
		}

		public int ProtocolMajor
		{
			get
			{
				return class59_0.ProtocolMajor;
			}
			set
			{
				class59_0.ProtocolMajor = value;
			}
		}

		public int ProtocolMinor
		{
			get
			{
				return class59_0.ProtocolMinor;
			}
			set
			{
				class59_0.ProtocolMinor = value;
			}
		}

		public GDataGAuthRequestFactory(string service, string applicationName)
			: this(service, applicationName, 3)
		{
		}

		public GDataGAuthRequestFactory(string service, string applicationName, int numberOfRetries)
			: base(applicationName)
		{
			Service = service;
			ApplicationName = applicationName;
			NumberOfRetries = numberOfRetries;
		}

		public override IGDataRequest CreateRequest(GDataRequestType type, Uri uriTarget)
		{
			return new GDataGAuthRequest(type, uriTarget, this);
		}

		public string QueryAuthToken(GDataCredentials gc)
		{
			GDataGAuthRequest gDataGAuthRequest = new GDataGAuthRequest(GDataRequestType.Query, null, this);
			return gDataGAuthRequest.method_0(gc);
		}
	}
}
