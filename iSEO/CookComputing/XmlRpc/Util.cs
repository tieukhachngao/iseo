#define TRACE
using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace CookComputing.XmlRpc
{
	public class Util
	{
		protected Util()
		{
		}

		public static void CopyStream(Stream src, Stream dst)
		{
			byte[] buffer = new byte[4096];
			while (true)
			{
				int num = src.Read(buffer, 0, 4096);
				if (num != 0)
				{
					dst.Write(buffer, 0, num);
					continue;
				}
				break;
			}
		}

		public static Stream StringAsStream(string S)
		{
			MemoryStream memoryStream = new MemoryStream();
			StreamWriter streamWriter = new StreamWriter(memoryStream);
			streamWriter.Write(S);
			streamWriter.Flush();
			memoryStream.Seek(0L, SeekOrigin.Begin);
			return memoryStream;
		}

		public static void TraceStream(Stream stm)
		{
			TextReader textReader = new StreamReader(stm, new UTF8Encoding(), detectEncodingFromByteOrderMarks: true, 4096);
			for (string text = textReader.ReadLine(); text != null; text = textReader.ReadLine())
			{
				Trace.WriteLine(text);
			}
		}

		public static void DumpStream(Stream stm)
		{
			TextReader textReader = new StreamReader(stm);
			for (string text = textReader.ReadLine(); text != null; text = textReader.ReadLine())
			{
				Trace.WriteLine(text);
			}
		}

		public static Guid NewGuid()
		{
			return Guid.NewGuid();
		}
	}
}
