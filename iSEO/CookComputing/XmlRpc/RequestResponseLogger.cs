using System;
using System.IO;

namespace CookComputing.XmlRpc
{
	public class RequestResponseLogger : XmlRpcLogger
	{
		private string string_0 = ".";

		public string Directory
		{
			get
			{
				return string_0;
			}
			set
			{
				string_0 = Path.GetDirectoryName(value + "/");
			}
		}

		protected override void OnRequest(object sender, XmlRpcRequestEventArgs e)
		{
			string path = $"{string_0}/{DateTime.Now.Ticks}-{e.RequestNum:0000}-request-{e.ProxyID}.xml";
			FileStream fileStream = new FileStream(path, FileMode.Create);
			Util.CopyStream(e.RequestStream, fileStream);
			fileStream.Close();
		}

		protected override void OnResponse(object sender, XmlRpcResponseEventArgs e)
		{
			string path = $"{string_0}/{DateTime.Now.Ticks}-{e.RequestNum:0000}-response-{e.ProxyID}.xml";
			FileStream fileStream = new FileStream(path, FileMode.Create);
			Util.CopyStream(e.ResponseStream, fileStream);
			fileStream.Close();
		}
	}
}
