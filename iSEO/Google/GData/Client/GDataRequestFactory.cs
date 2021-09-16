using System;
using System.Collections.Generic;
using System.Net;

namespace Google.GData.Client
{
	public class GDataRequestFactory : IGDataRequestFactory
	{
		public const string GDataAgent = "SA";

		public const string DefaultContentType = "application/atom+xml; charset=UTF-8";

		public const string SetCookieHeader = "Set-Cookie";

		public const string CookieHeader = "Cookie";

		public const string SlugHeader = "Slug";

		public const string ContentOverrideHeader = "X-Upload-Content-Type";

		public const string ContentLengthOverrideHeader = "X-Upload-Content-Length";

		public const string EtagHeader = "Etag";

		public const string IfMatch = "If-Match";

		public const string IfNoneMatch = "If-None-Match";

		public const string IfMatchAll = "*";

		private string string_0;

		private List<string> list_0;

		private IWebProxy iwebProxy_0;

		private bool bool_0;

		private bool bool_1;

		private bool bool_2 = true;

		private string string_1 = "application/atom+xml; charset=UTF-8";

		private string string_2;

		private int int_0 = -1;

		private CookieContainer cookieContainer_0;

		public bool UseGZip
		{
			get
			{
				return bool_1;
			}
			set
			{
				bool_1 = value;
			}
		}

		public CookieContainer Cookies
		{
			get
			{
				if (cookieContainer_0 == null)
				{
					cookieContainer_0 = new CookieContainer();
				}
				return cookieContainer_0;
			}
			set
			{
				cookieContainer_0 = value;
			}
		}

		public string ContentType
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

		public string Slug
		{
			get
			{
				return string_2;
			}
			set
			{
				string_2 = Utilities.EncodeSlugHeader(value);
			}
		}

		public virtual string UserAgent
		{
			get
			{
				return string_0;
			}
			set
			{
				string_0 = value;
			}
		}

		public IWebProxy Proxy
		{
			get
			{
				return iwebProxy_0;
			}
			set
			{
				iwebProxy_0 = value;
			}
		}

		public bool KeepAlive
		{
			get
			{
				return bool_0;
			}
			set
			{
				bool_0 = value;
			}
		}

		public bool UseSSL
		{
			get
			{
				return bool_2;
			}
			set
			{
				bool_2 = value;
			}
		}

		public int Timeout
		{
			get
			{
				return int_0;
			}
			set
			{
				int_0 = value;
			}
		}

		internal bool hasCustomHeaders => list_0 != null;

		public List<string> CustomHeaders
		{
			get
			{
				if (list_0 == null)
				{
					list_0 = new List<string>();
				}
				return list_0;
			}
		}

		public GDataRequestFactory(string userAgent)
		{
			string_0 = Utilities.ConstructUserAgent(userAgent, GetType().Name);
			bool_0 = true;
		}

		public virtual IGDataRequest CreateRequest(GDataRequestType type, Uri uriTarget)
		{
			return new GDataRequest(type, uriTarget, this);
		}
	}
}
