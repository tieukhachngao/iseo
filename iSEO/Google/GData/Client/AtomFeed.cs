using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Xml;

namespace Google.GData.Client
{
	[Description("Expand to see the options for the feed")]
	[TypeConverter(typeof(AtomSourceConverter))]
	public class AtomFeed : AtomSource
	{
		private AtomEntryCollection atomEntryCollection_0;

		private FeedParserEventHandler feedParserEventHandler_0;

		private ExtensionElementEventHandler extensionElementEventHandler_0;

		private int int_0;

		private int int_1;

		private int int_2;

		private IService iservice_0;

		private GDataBatchFeedData gdataBatchFeedData_0;

		public string Post
		{
			get
			{
				AtomLink atomLink = base.Links.FindService("http://schemas.google.com/g/2005#post", "application/atom+xml");
				if (atomLink != null)
				{
					return Utilities.smethod_1(base.Base, base.ImpliedBase, atomLink.HRef.ToString());
				}
				return null;
			}
			set
			{
				AtomLink atomLink = base.Links.FindService("http://schemas.google.com/g/2005#post", "application/atom+xml");
				if (atomLink == null)
				{
					atomLink = new AtomLink("application/atom+xml", "http://schemas.google.com/g/2005#post");
					base.Links.Add(atomLink);
				}
				atomLink.HRef = new AtomUri(value);
			}
		}

		public GDataBatchFeedData BatchData
		{
			get
			{
				return gdataBatchFeedData_0;
			}
			set
			{
				gdataBatchFeedData_0 = value;
			}
		}

		public string Batch
		{
			get
			{
				AtomLink atomLink = base.Links.FindService("http://schemas.google.com/g/2005#batch", "application/atom+xml");
				if (atomLink != null)
				{
					return Utilities.smethod_1(base.Base, base.ImpliedBase, atomLink.HRef.ToString());
				}
				return null;
			}
			set
			{
				AtomLink atomLink = base.Links.FindService("http://schemas.google.com/g/2005#batch", "application/atom+xml");
				if (atomLink == null)
				{
					atomLink = new AtomLink("application/atom+xml", "http://schemas.google.com/g/2005#batch");
					base.Links.Add(atomLink);
				}
				atomLink.HRef = new AtomUri(value);
			}
		}

		public bool ReadOnly
		{
			get
			{
				if (Post != null)
				{
					return false;
				}
				return true;
			}
		}

		public string NextChunk
		{
			get
			{
				AtomLink atomLink = base.Links.FindService("next", "application/atom+xml");
				if (atomLink != null)
				{
					return Utilities.smethod_1(base.Base, base.ImpliedBase, atomLink.HRef.ToString());
				}
				return null;
			}
			set
			{
				AtomLink atomLink = base.Links.FindService("next", "application/atom+xml");
				if (atomLink == null)
				{
					atomLink = new AtomLink("application/atom+xml", "next");
					base.Links.Add(atomLink);
				}
				atomLink.HRef = new AtomUri(value);
			}
		}

		public string PrevChunk
		{
			get
			{
				AtomLink atomLink = base.Links.FindService("previous", "application/atom+xml");
				if (atomLink != null)
				{
					return Utilities.smethod_1(base.Base, base.ImpliedBase, atomLink.HRef.ToString());
				}
				return null;
			}
			set
			{
				AtomLink atomLink = base.Links.FindService("previous", "application/atom+xml");
				if (atomLink == null)
				{
					atomLink = new AtomLink("application/atom+xml", "previous");
					base.Links.Add(atomLink);
				}
				atomLink.HRef = new AtomUri(value);
			}
		}

		public string Feed
		{
			get
			{
				AtomLink atomLink = base.Links.FindService("http://schemas.google.com/g/2005#feed", "application/atom+xml");
				if (atomLink != null)
				{
					return Utilities.smethod_1(base.Base, base.ImpliedBase, atomLink.HRef.ToString());
				}
				return null;
			}
			set
			{
				AtomLink atomLink = base.Links.FindService("http://schemas.google.com/g/2005#feed", "application/atom+xml");
				if (atomLink == null)
				{
					atomLink = new AtomLink("application/atom+xml", "http://schemas.google.com/g/2005#feed");
					base.Links.Add(atomLink);
				}
				atomLink.HRef = new AtomUri(value);
			}
		}

		public string Self
		{
			get
			{
				AtomLink atomLink = base.Links.FindService("self", "application/atom+xml");
				if (atomLink != null)
				{
					return Utilities.smethod_1(base.Base, base.ImpliedBase, atomLink.HRef.ToString());
				}
				return null;
			}
			set
			{
				AtomLink atomLink = base.Links.FindService("self", "application/atom+xml");
				if (atomLink == null)
				{
					atomLink = new AtomLink("application/atom+xml", "self");
					base.Links.Add(atomLink);
				}
				atomLink.HRef = new AtomUri(value);
			}
		}

		public IService Service
		{
			get
			{
				return iservice_0;
			}
			set
			{
				base.Dirty = true;
				iservice_0 = value;
			}
		}

		public int TotalResults
		{
			get
			{
				return int_0;
			}
			set
			{
				base.Dirty = true;
				int_0 = value;
			}
		}

		public int StartIndex
		{
			get
			{
				return int_1;
			}
			set
			{
				base.Dirty = true;
				int_1 = value;
			}
		}

		public int ItemsPerPage
		{
			get
			{
				return int_2;
			}
			set
			{
				base.Dirty = true;
				int_2 = value;
			}
		}

		public AtomEntryCollection Entries
		{
			get
			{
				if (atomEntryCollection_0 == null)
				{
					atomEntryCollection_0 = new AtomEntryCollection(this);
				}
				return atomEntryCollection_0;
			}
		}

		public override string XmlName => "feed";

		public event FeedParserEventHandler NewAtomEntry
		{
			add
			{
				FeedParserEventHandler feedParserEventHandler = feedParserEventHandler_0;
				FeedParserEventHandler feedParserEventHandler2;
				do
				{
					feedParserEventHandler2 = feedParserEventHandler;
					FeedParserEventHandler value2 = (FeedParserEventHandler)Delegate.Combine(feedParserEventHandler2, value);
					feedParserEventHandler = Interlocked.CompareExchange(ref feedParserEventHandler_0, value2, feedParserEventHandler2);
				}
				while ((object)feedParserEventHandler != feedParserEventHandler2);
			}
			remove
			{
				FeedParserEventHandler feedParserEventHandler = feedParserEventHandler_0;
				FeedParserEventHandler feedParserEventHandler2;
				do
				{
					feedParserEventHandler2 = feedParserEventHandler;
					FeedParserEventHandler value2 = (FeedParserEventHandler)Delegate.Remove(feedParserEventHandler2, value);
					feedParserEventHandler = Interlocked.CompareExchange(ref feedParserEventHandler_0, value2, feedParserEventHandler2);
				}
				while ((object)feedParserEventHandler != feedParserEventHandler2);
			}
		}

		public event ExtensionElementEventHandler NewExtensionElement
		{
			add
			{
				ExtensionElementEventHandler extensionElementEventHandler = extensionElementEventHandler_0;
				ExtensionElementEventHandler extensionElementEventHandler2;
				do
				{
					extensionElementEventHandler2 = extensionElementEventHandler;
					ExtensionElementEventHandler value2 = (ExtensionElementEventHandler)Delegate.Combine(extensionElementEventHandler2, value);
					extensionElementEventHandler = Interlocked.CompareExchange(ref extensionElementEventHandler_0, value2, extensionElementEventHandler2);
				}
				while ((object)extensionElementEventHandler != extensionElementEventHandler2);
			}
			remove
			{
				ExtensionElementEventHandler extensionElementEventHandler = extensionElementEventHandler_0;
				ExtensionElementEventHandler extensionElementEventHandler2;
				do
				{
					extensionElementEventHandler2 = extensionElementEventHandler;
					ExtensionElementEventHandler value2 = (ExtensionElementEventHandler)Delegate.Remove(extensionElementEventHandler2, value);
					extensionElementEventHandler = Interlocked.CompareExchange(ref extensionElementEventHandler_0, value2, extensionElementEventHandler2);
				}
				while ((object)extensionElementEventHandler != extensionElementEventHandler2);
			}
		}

		private AtomFeed()
		{
		}

		public AtomFeed(Uri uriBase, IService service)
		{
			if (uriBase != null)
			{
				base.ImpliedBase = new AtomUri(uriBase.AbsoluteUri);
			}
			Service = service;
			NewExtensionElement += OnNewExtensionsElement;
		}

		public AtomFeed(AtomFeed originalFeed)
		{
			if (originalFeed == null)
			{
				throw new ArgumentNullException("originalFeed");
			}
			Batch = originalFeed.Batch;
			Post = originalFeed.Post;
			Self = originalFeed.Self;
			Feed = originalFeed.Feed;
			Service = originalFeed.Service;
			base.ImpliedBase = originalFeed.ImpliedBase;
		}

		public static bool IsFeedIdentical(AtomFeed feedOne, AtomFeed feedTwo)
		{
			if (feedOne == feedTwo)
			{
				return true;
			}
			if (feedOne != null && feedTwo != null)
			{
				if (string.Compare(feedOne.Post, feedTwo.Post) != 0)
				{
					return false;
				}
				if (string.Compare(feedOne.Feed, feedTwo.Feed) != 0)
				{
					return false;
				}
				return true;
			}
			return false;
		}

		public AtomFeed CreateBatchFeed(GDataBatchOperationType defaultOperation)
		{
			AtomFeed result = null;
			if (Batch != null)
			{
				result = new AtomFeed(this);
				result.BatchData = new GDataBatchFeedData();
				result.BatchData.Type = defaultOperation;
				int num = 1;
				{
					foreach (AtomEntry entry in Entries)
					{
						if (entry.Dirty)
						{
							AtomEntry atomEntry = result.Entries.CopyOrMove(entry);
							atomEntry.BatchData = new GDataBatchEntryData();
							atomEntry.BatchData.Id = num.ToString(CultureInfo.InvariantCulture);
							num++;
							entry.Dirty = false;
						}
					}
					return result;
				}
			}
			return result;
		}

		protected override void AddOtherNamespaces(XmlWriter writer)
		{
			base.AddOtherNamespaces(writer);
			if (BatchData != null)
			{
				Utilities.EnsureGDataBatchNamespace(writer);
			}
		}

		protected override bool SkipNode(XmlNode node)
		{
			if (base.SkipNode(node))
			{
				return true;
			}
			if (BatchData != null && node.NodeType == XmlNodeType.Attribute && node.Name.StartsWith("xmlns") && string.Compare(node.Value, "http://schemas.google.com/gdata/batch") == 0)
			{
				return true;
			}
			return false;
		}

		protected override void SaveInnerXml(XmlWriter writer)
		{
			base.SaveInnerXml(writer);
			if (gdataBatchFeedData_0 != null)
			{
				gdataBatchFeedData_0.Save(writer);
			}
			foreach (AtomEntry entry in Entries)
			{
				entry.SaveToXml(writer);
			}
		}

		public void Parse(Stream stream, AlternativeFormat format)
		{
			BaseFeedParser baseFeedParser = null;
			base.Authors.Clear();
			base.Contributors.Clear();
			base.Links.Clear();
			base.Categories.Clear();
			baseFeedParser = new AtomFeedParser(this);
			baseFeedParser.NewAtomEntry += OnParsedNewEntry;
			baseFeedParser.NewExtensionElement += OnNewExtensionElement;
			baseFeedParser.Parse(stream, this);
		}

		protected void OnParsedNewEntry(object sender, FeedParserEventArgs e)
		{
			if (e == null)
			{
				throw new ArgumentNullException("e");
			}
			if (feedParserEventHandler_0 != null)
			{
				feedParserEventHandler_0(this, e);
			}
			if (!e.DiscardEntry)
			{
				if (!e.CreatingEntry)
				{
					if (e.Entry != null)
					{
						e.Entry.Service = Service;
						Entries.Add(e.Entry);
					}
					else if (e.Feed == null)
					{
					}
				}
				else
				{
					IVersionAware entry = e.Entry;
					if (entry != null)
					{
						entry.ProtocolMajor = base.ProtocolMajor;
						entry.ProtocolMinor = base.ProtocolMinor;
					}
				}
			}
			if (e.DoneParsing)
			{
				BaseUriChanged(base.ImpliedBase);
			}
		}

		protected void OnNewExtensionElement(object sender, ExtensionElementEventArgs e)
		{
			if (e == null)
			{
				throw new ArgumentNullException("e");
			}
			if (extensionElementEventHandler_0 != null)
			{
				extensionElementEventHandler_0(sender, e);
			}
		}

		internal override void BaseUriChanged(AtomUri uriBase)
		{
			base.BaseUriChanged(uriBase);
			uriBase = new AtomUri(Utilities.smethod_1(base.Base, uriBase, null));
			foreach (AtomEntry entry in Entries)
			{
				entry.BaseUriChanged(uriBase);
			}
		}

		public TEntry Insert<TEntry>(TEntry newEntry)
		{
			if (newEntry == null)
			{
				throw new ArgumentNullException("newEntry");
			}
			AtomEntry atomEntry = null;
			if (((AtomEntry)newEntry).Feed == this)
			{
				throw new ArgumentException("The entry is already part of this colleciton");
			}
			if (((AtomEntry)newEntry).Feed == null)
			{
				((AtomEntry)newEntry).method_3(this);
			}
			else if (!IsFeedIdentical(((AtomEntry)newEntry).Feed, this))
			{
				AtomEntry atomEntry2 = AtomEntry.ImportFromFeed((AtomEntry)(object)newEntry);
				newEntry = (TEntry)(object)((atomEntry2 is TEntry) ? atomEntry2 : null);
				((AtomEntry)newEntry).method_3(this);
			}
			if (Service != null)
			{
				atomEntry = Service.Insert(this, (AtomEntry)(object)newEntry);
			}
			return (TEntry)(object)((atomEntry is TEntry) ? atomEntry : null);
		}

		public virtual void Publish()
		{
			if (Service != null)
			{
				for (int i = 0; i < Entries.Count; i++)
				{
					AtomEntry atomEntry = Entries[i];
					if (atomEntry.IsDirty())
					{
						if (atomEntry.Id.Uri == null)
						{
							Entries[i] = Service.Insert(this, atomEntry);
						}
						else
						{
							atomEntry.Update();
						}
					}
				}
			}
			method_0(A_0: false);
		}

		public override bool WalkTree(IBaseWalkerAction action)
		{
			if (base.WalkTree(action))
			{
				return true;
			}
			foreach (AtomEntry entry in Entries)
			{
				if (entry.WalkTree(action))
				{
					return true;
				}
			}
			return false;
		}

		protected void OnNewExtensionsElement(object sender, ExtensionElementEventArgs e)
		{
			if (e == null)
			{
				throw new ArgumentNullException("e");
			}
			AtomFeedParser parser = sender as AtomFeedParser;
			if (e.Base.XmlName == "entry")
			{
				(e.Base as AtomEntry)?.Parse(e, parser);
			}
			else
			{
				HandleExtensionElements(e, parser);
			}
		}

		protected virtual void HandleExtensionElements(ExtensionElementEventArgs e, AtomFeedParser parser)
		{
			XmlNode extensionElement = e.ExtensionElement;
			if (base.ExtensionFactories == null || base.ExtensionFactories.Count <= 0)
			{
				return;
			}
			foreach (IExtensionElementFactory extensionFactory in base.ExtensionFactories)
			{
				if (string.Compare(extensionElement.NamespaceURI, extensionFactory.XmlNameSpace, ignoreCase: true, CultureInfo.InvariantCulture) == 0 && string.Compare(extensionElement.LocalName, extensionFactory.XmlName, ignoreCase: true, CultureInfo.InvariantCulture) == 0)
				{
					e.Base.ExtensionElements.Add(extensionFactory.CreateInstance(extensionElement, parser));
					e.DiscardEntry = true;
					break;
				}
			}
		}
	}
}
