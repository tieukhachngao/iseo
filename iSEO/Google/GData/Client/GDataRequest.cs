using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Net;

namespace Google.GData.Client
{
	public class GDataRequest : IGDataRequest, ISupportsEtag, IDisposable
	{
		private WebRequest webRequest_0;

		private WebResponse webResponse_0;

		private Uri uri_0;

		private GDataRequestType gdataRequestType_0;

		private GDataCredentials gdataCredentials_0;

		private Stream stream_0;

		private GDataRequestFactory gdataRequestFactory_0;

		protected bool disposed;

		private bool bool_0;

		private DateTime dateTime_0 = DateTime.MinValue;

		private Stream stream_1;

		private string string_0;

		private string string_1;

		private long long_0;

		private string string_2;

		protected Uri TargetUri
		{
			get
			{
				return uri_0;
			}
			set
			{
				uri_0 = value;
			}
		}

		public bool UseGZip
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

		public DateTime IfModifiedSince
		{
			get
			{
				return dateTime_0;
			}
			set
			{
				dateTime_0 = value;
			}
		}

		public GDataCredentials Credentials
		{
			get
			{
				return gdataCredentials_0;
			}
			set
			{
				gdataCredentials_0 = value;
			}
		}

		public string ContentType
		{
			get
			{
				if (string_0 != null)
				{
					return string_0;
				}
				return gdataRequestFactory_0.ContentType;
			}
			set
			{
				string_0 = value;
			}
		}

		public string Etag
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

		public string Slug
		{
			get
			{
				if (string_1 != null)
				{
					return string_1;
				}
				return gdataRequestFactory_0.Slug;
			}
			set
			{
				string_1 = Utilities.EncodeSlugHeader(value);
			}
		}

		public long ContentLength => long_0;

		protected WebRequest Request
		{
			get
			{
				return webRequest_0;
			}
			set
			{
				webRequest_0 = value;
			}
		}

		protected WebResponse Response
		{
			get
			{
				return webResponse_0;
			}
			set
			{
				webResponse_0 = value;
			}
		}

		internal GDataRequest(GDataRequestType A_0, Uri A_1, GDataRequestFactory A_2)
		{
			gdataRequestType_0 = A_0;
			uri_0 = A_1;
			gdataRequestFactory_0 = A_2;
			bool_0 = gdataRequestFactory_0.UseGZip;
		}

		public void Dispose()
		{
			if (stream_1 != null)
			{
				stream_1.Close();
			}
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!disposed && disposing)
			{
				Reset();
				disposed = true;
			}
		}

		protected virtual void Reset()
		{
			stream_0 = null;
			webRequest_0 = null;
			if (webResponse_0 != null)
			{
				webResponse_0.Close();
			}
			webResponse_0 = null;
		}

		public virtual Stream GetRequestStream()
		{
			EnsureWebRequest();
			stream_0 = webRequest_0.GetRequestStream();
			return stream_0;
		}

		protected virtual void EnsureWebRequest()
		{
			if (webRequest_0 != null || !(uri_0 != null))
			{
				return;
			}
			if (gdataRequestFactory_0.UseSSL && !uri_0.Scheme.ToLower().Equals("https"))
			{
				uri_0 = new Uri("https://" + uri_0.Host + uri_0.PathAndQuery);
			}
			webRequest_0 = WebRequest.Create(uri_0);
			webResponse_0 = null;
			if (webRequest_0 == null)
			{
				throw new OutOfMemoryException("Could not create a new Webrequest");
			}
			HttpWebRequest httpWebRequest = webRequest_0 as HttpWebRequest;
			if (httpWebRequest != null)
			{
				switch (gdataRequestType_0)
				{
				case GDataRequestType.Query:
					httpWebRequest.Method = "GET";
					break;
				case GDataRequestType.Update:
					httpWebRequest.Method = "PUT";
					break;
				case GDataRequestType.Delete:
					httpWebRequest.Method = "DELETE";
					break;
				case GDataRequestType.Insert:
				case GDataRequestType.Batch:
					httpWebRequest.Method = "POST";
					break;
				}
				if (bool_0)
				{
					httpWebRequest.Headers.Set("Accept-Encoding", "gzip");
				}
				if (Etag != null)
				{
					if (Etag != "*")
					{
						httpWebRequest.Headers.Set("Etag", Etag);
					}
					switch (gdataRequestType_0)
					{
					case GDataRequestType.Query:
						httpWebRequest.Headers.Set("If-None-Match", Etag);
						break;
					case GDataRequestType.Update:
					case GDataRequestType.Delete:
						if (!Utilities.IsWeakETag(this))
						{
							httpWebRequest.Headers.Set("If-Match", Etag);
						}
						break;
					}
				}
				if (IfModifiedSince != DateTime.MinValue)
				{
					httpWebRequest.IfModifiedSince = IfModifiedSince;
				}
				httpWebRequest.ContentType = ContentType;
				httpWebRequest.UserAgent = gdataRequestFactory_0.UserAgent;
				httpWebRequest.KeepAlive = gdataRequestFactory_0.KeepAlive;
				httpWebRequest.CookieContainer = gdataRequestFactory_0.Cookies;
				if (gdataRequestFactory_0.hasCustomHeaders)
				{
					foreach (string customHeader in gdataRequestFactory_0.CustomHeaders)
					{
						Request.Headers.Add(customHeader);
					}
				}
				if (gdataRequestFactory_0.Timeout != -1)
				{
					httpWebRequest.Timeout = gdataRequestFactory_0.Timeout;
				}
				if (Slug != null)
				{
					Request.Headers.Set("Slug", Slug);
				}
				if (gdataRequestFactory_0.Proxy != null)
				{
					Request.Proxy = gdataRequestFactory_0.Proxy;
				}
			}
			EnsureCredentials();
		}

		protected virtual void EnsureCredentials()
		{
			if (Credentials != null)
			{
				webRequest_0.Credentials = Credentials.NetworkCredential;
			}
		}

		protected virtual void LogRequest(WebRequest request)
		{
		}

		protected virtual void LogResponse(WebResponse response)
		{
		}

		public virtual void Execute()
		{
			try
			{
				EnsureWebRequest();
				if (stream_0 != null)
				{
					stream_0.Close();
				}
				LogRequest(webRequest_0);
				webResponse_0 = webRequest_0.GetResponse();
			}
			catch (WebException exception)
			{
				GDataRequestException ex = new GDataRequestException("Execution of request failed: " + uri_0.ToString(), exception);
				throw ex;
			}
			if (webResponse_0 != null)
			{
				stream_1 = webResponse_0.GetResponseStream();
			}
			LogResponse(webResponse_0);
			if (webResponse_0 is HttpWebResponse)
			{
				HttpWebResponse httpWebResponse = webResponse_0 as HttpWebResponse;
				bool_0 = string.Compare(httpWebResponse.ContentEncoding, "gzip", ignoreCase: true, CultureInfo.InvariantCulture) == 0;
				if (bool_0)
				{
					stream_1 = new GZipStream(stream_1, CompressionMode.Decompress);
				}
				int statusCode = (int)httpWebResponse.StatusCode;
				if (httpWebResponse.StatusCode == HttpStatusCode.Forbidden)
				{
					throw new GDataForbiddenException("Execution of request returned HttpStatusCode.Forbidden: " + uri_0.ToString() + httpWebResponse.StatusCode, webResponse_0);
				}
				if (httpWebResponse.StatusCode == HttpStatusCode.Conflict)
				{
					throw new GDataVersionConflictException("Execution of request returned HttpStatusCode.Conflict: " + uri_0.ToString() + httpWebResponse.StatusCode, webResponse_0);
				}
				if ((IfModifiedSince != DateTime.MinValue || Etag != null) && httpWebResponse.StatusCode == HttpStatusCode.NotModified)
				{
					throw new GDataNotModifiedException("Content not modified: " + uri_0.ToString(), webResponse_0);
				}
				if (httpWebResponse.StatusCode == HttpStatusCode.Found || httpWebResponse.StatusCode == HttpStatusCode.Found || httpWebResponse.StatusCode == HttpStatusCode.TemporaryRedirect)
				{
					throw new GDataRedirectException("Execution resulted in a redirect from " + uri_0.ToString(), webResponse_0);
				}
				if (statusCode > 299)
				{
					throw new GDataRequestException("Execution of request returned unexpected result: " + uri_0.ToString() + httpWebResponse.StatusCode, webResponse_0);
				}
				long_0 = httpWebResponse.ContentLength;
				string_2 = httpWebResponse.Headers["Etag"];
				httpWebResponse = null;
			}
		}

		public virtual Stream GetResponseStream()
		{
			return stream_1;
		}

		public HttpWebRequest GetFinalizedRequest()
		{
			EnsureWebRequest();
			EnsureCredentials();
			return Request as HttpWebRequest;
		}
	}
}
