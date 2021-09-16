using CookComputing.XmlRpc;

namespace CookComputing.MetaWeblog
{
	[XmlRpcMissingMapping(MappingAction.Ignore)]
	public struct Enclosure
	{
		public int length;

		public string type;

		public string url;
	}
}
