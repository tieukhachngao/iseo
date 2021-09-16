using System;

namespace CookComputing.XmlRpc
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field)]
	public class XmlRpcMissingMappingAttribute : Attribute
	{
		private MappingAction mappingAction_0 = MappingAction.Error;

		public MappingAction Action => mappingAction_0;

		public XmlRpcMissingMappingAttribute()
		{
		}

		public XmlRpcMissingMappingAttribute(MappingAction action)
		{
			mappingAction_0 = action;
		}

		public override string ToString()
		{
			return mappingAction_0.ToString();
		}
	}
}
