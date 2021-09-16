using System;

namespace CookComputing.XmlRpc
{
	[AttributeUsage(AttributeTargets.ReturnValue)]
	public class XmlRpcReturnValueAttribute : Attribute
	{
		private string string_0 = "";

		public string Description
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

		public override string ToString()
		{
			return "Description : " + string_0;
		}
	}
}
