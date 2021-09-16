using System;

namespace CookComputing.XmlRpc
{
	public class XmlRpcParameterInfo
	{
		private string string_0;

		private string string_1;

		private Type type_0;

		private string string_2;

		private string string_3;

		private bool bool_0;

		public string Doc
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

		public bool IsParams
		{
			get
			{
				return bool_0;
			}
			set
			{
				bool_0 = value;
			}
		}

		public string Name
		{
			get
			{
				return string_1;
			}
			set
			{
				string_1 = value;
				if (string_2 == "")
				{
					string_2 = string_1;
				}
			}
		}

		public string XmlRpcName
		{
			get
			{
				return string_2;
			}
			set
			{
				string_2 = value;
			}
		}

		public Type Type
		{
			get
			{
				return type_0;
			}
			set
			{
				type_0 = value;
			}
		}

		public string XmlRpcType
		{
			get
			{
				return string_3;
			}
			set
			{
				string_3 = value;
			}
		}
	}
}
