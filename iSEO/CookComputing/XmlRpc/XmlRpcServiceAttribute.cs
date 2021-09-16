using System;

namespace CookComputing.XmlRpc
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
	public class XmlRpcServiceAttribute : Attribute
	{
		private string string_0 = "";

		private string string_1;

		private int int_0 = 2;

		private bool bool_0;

		private bool bool_1 = true;

		private bool bool_2 = true;

		private string string_2 = "";

		private bool bool_3 = true;

		private bool bool_4 = true;

		private bool bool_5;

		public bool AutoDocumentation
		{
			get
			{
				return bool_1;
			}
			set
			{
				bool_1 = value;
			}
		}

		public bool AutoDocVersion
		{
			get
			{
				return bool_2;
			}
			set
			{
				bool_2 = value;
			}
		}

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

		public int Indentation
		{
			get
			{
				return int_0;
			}
			set
			{
				int_0 = value;
			}
		}

		public bool Introspection
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
				return string_2;
			}
			set
			{
				string_2 = value;
			}
		}

		public bool UseIndentation
		{
			get
			{
				return bool_4;
			}
			set
			{
				bool_4 = value;
			}
		}

		public bool UseIntTag
		{
			get
			{
				return bool_5;
			}
			set
			{
				bool_5 = value;
			}
		}

		public bool UseStringTag
		{
			get
			{
				return bool_3;
			}
			set
			{
				bool_3 = value;
			}
		}

		public string XmlEncoding
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

		public override string ToString()
		{
			return "Description : " + string_0;
		}
	}
}
