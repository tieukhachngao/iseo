using System;

namespace CookComputing.XmlRpc
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class XmlRpcMemberAttribute : Attribute
	{
		private string string_0 = "";

		private string string_1 = "";

		public string Member
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

		public XmlRpcMemberAttribute()
		{
		}

		public XmlRpcMemberAttribute(string member)
		{
			string_0 = member;
		}

		public override string ToString()
		{
			return "Member : " + string_0;
		}
	}
}
