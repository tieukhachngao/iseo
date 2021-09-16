using System;
using System.ComponentModel;
using System.Xml;

namespace Google.GData.Client
{
	[TypeConverter(typeof(AtomSourceConverter))]
	[Description("Expand to see the options for the feed")]
	public class AtomSource : AtomBase
	{
		private AtomPersonCollection atomPersonCollection_0;

		private AtomPersonCollection atomPersonCollection_1;

		private AtomCategoryCollection atomCategoryCollection_0;

		private AtomGenerator atomGenerator_0;

		private AtomIcon atomIcon_0;

		private AtomId atomId_0;

		private AtomLinkCollection atomLinkCollection_0;

		private AtomLogo atomLogo_0;

		private AtomTextConstruct atomTextConstruct_0;

		private AtomTextConstruct atomTextConstruct_1;

		private AtomTextConstruct atomTextConstruct_2;

		private DateTime dateTime_0;

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

		public AtomGenerator Generator
		{
			get
			{
				return atomGenerator_0;
			}
			set
			{
				base.Dirty = true;
				atomGenerator_0 = value;
			}
		}

		public AtomIcon Icon
		{
			get
			{
				return atomIcon_0;
			}
			set
			{
				base.Dirty = true;
				atomIcon_0 = value;
			}
		}

		public AtomLogo Logo
		{
			get
			{
				return atomLogo_0;
			}
			set
			{
				base.Dirty = true;
				atomLogo_0 = value;
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

		public AtomTextConstruct Title
		{
			get
			{
				return atomTextConstruct_2;
			}
			set
			{
				base.Dirty = true;
				atomTextConstruct_2 = value;
			}
		}

		public AtomTextConstruct Subtitle
		{
			get
			{
				return atomTextConstruct_1;
			}
			set
			{
				base.Dirty = true;
				atomTextConstruct_1 = value;
			}
		}

		public AtomId Id
		{
			get
			{
				return atomId_0;
			}
			set
			{
				base.Dirty = true;
				atomId_0 = value;
			}
		}

		public AtomTextConstruct Rights
		{
			get
			{
				return atomTextConstruct_0;
			}
			set
			{
				base.Dirty = true;
				atomTextConstruct_0 = value;
			}
		}

		public override string XmlName => "source";

		public AtomSource()
		{
		}

		public AtomSource(AtomFeed feed)
			: this()
		{
			if (feed == null)
			{
				throw new ArgumentNullException("feed");
			}
			atomPersonCollection_0 = feed.Authors;
			atomPersonCollection_1 = feed.Contributors;
			atomCategoryCollection_0 = feed.Categories;
			Generator = feed.Generator;
			Icon = feed.Icon;
			Logo = feed.Logo;
			Id = feed.Id;
			atomLinkCollection_0 = feed.Links;
			Rights = feed.Rights;
			Subtitle = feed.Subtitle;
			Title = feed.Title;
			Updated = feed.Updated;
		}

		protected override void SaveInnerXml(XmlWriter writer)
		{
			base.SaveInnerXml(writer);
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
			if (Generator != null)
			{
				Generator.SaveToXml(writer);
			}
			if (Icon != null)
			{
				Icon.SaveToXml(writer);
			}
			if (Logo != null)
			{
				Logo.SaveToXml(writer);
			}
			if (Id != null)
			{
				Id.SaveToXml(writer);
			}
			foreach (AtomLink link in Links)
			{
				link.SaveToXml(writer);
			}
			if (Rights != null)
			{
				Rights.SaveToXml(writer);
			}
			if (Subtitle != null)
			{
				Subtitle.SaveToXml(writer);
			}
			if (Title != null)
			{
				Title.SaveToXml(writer);
			}
			WriteLocalDateTimeElement(writer, "updated", Updated);
		}

		internal override void BaseUriChanged(AtomUri uriBase)
		{
			base.BaseUriChanged(uriBase);
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
			if (Generator != null)
			{
				Generator.BaseUriChanged(uriBase);
			}
			if (Icon != null)
			{
				Icon.BaseUriChanged(uriBase);
			}
			if (Logo != null)
			{
				Logo.BaseUriChanged(uriBase);
			}
			if (Id != null)
			{
				Id.BaseUriChanged(uriBase);
			}
			foreach (AtomLink link in Links)
			{
				link.BaseUriChanged(uriBase);
			}
			if (Rights != null)
			{
				Rights.BaseUriChanged(uriBase);
			}
			if (Subtitle != null)
			{
				Subtitle.BaseUriChanged(uriBase);
			}
			if (Title != null)
			{
				Title.BaseUriChanged(uriBase);
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
			if (Generator != null && Generator.WalkTree(action))
			{
				return true;
			}
			if (Icon != null && Icon.WalkTree(action))
			{
				return true;
			}
			if (Logo != null && Logo.WalkTree(action))
			{
				return true;
			}
			if (Id != null && Id.WalkTree(action))
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
			if (Rights != null && Rights.WalkTree(action))
			{
				return true;
			}
			if (Subtitle != null && Subtitle.WalkTree(action))
			{
				return true;
			}
			if (Title != null && Title.WalkTree(action))
			{
				return true;
			}
			return false;
		}
	}
}
