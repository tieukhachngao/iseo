using System;
using System.IO;
using Microsoft.Win32;

namespace Google.GData.Client
{
	public class MediaFileSource : MediaSource
	{
		private string string_2;

		private Stream stream_0;

		public override long ContentLength
		{
			get
			{
				try
				{
					Stream dataStream = GetDataStream();
					long length = dataStream.Length;
					dataStream.Close();
					return length;
				}
				catch (NotSupportedException)
				{
					return -1L;
				}
			}
		}

		[Obsolete("That name was misleading. Use GetDataStream() instead")]
		public override Stream Data => GetDataStream();

		public MediaFileSource(string fileName, string contentType)
			: base(fileName, contentType)
		{
			string_2 = fileName;
			FileInfo fileInfo = new FileInfo(fileName);
			base.Name = fileInfo.Name;
		}

		public MediaFileSource(Stream data, string fileName, string contentType)
			: base(fileName, contentType)
		{
			stream_0 = data;
		}

		public static string GetContentTypeForFileName(string fileName)
		{
			string name = Path.GetExtension(fileName).ToLower();
			using (RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(name))
			{
				if (registryKey != null && registryKey.GetValue("Content Type") != null)
				{
					return registryKey.GetValue("Content Type").ToString();
				}
			}
			return null;
		}

		public override Stream GetDataStream()
		{
			if (!string.IsNullOrEmpty(string_2))
			{
				return File.OpenRead(string_2);
			}
			MemoryStream memoryStream = new MemoryStream();
			stream_0.Position = 0L;
			method_0(stream_0, memoryStream);
			memoryStream.Position = 0L;
			return memoryStream;
		}

		private void method_0(Stream A_0, Stream A_1)
		{
			byte[] array = new byte[32768];
			int count;
			while ((count = A_0.Read(array, 0, array.Length)) > 0)
			{
				A_1.Write(array, 0, count);
			}
		}
	}
}
