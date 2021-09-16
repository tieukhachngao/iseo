using System;
using System.ComponentModel;
using System.Xml;
using Google.GData.Extensions.AppControl;

namespace Google.GData.Client
{
	[Description("Expand to see the entry objects for the feed.")]
	[TypeConverter(typeof(AtomEntryConverter))]
	public class AtomEntry : AtomBase
	{
		private AtomTextConstruct atomTextConstruct_0;

		private AtomId atomId_0;

		private AtomLinkCollection atomLinkCollection_0;

		private DateTime dateTime_0;

		private DateTime dateTime_1;

		private AtomPersonCollection atomPersonCollection_0;

		private AtomPersonCollection atomPersonCollection_1;

		private AtomTextConstruct atomTextConstruct_1;

		private AtomCategoryCollection atomCategoryCollection_0;

		private AtomTextConstruct atomTextConstruct_2;

		private AtomContent atomContent_0;

		private AtomSource atomSource_0;

		private IService iservice_0;

		private AtomFeed atomFeed_0;

		private GDataBatchEntryData gdataBatchEntryData_0;

		public override string XmlName => "entry";

		public AtomFeed Feed => atomFeed_0;

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

		public GDataBatchEntryData BatchData
		{
			get
			{
				return gdataBatchEntryData_0;
			}
			set
			{
				gdataBatchEntryData_0 = value;
			}
		}

		public AtomUri EditUri
		{
			get
			{
				return Links.FindService("edit", "application/atom+xml")?.HRef;
			}
			set
			{
				AtomLink atomLink = Links.FindService("edit", "application/atom+xml");
				if (atomLink == null)
				{
					atomLink = new AtomLink("application/atom+xml", "edit");
					Links.Add(atomLink);
				}
				atomLink.HRef = value;
			}
		}

		public AtomUri SelfUri
		{
			get
			{
				return Links.FindService("self", "application/atom+xml")?.HRef;
			}
			set
			{
				AtomLink atomLink = Links.FindService("self", "application/atom+xml");
				if (atomLink == null)
				{
					atomLink = new AtomLink("application/atom+xml", "self");
					Links.Add(atomLink);
				}
				atomLink.HRef = value;
			}
		}

		public AtomUri MediaUri
		{
			get
			{
				return Links.FindService("edit-media", null)?.HRef;
			}
			set
			{
				AtomLink atomLink = Links.FindService("edit-media", null);
				if (atomLink == null)
				{
					atomLink = new AtomLink(null, "edit-media");
					Links.Add(atomLink);
				}
				atomLink.HRef = value;
			}
		}

		public AtomUri AlternateUri
		{
			get
			{
				return Links.FindService("alternate", "text/html")?.HRef;
			}
			set
			{
				AtomLink atomLink = Links.FindService("alternate", "text/html");
				if (atomLink == null)
				{
					atomLink = new AtomLink("text/html", "alternate");
					Links.Add(atomLink);
				}
				atomLink.HRef = value;
			}
		}

		public string FeedUri
		{
			get
			{
				AtomLink atomLink = Links.FindService("http://schemas.google.com/g/2005#feed", "application/atom+xml");
				if (atomLink != null)
				{
					return Utilities.smethod_1(base.Base, base.ImpliedBase, atomLink.HRef.ToString());
				}
				return null;
			}
			set
			{
				AtomLink atomLink = Links.FindService("http://schemas.google.com/g/2005#feed", "application/atom+xml");
				if (atomLink == null)
				{
					atomLink = new AtomLink("application/atom+xml", "http://schemas.google.com/g/2005#feed");
					Links.Add(atomLink);
				}
				atomLink.HRef = new AtomUri(value);
			}
		}

		public DateTime Updated
		{
			get
			{
				return dateTime_0;
			}
			set
			{
				base.Dirty = true;
				dateTime_0 = value;
			}
		}

		public DateTime Published
		{
			get
			{
				return dateTime_1;
			}
			set
			{
				base.Dirty = true;
				dateTime_1 = value;
			}
		}

		public AppControl AppControl
		{
			get
			{
				return FindExtension("control", BaseNameTable.AppPublishingNamespace(this)) as AppControl;
			}
			set
			{
				ReplaceExtension("control", BaseNameTable.AppPublishingNamespace(this), value);
			}
		}

		public bool IsDraft
		{
			get
			{
				if (AppControl != null && AppControl.Draft != null)
				{
					return AppControl.Draft.BooleanValue;
				}
				return false;
			}
			set
			{
				base.Dirty = true;
				if (AppControl == null)
				{
					AppControl = new AppControl();
				}
				if (AppControl.Draft == null)
				{
					AppControl.Draft = new AppDraft();
				}
				AppControl.Draft.BooleanValue = value;
			}
		}

		public AtomPersonCollection Authors
		{
			get
			{
				if (atomPersonCollection_0 == null)
				{
					atomPersonCollection_0 = new AtomPersonCollection();
				}
				return atomPersonCollection_0;
			}
		}

		public AtomPersonCollection Contributors
		{
			get
			{
				if (atomPersonCollection_1 == null)
				{
					atomPersonCollection_1 = new AtomPersonCollection();
				}
				return atomPersonCollection_1;
			}
		}

		public AtomContent Content
		{
			get
			{
				if (atomContent_0 == null)
				{
					atomContent_0 = new AtomContent();
				}
				return atomContent_0;
			}
			set
			{
				base.Dirty = true;
				atomContent_0 = value;
			}
		}

		public AtomTextConstruct Summary
		{
			get
			{
				if (atomTextConstruct_2 == null)
				{
					atomTextConstruct_2 = new AtomTextConstruct(AtomTextConstructElementType.Summary);
				}
				return atomTextConstruct_2;
			}
			set
			{
				base.Dirty = true;
				atomTextConstruct_2 = value;
			}
		}

		public AtomLinkCollection Links
		{
			get
			{
				if (atomLinkCollection_0 == null)
				{
					atomLinkCollection_0 = new AtomLinkCollection();
				}
				return atomLinkCollection_0;
			}
		}

		public AtomCategoryCollection Categories
		{
			get
			{
				if (atomCategoryCollection_0 == null)
				{
					atomCategoryCollection_0 = new AtomCategoryCollection();
				}
				return atomCategoryCollection_0;
			}
		}

		public AtomId Id
		{
			get
			{
				if (atomId_0 == null)
				{
					atomId_0 = new AtomId();
				}
				return atomId_0;
			}
			set
			{
				base.Dirty = true;
				atomId_0 = value;
			}
		}

		public AtomTextConstruct Title
		{
			get
			{
				if (atomTextConstruct_0 == null)
				{
					atomTextConstruct_0 = new AtomTextConstruct(AtomTextConstructElementType.Title);
				}
				return atomTextConstruct_0;
			}
			set
			{
				base.Dirty = true;
				atomTextConstruct_0 = value;
			}
		}

		public AtomSource Source
		{
			get
			{
				return atomSource_0;
			}
			set
			{
				base.Dirty = true;
				AtomFeed atomFeed = value as AtomFeed;
				if (atomFeed != null)
				{
					atomSource_0 = new AtomSource(atomFeed);
				}
				else
				{
					atomSource_0 = value;
				}
			}
		}

		public AtomTextConstruct Rights
		{
			get
			{
				if (atomTextConstruct_1 == null)
				{
					atomTextConstruct_1 = new AtomTextConstruct(AtomTextConstructElementType.Rights);
				}
				return atomTextConstruct_1;
			}
			set
			{
				base.Dirty = true;
				atomTextConstruct_1 = value;
			}
		}

		public bool ReadOnly => EditUri == null;

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
			if (gdataBatchEntryData_0 != null)
			{
				gdataBatchEntryData_0.Save(writer);
			}
			if (atomTextConstruct_0 != null)
			{
				Title.SaveToXml(writer);
			}
			if (atomId_0 != null)
			{
				Id.SaveToXml(writer);
			}
			foreach (AtomLink link in Links)
			{
				link.SaveToXml(writer);
			}
			foreach (AtomPerson author in Authors)
			{
				author.SaveToXml(writer);
			}
			foreach (AtomPerson contributor in Contributors)
			{
				contributor.SaveToXml(writer);
			}
			foreach (AtomCategory category in Categories)
			{
				category.SaveToXml(writer);
			}
			if (atomTextConstruct_1 != null)
			{
				Rights.SaveToXml(writer);
			}
			if (atomTextConstruct_2 != null)
			{
				Summary.SaveToXml(writer);
			}
			if (atomContent_0 != null)
			{
				Content.SaveToXml(writer);
			}
			if (atomSource_0 != null)
			{
				Source.SaveToXml(writer);
			}
			WriteLocalDateTimeElement(writer, "updated", Updated);
			WriteLocalDateTimeElement(writer, "published", Published);
		}

		public AtomEntry()
		{
			AddExtension(new AppControl());
		}

		internal void method_3(AtomFeed A_0)
		{
			if (A_0 != null)
			{
				base.Dirty = true;
				Service = A_0.Service;
			}
			atomFeed_0 = A_0;
		}

		public static AtomEntry ImportFromFeed(AtomEntry entryToImport)
		{
			if (entryToImport == null)
			{
				throw new ArgumentNullException("entryToImport");
			}
			AtomEntry atomEntry = null;
			atomEntry = (AtomEntry)Activator.CreateInstance(entryToImport.GetType());
			atomEntry.CopyEntry(entryToImport);
			atomEntry.Id = null;
			if (atomEntry.Source == null)
			{
				atomEntry.Source = entryToImport.Feed;
			}
			return atomEntry;
		}

		public AtomEntry Update()
		{
			if (Service == null)
			{
				throw new InvalidOperationException("No Service object set");
			}
			AtomEntry atomEntry = Service.Update(this);
			if (atomEntry != null)
			{
				CopyEntry(atomEntry);
				method_0(A_0: false);
				return atomEntry;
			}
			return null;
		}

		public void Delete()
		{
			if (Service == null)
			{
				throw new InvalidOperationException("No Service object set");
			}
			Service.Delete(this);
		}

		protected void CopyEntry(AtomEntry updatedEntry)
		{
			if (updatedEntry == null)
			{
				throw new ArgumentNullException("updatedEntry");
			}
			atomTextConstruct_0 = updatedEntry.Title;
			atomPersonCollection_0 = updatedEntry.Authors;
			atomId_0 = updatedEntry.Id;
			atomLinkCollection_0 = updatedEntry.Links;
			dateTime_0 = updatedEntry.Updated;
			dateTime_1 = updatedEntry.Published;
			atomPersonCollection_0 = updatedEntry.Authors;
			atomTextConstruct_1 = updatedEntry.Rights;
			atomCategoryCollection_0 = updatedEntry.Categories;
			atomTextConstruct_2 = updatedEntry.Summary;
			atomContent_0 = updatedEntry.Content;
			atomSource_0 = updatedEntry.Source;
			base.ExtensionElements.Clear();
			foreach (IExtensionElementFactory extensionElement in updatedEntry.ExtensionElements)
			{
				base.ExtensionElements.Add(extensionElement);
			}
		}

		public override AtomBase CreateAtomSubElement(XmlReader reader, AtomFeedParser parser)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			if (parser == null)
			{
				throw new ArgumentNullException("parser");
			}
			object localName = reader.LocalName;
			if (localName.Equals(parser.Nametable.Source))
			{
				return new AtomSource();
			}
			if (localName.Equals(parser.Nametable.Content))
			{
				return new AtomContent();
			}
			return base.CreateAtomSubElement(reader, parser);
		}

		internal override void BaseUriChanged(AtomUri uriBase)
		{
			base.BaseUriChanged(uriBase);
			uriBase = new AtomUri(Utilities.smethod_1(base.Base, uriBase, null));
			if (Title != null)
			{
				Title.BaseUriChanged(uriBase);
			}
			if (Id != null)
			{
				Id.BaseUriChanged(uriBase);
			}
			foreach (AtomLink link in Links)
			{
				link.BaseUriChanged(uriBase);
			}
			foreach (AtomPerson author in Authors)
			{
				author.BaseUriChanged(uriBase);
			}
			foreach (AtomPerson contributor in Contributors)
			{
				contributor.BaseUriChanged(uriBase);
			}
			foreach (AtomCategory category in Categories)
			{
				category.BaseUriChanged(uriBase);
			}
			if (Rights != null)
			{
				Rights.BaseUriChanged(uriBase);
			}
			if (Summary != null)
			{
				Summary.BaseUriChanged(uriBase);
			}
			if (Content != null)
			{
				Content.BaseUriChanged(uriBase);
			}
			if (Source != null)
			{
				Source.BaseUriChanged(uriBase);
			}
		}

		public override bool WalkTree(IBaseWalkerAction action)
		{
			if (base.WalkTree(action))
			{
				return true;
			}
			foreach (AtomPerson author in Authors)
			{
				if (author.WalkTree(action))
				{
					return true;
				}
			}
			foreach (AtomPerson contributor in Contributors)
			{
				if (contributor.WalkTree(action))
				{
					return true;
				}
			}
			foreach (AtomCategory category in Categories)
			{
				if (category.WalkTree(action))
				{
					return true;
				}
			}
			if (atomId_0 != null && atomId_0.WalkTree(action))
			{
				return true;
			}
			foreach (AtomLink link in Links)
			{
				if (link.WalkTree(action))
				{
					return true;
				}
			}
			if (atomTextConstruct_1 != null && atomTextConstruct_1.WalkTree(action))
			{
				return true;
			}
			if (atomTextConstruct_0 != null && atomTextConstruct_0.WalkTree(action))
			{
				return true;
			}
			if (atomTextConstruct_2 != null && atomTextConstruct_2.WalkTree(action))
			{
				return true;
			}
			if (atomContent_0 != null && atomContent_0.WalkTree(action))
			{
				return true;
			}
			if (atomSource_0 != null && atomSource_0.WalkTree(action))
			{
				return true;
			}
			return false;
		}

		public virtual void Parse(ExtensionElementEventArgs e, AtomFeedParser parser)
		{
			if (e == null)
			{
				throw new ArgumentNullException("e");
			}
			XmlNode extensionElement = e.ExtensionElement;
			if (base.ExtensionFactories != null && base.ExtensionFactories.Count > 0)
			{
				IExtensionElementFactory extensionElementFactory = FindExtensionFactory(extensionElement.LocalName, extensionElement.NamespaceURI);
				if (extensionElementFactory != null)
				{
					base.ExtensionElements.Add(extensionElementFactory.CreateInstance(extensionElement, parser));
					e.DiscardEntry = true;
				}
			}
		}
	}
}
