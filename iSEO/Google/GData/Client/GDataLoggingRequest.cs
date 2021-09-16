using System;
using System.IO;
using System.Net;
using System.Text;

namespace Google.GData.Client
{
	public class GDataLoggingRequest : GDataGAuthRequest, IDisposable
	{
		private string string_3;

		private string string_4;

		private string string_5;

		private MemoryStream memoryStream_1;

		internal GDataLoggingRequest(GDataRequestType A_0, Uri A_1, GDataGAuthRequestFactory A_2, string A_3, string A_4, string A_5)
			: base(A_0, A_1, A_2)
		{
			string_3 = A_3;
			string_4 = A_4;
			string_5 = A_5;
		}

		protected override void Dispose(bool disposing)
		{
			try
			{
				memoryStream_1.Close();
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		public override void Execute()
		{
			try
			{
				base.Execute();
			}
			catch (GDataRequestException ex)
			{
				HttpWebResponse httpWebResponse = ex.Response as HttpWebResponse;
				StreamWriter streamWriter = new StreamWriter(string_4);
				StreamWriter streamWriter2 = new StreamWriter(string_5, append: true, Encoding.UTF8, 512);
				if (httpWebResponse != null)
				{
					smethod_1(A_0: false, httpWebResponse.Headers, null, httpWebResponse.ResponseUri, streamWriter);
					smethod_1(A_0: false, httpWebResponse.Headers, null, httpWebResponse.ResponseUri, streamWriter2);
					Stream responseStream = httpWebResponse.GetResponseStream();
					smethod_0(responseStream, streamWriter2, streamWriter);
				}
				streamWriter.Close();
				streamWriter2.Close();
				throw;
			}
		}

		protected override void LogRequest(WebRequest request)
		{
			StreamWriter streamWriter = new StreamWriter(string_3);
			StreamWriter streamWriter2 = new StreamWriter(string_5, append: true, Encoding.UTF8, 512);
			HttpWebRequest httpWebRequest = request as HttpWebRequest;
			if (httpWebRequest != null)
			{
				smethod_1(A_0: true, httpWebRequest.Headers, httpWebRequest.Method, httpWebRequest.RequestUri, streamWriter);
				smethod_1(A_0: true, httpWebRequest.Headers, httpWebRequest.Method, httpWebRequest.RequestUri, streamWriter2);
			}
			if (base.RequestCopy != null)
			{
				base.RequestCopy.Seek(0L, SeekOrigin.Begin);
				smethod_0(base.RequestCopy, streamWriter, streamWriter2);
				base.RequestCopy.Seek(0L, SeekOrigin.Begin);
			}
			streamWriter.Close();
			streamWriter2.Close();
		}

		protected override void LogResponse(WebResponse response)
		{
			StreamWriter streamWriter = new StreamWriter(string_4);
			StreamWriter streamWriter2 = new StreamWriter(string_5, append: true, Encoding.UTF8, 512);
			HttpWebResponse httpWebResponse = response as HttpWebResponse;
			if (httpWebResponse != null)
			{
				smethod_1(A_0: false, httpWebResponse.Headers, httpWebResponse.Method, httpWebResponse.ResponseUri, streamWriter);
				smethod_1(A_0: false, httpWebResponse.Headers, httpWebResponse.Method, httpWebResponse.ResponseUri, streamWriter2);
			}
			Stream responseStream = GetResponseStream();
			if (responseStream != null)
			{
				responseStream.Seek(0L, SeekOrigin.Begin);
				smethod_0(responseStream, streamWriter, streamWriter2);
				responseStream.Seek(0L, SeekOrigin.Begin);
			}
			streamWriter.Close();
			streamWriter2.Close();
		}

		protected override void Reset()
		{
			base.Reset();
			memoryStream_1.Close();
			memoryStream_1 = null;
		}

		private static void smethod_0(Stream A_0, StreamWriter A_1, StreamWriter A_2)
		{
			if (A_0 != null)
			{
				StreamReader streamReader = new StreamReader(A_0);
				string value;
				while ((value = streamReader.ReadLine()) != null)
				{
					A_1.WriteLine(value);
					A_2.WriteLine(value);
				}
				A_1.Close();
				A_2.WriteLine();
				A_2.Close();
			}
		}

		private static void smethod_1(bool A_0, WebHeaderCollection A_1, string A_2, Uri A_3, StreamWriter A_4)
		{
			if (A_4 != null && A_1 != null)
			{
				if (A_0)
				{
					A_4.WriteLine("Request at: " + DateTime.Now);
				}
				else
				{
					A_4.WriteLine("Response received at: " + DateTime.Now);
				}
				if (A_2 != null)
				{
					A_4.WriteLine(A_2 + " to: " + A_3.ToString());
				}
				string[] allKeys = A_1.AllKeys;
				foreach (string text in allKeys)
				{
					A_4.WriteLine("Header: " + text + ":" + A_1[text]);
				}
				A_4.Flush();
			}
		}

		public override Stream GetResponseStream()
		{
			if (memoryStream_1 == null)
			{
				Stream responseStream = base.GetResponseStream();
				if (responseStream != null)
				{
					memoryStream_1 = new MemoryStream();
					byte[] buffer = new byte[4096];
					int count;
					while ((count = responseStream.Read(buffer, 0, 4096)) > 0)
					{
						memoryStream_1.Write(buffer, 0, count);
					}
					memoryStream_1.Seek(0L, SeekOrigin.Begin);
				}
			}
			return memoryStream_1;
		}
	}
}
