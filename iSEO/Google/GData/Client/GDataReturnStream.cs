using System.IO;

namespace Google.GData.Client
{
	public class GDataReturnStream : Stream, ISupportsEtag
	{
		private string string_0;

		private Stream stream_0;

		public override bool CanRead => stream_0.CanRead;

		public override bool CanSeek => stream_0.CanSeek;

		public override bool CanTimeout => stream_0.CanTimeout;

		public override bool CanWrite => stream_0.CanWrite;

		public override long Length => stream_0.Length;

		public override long Position
		{
			get
			{
				return stream_0.Position;
			}
			set
			{
				stream_0.Position = value;
			}
		}

		public string Etag
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

		public GDataReturnStream(IGDataRequest r)
		{
			stream_0 = r.GetResponseStream();
			ISupportsEtag supportsEtag = r as ISupportsEtag;
			if (supportsEtag != null)
			{
				string_0 = supportsEtag.Etag;
			}
		}

		public override void Close()
		{
			stream_0.Close();
		}

		public override void Flush()
		{
			stream_0.Flush();
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return stream_0.Seek(offset, origin);
		}

		public override void SetLength(long value)
		{
			stream_0.SetLength(value);
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return stream_0.Read(buffer, offset, count);
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
			stream_0.Write(buffer, offset, count);
		}
	}
}
