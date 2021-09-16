using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace Google.GData.Client
{
	[Serializable]
	public class GDataRequestException : LoggedException
	{
		protected WebResponse webResponse;

		protected string responseText;

		public WebResponse Response => webResponse;

		public string ResponseString
		{
			get
			{
				if (responseText == null)
				{
					responseText = ReadResponseString();
				}
				return responseText;
			}
		}

		public GDataRequestException()
		{
		}

		protected string ReadResponseString()
		{
			if (webResponse == null)
			{
				return null;
			}
			Stream stream = webResponse.GetResponseStream();
			for (int i = 0; i < webResponse.Headers.Count; i++)
			{
				string text = webResponse.Headers[i].ToLower();
				if (!text.Contains("gzip"))
				{
					if (text.Contains("deflate"))
					{
						stream = new DeflateStream(stream, CompressionMode.Decompress);
						break;
					}
					continue;
				}
				stream = new GZipStream(stream, CompressionMode.Decompress);
				break;
			}
			if (stream == null)
			{
				return null;
			}
			StreamReader streamReader = new StreamReader(stream);
			return streamReader.ReadToEnd();
		}

		public GDataRequestException(string msg, Exception exception)
			: base(msg, exception)
		{
		}

		public GDataRequestException(string msg)
			: base(msg)
		{
		}

		public GDataRequestException(string msg, WebException exception)
			: base(msg, exception)
		{
			if (exception != null)
			{
				webResponse = exception.Response;
			}
		}

		public GDataRequestException(string msg, WebResponse response)
			: base(msg)
		{
			webResponse = response;
		}

		protected GDataRequestException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		[SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
		}
	}
}
