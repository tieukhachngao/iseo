using System;

namespace CookComputing.XmlRpc
{
	[AttributeUsage(AttributeTargets.Parameter)]
	public class XmlRpcParameterAttribute : Attribute
	{
		private string string_0 = "";

		private string string_1 = "";

		public string Name => string_0;

		public string Description
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

		public XmlRpcParameterAttribute()
		{
		}

		public XmlRpcParameterAttribute(string name)
		{
			string_0 = name;
		}

		public override string ToString()
		{
			return "Description : " + string_1;
		}
	}
}
