using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Threading;

namespace Google.GData.Client.ResumableUpload
{
	public class ResumableUploader : AsyncDataHandler
	{
		private delegate void Delegate2(Class0 A_0, AsyncOperation A_1, SendOrPostCallback A_2);

		private int int_0;

		private Dictionary<Uri, long> dictionary_0 = new Dictionary<Uri, long>();

		private static long long_0 = 1024000L;

		public static string CreateMediaRelation = "http://schemas.google.com/g/2005#resumable-create-media";

		public static string EditMediaRelation = "http://schemas.google.com/g/2005#resumable-edit-media";

		public ResumableUploader()
			: this(25)
		{
		}

		public ResumableUploader(int chunkSize)
		{
			if (chunkSize < 1)
			{
				throw new ArgumentException("chunkSize needs to be > 0");
			}
			int_0 = chunkSize;
			ServicePointManager.Expect100Continue = false;
		}

		public static Uri GetResumableEditUri(AtomLinkCollection links)
		{
			AtomLink atomLink = links.FindService(EditMediaRelation, null);
			if (atomLink != null)
			{
				return new Uri(atomLink.AbsoluteUri);
			}
			return null;
		}

		public static Uri GetResumableCreateUri(AtomLinkCollection links)
		{
			AtomLink atomLink = links.FindService(CreateMediaRelation, null);
			if (atomLink != null)
			{
				return new Uri(atomLink.AbsoluteUri);
			}
			return null;
		}

		public WebResponse Insert(Authenticator authentication, AbstractEntry payload)
		{
			return method_5(authentication, payload, null);
		}

		public WebResponse Insert(Authenticator authentication, Uri resumableUploadUri, Stream payload, string contentType, string slug)
		{
			return method_6(authentication, resumableUploadUri, payload, contentType, slug, null);
		}

		private WebResponse method_5(Authenticator A_0, AbstractEntry A_1, AsyncData A_2)
		{
			WebResponse webResponse = null;
			Uri resumableCreateUri = GetResumableCreateUri(A_1.Links);
			if (resumableCreateUri == null)
			{
				throw new ArgumentException("payload did not contain a resumable create media Uri");
			}
			Uri sessionUri = InitiateUpload(resumableCreateUri, A_0, A_1);
			using Stream payload = A_1.MediaSource.GetDataStream();
			return UploadStream("POST", sessionUri, A_0, payload, A_1.MediaSource.ContentType, A_2);
		}

		private WebResponse method_6(Authenticator A_0, Uri A_1, Stream A_2, string A_3, string A_4, AsyncData A_5)
		{
			Uri sessionUri = InitiateUpload(A_1, A_0, A_3, A_4, method_14(A_2));
			return UploadStream("POST", sessionUri, A_0, A_2, A_3, A_5);
		}

		public void InsertAsync(Authenticator authentication, Uri resumableUploadUri, Stream payload, string contentType, string slug, object userData)
		{
			Class0 a_ = new Class0(this, authentication, resumableUploadUri, payload, contentType, slug, "POST", base.ProgressReportDelegate, userData);
			Delegate2 a_2 = method_7;
			method_17(a_, a_2, userData);
		}

		public void InsertAsync(Authenticator authentication, AbstractEntry payload, object userData)
		{
			Class0 @class = new Class0(this, authentication, payload, "POST", base.ProgressReportDelegate, userData);
			@class.UriToUse = GetResumableCreateUri(payload.Links);
			Delegate2 a_ = method_7;
			method_17(@class, a_, userData);
		}

		public static long QueryStatus(Authenticator authentication, Uri targetUri)
		{
			HttpWebRequest httpWebRequest = authentication.CreateHttpWebRequest("POST", targetUri);
			long result = -1L;
			string value = $"bytes */*";
			httpWebRequest.Headers.Set(HttpRequestHeader.ContentRange, value);
			httpWebRequest.ContentLength = 0L;
			HttpWebResponse httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse;
			string text = httpWebResponse.Headers["Range"];
			string[] array = text.Split('-');
			if (array.Length > 1 && array[1] != null)
			{
				result = long.Parse(array[1]);
			}
			return result;
		}

		private void method_7(Class0 A_0, AsyncOperation A_1, SendOrPostCallback A_2)
		{
			try
			{
				AbstractEntry abstractEntry = A_0.Entry as AbstractEntry;
				if (abstractEntry != null)
				{
					using WebResponse webResponse = method_5(A_0.method_1(), abstractEntry, A_0);
					HandleResponseStream(A_0, webResponse.GetResponseStream(), -1L, abstractEntry.Service);
				}
				else
				{
					using WebResponse webResponse2 = method_6(A_0.method_1(), A_0.UriToUse, A_0.DataStream, A_0.method_0(), A_0.method_2(), A_0);
					HandleResponseStream(A_0, webResponse2.GetResponseStream(), -1L, null);
				}
			}
			catch (Exception ex)
			{
				Exception ex3 = (A_0.Exception = ex);
			}
			base.CompletionMethodDelegate(A_0);
		}

		public WebResponse Update(Authenticator authentication, AbstractEntry payload)
		{
			return method_8(authentication, payload, null);
		}

		public WebResponse Update(Authenticator authentication, Uri resumableUploadUri, Stream payload, string contentType)
		{
			return method_9(authentication, resumableUploadUri, payload, contentType, null);
		}

		private WebResponse method_8(Authenticator A_0, AbstractEntry A_1, AsyncData A_2)
		{
			WebResponse webResponse = null;
			Uri resumableEditUri = GetResumableEditUri(A_1.Links);
			if (resumableEditUri == null)
			{
				throw new ArgumentException("payload did not contain a resumabled edit media Uri");
			}
			Uri sessionUri = InitiateUpload(resumableEditUri, A_0, A_1, "PUT");
			using Stream payload = A_1.MediaSource.GetDataStream();
			return UploadStream("PUT", sessionUri, A_0, payload, A_1.MediaSource.ContentType, A_2);
		}

		private WebResponse method_9(Authenticator A_0, Uri A_1, Stream A_2, string A_3, AsyncData A_4)
		{
			Uri sessionUri = InitiateUpload(A_1, A_0, A_3, null, method_14(A_2), "PUT");
			return UploadStream("PUT", sessionUri, A_0, A_2, A_3, A_4);
		}

		public void UpdateAsync(Authenticator authentication, Uri resumableUploadUri, Stream payload, string contentType, object userData)
		{
			Class0 a_ = new Class0(this, authentication, resumableUploadUri, payload, contentType, null, "PUT", base.ProgressReportDelegate, userData);
			Delegate2 a_2 = method_12;
			method_17(a_, a_2, userData);
		}

		public void UpdateAsync(Authenticator authentication, AbstractEntry payload, object userData)
		{
			Class0 a_ = new Class0(this, authentication, payload, "PUT", base.ProgressReportDelegate, userData);
			Delegate2 a_2 = method_12;
			method_17(a_, a_2, userData);
		}

		public WebResponse Resume(Authenticator authentication, Uri resumeUri, string httpMethod, Stream payload, string contentType)
		{
			return method_10(authentication, resumeUri, httpMethod, payload, contentType, null);
		}

		public void ResumeAsync(Authenticator authentication, Uri resumeUri, string httpmethod, Stream payload, string contentType, object userData)
		{
			Class0 a_ = new Class0(this, authentication, resumeUri, payload, contentType, null, httpmethod, base.ProgressReportDelegate, userData);
			Delegate2 a_2 = method_11;
			method_17(a_, a_2, userData);
		}

		private WebResponse method_10(Authenticator A_0, Uri A_1, string A_2, Stream A_3, string A_4, AsyncData A_5)
		{
			return UploadStream(A_2, A_1, A_0, A_3, A_4, A_5);
		}

		private void method_11(Class0 A_0, AsyncOperation A_1, SendOrPostCallback A_2)
		{
			try
			{
				using WebResponse webResponse = method_10(A_0.method_1(), A_0.UriToUse, A_0.HttpVerb, A_0.DataStream, A_0.method_0(), A_0);
				HandleResponseStream(A_0, webResponse.GetResponseStream(), -1L);
			}
			catch (Exception ex)
			{
				Exception ex3 = (A_0.Exception = ex);
			}
			base.CompletionMethodDelegate(A_0);
		}

		private void method_12(Class0 A_0, AsyncOperation A_1, SendOrPostCallback A_2)
		{
			try
			{
				AbstractEntry abstractEntry = A_0.Entry as AbstractEntry;
				if (abstractEntry != null)
				{
					using WebResponse webResponse = method_8(A_0.method_1(), abstractEntry, A_0);
					HandleResponseStream(A_0, webResponse.GetResponseStream(), -1L);
				}
				else
				{
					using WebResponse webResponse2 = method_9(A_0.method_1(), A_0.UriToUse, A_0.DataStream, A_0.method_0(), A_0);
					HandleResponseStream(A_0, webResponse2.GetResponseStream(), -1L);
				}
			}
			catch (Exception ex)
			{
				Exception ex3 = (A_0.Exception = ex);
			}
			base.CompletionMethodDelegate(A_0);
		}

		public WebResponse UploadStream(string httpMethod, Uri sessionUri, Authenticator authentication, Stream payload, string mediaType, AsyncData data)
		{
			HttpWebResponse result = null;
			int num = 0;
			if (!dictionary_0.ContainsKey(sessionUri))
			{
				dictionary_0.Add(sessionUri, 0L);
			}
			bool flag = false;
			try
			{
				if (payload.Position != 0L)
				{
					num = (int)((double)payload.Position / (double)(int_0 * long_0));
				}
			}
			catch (NotSupportedException)
			{
				num = 0;
			}
			do
			{
				try
				{
					HttpWebResponse httpWebResponse = method_13(num, httpMethod, sessionUri, authentication, payload, mediaType, data);
					if (data != null && CheckIfOperationIsCancelled(data.UserData))
					{
						break;
					}
					num++;
					switch (httpWebResponse.StatusCode)
					{
					case (HttpStatusCode)308:
						flag = false;
						break;
					default:
						throw new ApplicationException("Unexpected return code during resumable upload");
					case HttpStatusCode.OK:
					case HttpStatusCode.Created:
						flag = true;
						result = httpWebResponse;
						break;
					}
					continue;
				}
				finally
				{
					HttpWebResponse httpWebResponse = null;
				}
			}
			while (!flag);
			dictionary_0.Remove(sessionUri);
			return result;
		}

		private HttpWebResponse method_13(int A_0, string A_1, Uri A_2, Authenticator A_3, Stream A_4, string A_5, AsyncData A_6)
		{
			HttpWebRequest httpWebRequest = A_3.CreateHttpWebRequest(A_1, A_2);
			httpWebRequest.AllowWriteStreamBuffering = false;
			httpWebRequest.Timeout = 600000;
			httpWebRequest.ContentType = A_5;
			CopyData(A_4, httpWebRequest, A_0, A_6, A_2);
			return httpWebRequest.GetResponse() as HttpWebResponse;
		}

		private long method_14(Stream A_0)
		{
			try
			{
				return A_0.Length;
			}
			catch (NotSupportedException)
			{
				return -1L;
			}
		}

		protected bool CopyData(Stream input, HttpWebRequest request, int partIndex, AsyncData data, Uri requestId)
		{
			long num = 0L;
			long num2 = dictionary_0[requestId];
			long num3 = int_0 * long_0;
			long num4 = method_14(input);
			input.Seek(num2, SeekOrigin.Begin);
			byte[] buffer = new byte[262144];
			int num5;
			while ((num5 = input.Read(buffer, 0, 262144)) > 0)
			{
				num += num5;
				if (num >= num3)
				{
					break;
				}
			}
			request.ContentLength = num;
			long num6 = num2 + num;
			string value = string.Format("bytes {0}-{1}/{2}", num2, num6 - 1L, (num4 > 0L) ? num4.ToString() : "*");
			request.Headers.Set(HttpRequestHeader.ContentRange, value);
			dictionary_0[requestId] = num6;
			using (Stream stream = request.GetRequestStream())
			{
				input.Seek(num2, SeekOrigin.Begin);
				num = 0L;
				while ((num5 = input.Read(buffer, 0, 262144)) > 0)
				{
					stream.Write(buffer, 0, num5);
					num += num5;
					if (data != null)
					{
						if (CheckIfOperationIsCancelled(data.UserData))
						{
							break;
						}
						if (data.Delegate != null && data.DataHandler != null)
						{
							long num7 = num2 + num - 1L;
							int percentage = (int)((double)num7 / (double)num4 * 100.0);
							AsyncOperationProgressEventArgs a_ = new AsyncOperationProgressEventArgs(num4, num7, percentage, request.RequestUri, request.Method, data.UserData);
							data.DataHandler.method_4(data, a_);
						}
					}
					if (num >= request.ContentLength)
					{
						break;
					}
				}
			}
			return num < num3;
		}

		public Uri InitiateUpload(Uri resumableUploadUri, Authenticator authentication, string contentType, string slug, long contentLength)
		{
			return InitiateUpload(resumableUploadUri, authentication, contentType, slug, contentLength, "POST");
		}

		public Uri InitiateUpload(Uri resumableUploadUri, Authenticator authentication, string contentType, string slug, long contentLength, string httpMethod)
		{
			HttpWebRequest httpWebRequest = method_16(resumableUploadUri, authentication, slug, contentType, contentLength, httpMethod);
			httpWebRequest.ContentLength = 0L;
			WebResponse response = httpWebRequest.GetResponse();
			return new Uri(response.Headers["Location"]);
		}

		public Uri InitiateUpload(Uri resumableUploadUri, Authenticator authentication, AbstractEntry entry)
		{
			return InitiateUpload(resumableUploadUri, authentication, entry, "POST");
		}

		public Uri InitiateUpload(Uri resumableUploadUri, Authenticator authentication, AbstractEntry entry, string httpMethod)
		{
			HttpWebRequest httpWebRequest = method_16(resumableUploadUri, authentication, entry.MediaSource.Name, entry.MediaSource.ContentType, entry.MediaSource.ContentLength, httpMethod);
			if (entry != null)
			{
				httpWebRequest.Headers.Set("GData-Version", ((IVersionAware)entry).ProtocolMajor + "." + ((IVersionAware)entry).ProtocolMinor);
			}
			if (entry != null && !Utilities.IsWeakETag(entry))
			{
				httpWebRequest.Headers.Set("If-Match", ((ISupportsEtag)entry).Etag);
			}
			Stream requestStream = httpWebRequest.GetRequestStream();
			entry.SaveToXml(requestStream);
			requestStream.Close();
			httpWebRequest.ContentType = "application/atom+xml; charset=UTF-8";
			WebResponse response = httpWebRequest.GetResponse();
			return new Uri(response.Headers["Location"]);
		}

		private HttpWebRequest method_15(Uri A_0, Authenticator A_1, string A_2, string A_3, long A_4)
		{
			return method_16(A_0, A_1, A_2, A_3, A_4, "POST");
		}

		private HttpWebRequest method_16(Uri A_0, Authenticator A_1, string A_2, string A_3, long A_4, string A_5)
		{
			HttpWebRequest httpWebRequest = A_1.CreateHttpWebRequest(A_5, A_0);
			httpWebRequest.Headers.Set("Slug", A_2);
			httpWebRequest.Headers.Set("X-Upload-Content-Type", A_3);
			if (A_4 != -1L)
			{
				httpWebRequest.Headers.Set("X-Upload-Content-Length", A_4.ToString());
			}
			return httpWebRequest;
		}

		private void method_17(Class0 A_0, Delegate2 A_1, object A_2)
		{
			AsyncOperation asyncOperation2 = (A_0.Operation = AsyncOperationManager.CreateOperation(A_2));
			AddUserDataToDictionary(A_2, asyncOperation2);
			A_1.BeginInvoke(A_0, asyncOperation2, base.CompletionMethodDelegate, null, null);
		}
	}
}
