using System;
using System.IO;

namespace Google.GData.Client
{
	public abstract class MediaSource
	{
		private string string_0;

		private string string_1;

		public abstract long ContentLength { get; }

		public string Name
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

		public string ContentType
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

		[Obsolete("That name was misleading. Use GetDataStream() instead")]
		public abstract Stream Data { get; }

		public MediaSource(string contenttype)
		{
			ContentType = contenttype;
		}

		public MediaSource(string name, string contenttype)
		{
			Name = name;
			ContentType = contenttype;
		}

		public abstract Stream GetDataStream();
	}
}
