using System;
using System.IO;

namespace Google.GData.Client
{
	public class MediaService : Service
	{
		private const string string_1 = "END_OF_PART";

		private const string string_2 = "multipart/related; boundary=\"END_OF_PART\"";

		public MediaService(string applicationName)
			: base(applicationName)
		{
		}

		public MediaService(string service, string applicationName)
			: base(service, applicationName)
		{
		}

		internal override Stream EntrySend(Uri feedUri, AtomBase baseEntry, GDataRequestType type, AsyncSendData data)
		{
			if (feedUri == null)
			{
				throw new ArgumentNullException("feedUri");
			}
			if (baseEntry == null)
			{
				throw new ArgumentNullException("baseEntry");
			}
			AbstractEntry abstractEntry = baseEntry as AbstractEntry;
			if (abstractEntry != null && abstractEntry.MediaSource != null)
			{
				Stream stream = null;
				Stream stream2 = null;
				try
				{
					IGDataRequest iGDataRequest = base.RequestFactory.CreateRequest(type, feedUri);
					iGDataRequest.Credentials = base.Credentials;
					GDataRequest gDataRequest = iGDataRequest as GDataRequest;
					if (gDataRequest != null)
					{
						gDataRequest.ContentType = "multipart/related; boundary=\"END_OF_PART\"";
						gDataRequest.Slug = abstractEntry.MediaSource.Name;
						(base.RequestFactory as GDataRequestFactory)?.CustomHeaders.Add("MIME-version: 1.0");
					}
					if (data != null)
					{
						GDataGAuthRequest gDataGAuthRequest = iGDataRequest as GDataGAuthRequest;
						if (gDataGAuthRequest != null)
						{
							gDataGAuthRequest.AsyncData = data;
						}
					}
					stream = iGDataRequest.GetRequestStream();
					stream2 = abstractEntry.MediaSource.GetDataStream();
					StreamWriter streamWriter = new StreamWriter(stream);
					streamWriter.WriteLine("Media multipart posting");
					CreateBoundary(streamWriter, "application/atom+xml; charset=UTF-8");
					baseEntry.SaveToXml(stream);
					streamWriter.WriteLine();
					CreateBoundary(streamWriter, abstractEntry.MediaSource.ContentType);
					WriteInputStreamToRequest(stream2, stream);
					streamWriter.WriteLine();
					streamWriter.WriteLine("--END_OF_PART--");
					streamWriter.Flush();
					iGDataRequest.Execute();
					stream.Close();
					stream = null;
					return iGDataRequest.GetResponseStream();
				}
				catch (Exception)
				{
					throw;
				}
				finally
				{
					stream?.Close();
					stream2?.Close();
				}
			}
			return base.EntrySend(feedUri, baseEntry, type, data);
		}

		protected void CreateBoundary(StreamWriter w, string contentType)
		{
			w.WriteLine("--END_OF_PART");
			w.WriteLine("Content-Type: " + contentType);
			if (contentType != "application/atom+xml; charset=UTF-8")
			{
				w.WriteLine("Content-Transfer-Encoding: binary");
			}
			w.WriteLine();
			w.Flush();
		}
	}
}
