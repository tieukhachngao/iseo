using CookComputing.XmlRpc;

namespace CookComputing.MetaWeblog
{
	[XmlRpcMissingMapping(MappingAction.Ignore)]
	public struct Source
	{
		public string name;

		public string url;
	}
}
