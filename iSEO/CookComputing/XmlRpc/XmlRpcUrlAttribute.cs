using System;

namespace CookComputing.XmlRpc
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
	public class XmlRpcUrlAttribute : Attribute
	{
		private string string_0;

		public string Uri => string_0;

		public XmlRpcUrlAttribute(string UriString)
		{
			string_0 = UriString;
		}

		public override string ToString()
		{
			return "Uri : " + string_0;
		}
	}
}
