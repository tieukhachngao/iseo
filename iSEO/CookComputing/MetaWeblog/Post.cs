using System;
using CookComputing.XmlRpc;

namespace CookComputing.MetaWeblog
{
	[XmlRpcMissingMapping(MappingAction.Ignore)]
	public struct Post
	{
		[XmlRpcMissingMapping(MappingAction.Error)]
		[XmlRpcMember(Description = "Required when posting.")]
		public DateTime dateCreated;

		[XmlRpcMissingMapping(MappingAction.Error)]
		[XmlRpcMember(Description = "Required when posting.")]
		public string description;

		[XmlRpcMember(Description = "Required when posting.")]
		[XmlRpcMissingMapping(MappingAction.Error)]
		public string title;

		public string[] categories;

		public Enclosure enclosure;

		public string link;

		public string permalink;

		[XmlRpcMember(Description = "Not required when posting. Depending on server may be either string or integer. Use Convert.ToInt32(postid) to treat as integer or Convert.ToString(postid) to treat as string")]
		public object postid;

		public Source source;

		public string userid;

		public object mt_allow_comments;

		public object mt_allow_pings;

		public object mt_convert_breaks;

		public string mt_text_more;

		public string mt_excerpt;

		public string mt_keywords;
	}
}
