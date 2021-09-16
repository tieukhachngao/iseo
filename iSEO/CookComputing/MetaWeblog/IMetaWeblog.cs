using CookComputing.XmlRpc;

namespace CookComputing.MetaWeblog
{
	public interface IMetaWeblog
	{
		[XmlRpcMethod("metaWeblog.editPost", Description = "Updates and existing post to a designated blog using the metaWeblog API. Returns true if completed.")]
		object editPost(string postid, string username, string password, Post post, bool publish);

		[XmlRpcMethod("metaWeblog.getCategories", Description = "Retrieves a list of valid categories for a post using the metaWeblog API. Returns the metaWeblog categories struct collection.")]
		Category[] getCategories(string blogid, string username, string password);

		[XmlRpcMethod("metaWeblog.getPost", Description = "Retrieves an existing post using the metaWeblog API. Returns the metaWeblog struct.")]
		Post getPost(string postid, string username, string password);

		[XmlRpcMethod("metaWeblog.getRecentPosts", Description = "Retrieves a list of the most recent existing post using the metaWeblog API. Returns the metaWeblog struct collection.")]
		Post[] getRecentPosts(string blogid, string username, string password, int numberOfPosts);

		[XmlRpcMethod("metaWeblog.newPost", Description = "Makes a new post to a designated blog using the metaWeblog API. Returns postid as a string.")]
		string newPost(string blogid, string username, string password, Post post, bool publish);
	}
}
