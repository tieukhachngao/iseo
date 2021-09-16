using System.Net;

namespace Google.GData.Client
{
	public class GDataCredentials
	{
		private string string_0;

		private string string_1;

		private string string_2;

		private string string_3;

		private string string_4;

		private string string_5 = "HOSTED_OR_GOOGLE";

		public string Username
		{
			get
			{
				return string_1;
			}
			set
			{
				string_1 = value;
			}
		}

		public string AccountType
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

		public string CaptchaToken
		{
			get
			{
				return string_4;
			}
			set
			{
				string_4 = value;
			}
		}

		public string CaptchaAnswer
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

		public string Password
		{
			set
			{
				string_0 = value;
			}
		}

		public string ClientToken
		{
			get
			{
				return string_2;
			}
			set
			{
				string_2 = value;
			}
		}

		public ICredentials NetworkCredential => new NetworkCredential(string_1, string_0);

		public GDataCredentials(string username, string password)
		{
			string_1 = username;
			string_0 = password;
		}

		public GDataCredentials(string clientToken)
		{
			string_2 = clientToken;
		}

		internal string method_0()
		{
			return string_0;
		}
	}
}
