using System;
using System.IO;
using System.Net;

namespace Google.GData.Client
{
	public class GDataGAuthRequest : GDataRequest
	{
		private MemoryStream memoryStream_0;

		private GDataGAuthRequestFactory gdataGAuthRequestFactory_0;

		private AsyncData asyncData_0;

		private Class59 class59_0;

		internal Stream RequestCopy => memoryStream_0;

		internal AsyncData AsyncData
		{
			set
			{
				asyncData_0 = value;
			}
		}

		internal Class59 ResponseVersion => class59_0;

		internal GDataGAuthRequest(GDataRequestType A_0, Uri A_1, GDataGAuthRequestFactory A_2)
			: base(A_0, A_1, A_2)
		{
			gdataGAuthRequestFactory_0 = A_2;
		}

		public override Stream GetRequestStream()
		{
			memoryStream_0 = new MemoryStream();
			return memoryStream_0;
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
			if (!disposed && disposing)
			{
				if (memoryStream_0 != null)
				{
					memoryStream_0.Close();
					memoryStream_0 = null;
				}
				disposed = true;
			}
		}

		protected override void EnsureCredentials()
		{
			if (base.Request == null)
			{
				return;
			}
			if (gdataGAuthRequestFactory_0.GAuthToken == null)
			{
				GDataCredentials credentials = base.Credentials;
				if (credentials != null)
				{
					gdataGAuthRequestFactory_0.GAuthToken = method_0(credentials);
				}
			}
			if (gdataGAuthRequestFactory_0.GAuthToken != null && gdataGAuthRequestFactory_0.GAuthToken.Length > 0)
			{
				string header = "Authorization: GoogleLogin auth=" + gdataGAuthRequestFactory_0.GAuthToken;
				base.Request.Headers.Add(header);
			}
		}

		protected override void EnsureWebRequest()
		{
			base.EnsureWebRequest();
			HttpWebRequest httpWebRequest = base.Request as HttpWebRequest;
			if (httpWebRequest == null)
			{
				return;
			}
			httpWebRequest.Headers.Remove("GData-Version");
			httpWebRequest.AllowWriteStreamBuffering = false;
			IVersionAware versionAware = gdataGAuthRequestFactory_0;
			if (versionAware != null)
			{
				httpWebRequest.Headers.Set("GData-Version", versionAware.ProtocolMajor + "." + versionAware.ProtocolMinor);
			}
			httpWebRequest.AllowAutoRedirect = false;
			if (gdataGAuthRequestFactory_0.MethodOverride && httpWebRequest.Method != "GET" && httpWebRequest.Method != "POST")
			{
				httpWebRequest.Headers.Remove("X-HTTP-Method-Override");
				string method = httpWebRequest.Method;
				httpWebRequest.Headers.Set("X-HTTP-Method-Override", method);
				httpWebRequest.Method = "POST";
				if (method == "DELETE")
				{
					httpWebRequest.ContentLength = 0L;
					Stream requestStream = httpWebRequest.GetRequestStream();
					requestStream.Close();
				}
			}
		}

		internal string method_0(GDataCredentials A_0)
		{
			Uri uri = null;
			GDataCredentials gDataCredentials = new GDataCredentials(A_0.Username, A_0.method_0());
			gDataCredentials.CaptchaToken = gdataGAuthRequestFactory_0.CaptchaToken;
			gDataCredentials.CaptchaAnswer = gdataGAuthRequestFactory_0.CaptchaAnswer;
			gDataCredentials.AccountType = A_0.AccountType;
			try
			{
				uri = new Uri(gdataGAuthRequestFactory_0.Handler);
			}
			catch
			{
				throw new GDataRequestException("Invalid authentication handler URI given");
			}
			return Utilities.QueryClientLoginToken(gDataCredentials, gdataGAuthRequestFactory_0.Service, gdataGAuthRequestFactory_0.ApplicationName, gdataGAuthRequestFactory_0.KeepAlive, gdataGAuthRequestFactory_0.Proxy, uri);
		}

		public override void Execute()
		{
			Execute(1);
		}

		protected void Execute(int retryCounter)
		{
			try
			{
				CopyRequestData();
				base.Execute();
				if (base.Response is HttpWebResponse)
				{
					HttpWebResponse httpWebResponse = base.Response as HttpWebResponse;
					class59_0 = new Class59(httpWebResponse.Headers["GData-Version"]);
				}
			}
			catch (GDataForbiddenException)
			{
				Reset();
				gdataGAuthRequestFactory_0.GAuthToken = null;
				CopyRequestData();
				base.Execute();
			}
			catch (GDataRedirectException ex2)
			{
				if (gdataGAuthRequestFactory_0.StrictRedirect)
				{
					HttpWebRequest httpWebRequest = base.Request as HttpWebRequest;
					if (httpWebRequest != null && httpWebRequest.Method != "GET")
					{
						throw;
					}
				}
				if (ex2.Location.Trim().Length == 0)
				{
					throw;
				}
				Reset();
				base.TargetUri = new Uri(ex2.Location);
				CopyRequestData();
				base.Execute();
			}
			catch (GDataRequestException ex3)
			{
				HttpWebResponse httpWebResponse2 = ex3.Response as HttpWebResponse;
				if (httpWebResponse2 != null && httpWebResponse2.StatusCode != HttpStatusCode.InternalServerError)
				{
					throw;
				}
				if (retryCounter > gdataGAuthRequestFactory_0.NumberOfRetries)
				{
					throw;
				}
				Reset();
				Execute(retryCounter + 1);
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				if (memoryStream_0 != null)
				{
					memoryStream_0.Close();
					memoryStream_0 = null;
				}
			}
		}

		protected void CopyRequestData()
		{
			if (memoryStream_0 == null)
			{
				return;
			}
			EnsureWebRequest();
			base.Request.ContentLength = memoryStream_0.Length;
			Stream requestStream = base.GetRequestStream();
			try
			{
				byte[] buffer = new byte[4096];
				double num = 100.0;
				if (memoryStream_0.Length > 4096L)
				{
					num = 100.0 / ((double)memoryStream_0.Length / 4096.0);
				}
				memoryStream_0.Seek(0L, SeekOrigin.Begin);
				long num2 = 0L;
				double num3 = 0.0;
				int num4;
				while ((num4 = memoryStream_0.Read(buffer, 0, 4096)) > 0)
				{
					requestStream.Write(buffer, 0, num4);
					num2 += num4;
					if (asyncData_0 != null && asyncData_0.Delegate != null && asyncData_0.DataHandler != null)
					{
						AsyncOperationProgressEventArgs a_ = new AsyncOperationProgressEventArgs(memoryStream_0.Length, num2, (int)num3, base.Request.RequestUri, base.Request.Method, asyncData_0.UserData);
						num3 += num;
						if (!asyncData_0.DataHandler.method_4(asyncData_0, a_))
						{
							break;
						}
					}
				}
			}
			finally
			{
				requestStream.Close();
			}
		}
	}
}
