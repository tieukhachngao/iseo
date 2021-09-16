using System;
using System.Net;

namespace Google.GData.Client
{
	public abstract class Authenticator
	{
		private string string_0;

		private string string_1;

		private ICreateHttpRequest icreateHttpRequest_0;

		public ICreateHttpRequest RequestFactory
		{
			get
			{
				return icreateHttpRequest_0;
			}
			set
			{
				icreateHttpRequest_0 = value;
			}
		}

		public string Application => string_0;

		public string DeveloperKey
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

		public Authenticator(string applicationName)
		{
			string_0 = applicationName;
			icreateHttpRequest_0 = new HttpRequestFactory();
		}

		public HttpWebRequest CreateHttpWebRequest(string httpMethod, Uri targetUri)
		{
			Uri target = ApplyAuthenticationToUri(targetUri);
			if (icreateHttpRequest_0 != null)
			{
				HttpWebRequest httpWebRequest = icreateHttpRequest_0.Create(target);
				httpWebRequest.AllowAutoRedirect = false;
				httpWebRequest.Method = httpMethod;
				ApplyAuthenticationToRequest(httpWebRequest);
				return httpWebRequest;
			}
			return null;
		}

		public virtual void ApplyAuthenticationToRequest(HttpWebRequest request)
		{
			if (DeveloperKey != null)
			{
				string header = "X-GData-Key: key=" + DeveloperKey;
				request.Headers.Add(header);
			}
		}

		public virtual Uri ApplyAuthenticationToUri(Uri source)
		{
			return source;
		}
	}
}
