using System;
using System.Runtime.CompilerServices;

namespace Google.GData.Client
{
	public class OAuth2Parameters
	{
		public static string GoogleAuthUri = "https://accounts.google.com/o/oauth2/auth";

		public static string GoogleTokenUri = "https://accounts.google.com/o/oauth2/token";

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private string string_1;

		[CompilerGenerated]
		private string string_2;

		[CompilerGenerated]
		private string string_3;

		[CompilerGenerated]
		private string string_4;

		[CompilerGenerated]
		private string string_5;

		[CompilerGenerated]
		private string string_6;

		[CompilerGenerated]
		private string string_7;

		[CompilerGenerated]
		private string string_8;

		[CompilerGenerated]
		private string string_9;

		[CompilerGenerated]
		private string string_10;

		[CompilerGenerated]
		private string string_11;

		[CompilerGenerated]
		private string string_12;

		[CompilerGenerated]
		private string string_13;

		[CompilerGenerated]
		private DateTime dateTime_0;

		public string ClientId
		{
			[CompilerGenerated]
			get
			{
				return string_0;
			}
			[CompilerGenerated]
			set
			{
				string_0 = value;
			}
		}

		public string ClientSecret
		{
			[CompilerGenerated]
			get
			{
				return string_1;
			}
			[CompilerGenerated]
			set
			{
				string_1 = value;
			}
		}

		public string RedirectUri
		{
			[CompilerGenerated]
			get
			{
				return string_2;
			}
			[CompilerGenerated]
			set
			{
				string_2 = value;
			}
		}

		public string AccessType
		{
			[CompilerGenerated]
			get
			{
				return string_3;
			}
			[CompilerGenerated]
			set
			{
				string_3 = value;
			}
		}

		public string ResponseType
		{
			[CompilerGenerated]
			get
			{
				return string_4;
			}
			[CompilerGenerated]
			set
			{
				string_4 = value;
			}
		}

		public string ApprovalPrompt
		{
			[CompilerGenerated]
			get
			{
				return string_5;
			}
			[CompilerGenerated]
			set
			{
				string_5 = value;
			}
		}

		public string State
		{
			[CompilerGenerated]
			get
			{
				return string_6;
			}
			[CompilerGenerated]
			set
			{
				string_6 = value;
			}
		}

		public string Scope
		{
			[CompilerGenerated]
			get
			{
				return string_7;
			}
			[CompilerGenerated]
			set
			{
				string_7 = value;
			}
		}

		public string TokenUri
		{
			[CompilerGenerated]
			get
			{
				return string_8;
			}
			[CompilerGenerated]
			set
			{
				string_8 = value;
			}
		}

		public string AuthUri
		{
			[CompilerGenerated]
			get
			{
				return string_9;
			}
			[CompilerGenerated]
			set
			{
				string_9 = value;
			}
		}

		public string AccessCode
		{
			[CompilerGenerated]
			get
			{
				return string_10;
			}
			[CompilerGenerated]
			set
			{
				string_10 = value;
			}
		}

		public string AccessToken
		{
			[CompilerGenerated]
			get
			{
				return string_11;
			}
			[CompilerGenerated]
			set
			{
				string_11 = value;
			}
		}

		public string TokenType
		{
			[CompilerGenerated]
			get
			{
				return string_12;
			}
			[CompilerGenerated]
			set
			{
				string_12 = value;
			}
		}

		public string RefreshToken
		{
			[CompilerGenerated]
			get
			{
				return string_13;
			}
			[CompilerGenerated]
			set
			{
				string_13 = value;
			}
		}

		public DateTime TokenExpiry
		{
			[CompilerGenerated]
			get
			{
				return dateTime_0;
			}
			[CompilerGenerated]
			set
			{
				dateTime_0 = value;
			}
		}

		public OAuth2Parameters()
		{
			TokenUri = GoogleTokenUri;
			AuthUri = GoogleAuthUri;
			AccessType = "offline";
			ResponseType = "code";
			TokenType = "Bearer";
			ApprovalPrompt = "auto";
		}
	}
}
