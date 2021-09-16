using System;
using System.Xml;

namespace Google.GData.Client
{
	public abstract class AbstractFeed : AtomFeed, ISupportsEtag
	{
		private string string_1;

		public string Etag
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

		protected AbstractFeed(Uri uriBase, IService service)
			: base(uriBase, service)
		{
			base.NewAtomEntry += OnParsedNewAbstractEntry;
		}

		protected override void AddOtherNamespaces(XmlWriter writer)
		{
			base.AddOtherNamespaces(writer);
			Utilities.EnsureGDataNamespace(writer);
		}

		protected override bool SkipNode(XmlNode node)
		{
			if (base.SkipNode(node))
			{
				return true;
			}
			if (node.NodeType == XmlNodeType.Attribute && node.Name.StartsWith("xmlns"))
			{
				return string.Compare(node.Value, "http://schemas.google.com/g/2005") == 0;
			}
			return false;
		}

		protected void OnParsedNewAbstractEntry(object sender, FeedParserEventArgs e)
		{
			if (e == null)
			{
				throw new ArgumentNullException("e");
			}
			if (e.CreatingEntry)
			{
				e.Entry = CreateFeedEntry();
			}
		}

		public abstract AtomEntry CreateFeedEntry();
	}
}
