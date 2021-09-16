namespace Google.GData.Client
{
	public class AtomParserNameTable : BaseNameTable
	{
		public const string XmlCategoryElement = "category";

		public const string XmlContentElement = "content";

		public const string XmlAtomEntryElement = "entry";

		public const string XmlGeneratorElement = "generator";

		public const string XmlIconElement = "icon";

		public const string XmlLogoElement = "logo";

		public const string XmlIdElement = "id";

		public const string XmlLinkElement = "link";

		public const string XmlFeedElement = "feed";

		public const string XmlAuthorElement = "author";

		public const string XmlContributorElement = "contributor";

		public const string XmlSourceElement = "source";

		public const string XmlRightsElement = "rights";

		public const string XmlSubtitleElement = "subtitle";

		public const string XmlTitleElement = "title";

		public const string XmlSummaryElement = "summary";

		public const string XmlUpdatedElement = "updated";

		public const string XmlEmailElement = "email";

		public const string XmlUriElement = "uri";

		public const string XmlPublishedElement = "published";

		public const string XmlAttributeTerm = "term";

		public const string XmlAttributeScheme = "scheme";

		public const string XmlAttributeLabel = "label";

		public const string XmlAttributeVersion = "version";

		public const string XmlAttributeLength = "length";

		public const string XmlAttributeRel = "rel";

		public const string XmlAttributeHRefLang = "hreflang";

		public const string XmlAttributeHRef = "href";

		public const string XmlAttributeSrc = "src";

		public const string XmlCategoriesElement = "categories";

		private object object_23;

		private object object_24;

		private object object_25;

		private object object_26;

		private object object_27;

		private object object_28;

		private object object_29;

		private object object_30;

		private object object_31;

		private object object_32;

		private object object_33;

		private object object_34;

		private object object_35;

		private object object_36;

		private object object_37;

		private object object_38;

		private object object_39;

		private object object_40;

		private object object_41;

		private object object_42;

		private object object_43;

		private object object_44;

		private object object_45;

		private object object_46;

		private object object_47;

		private object object_48;

		private object object_49;

		private object object_50;

		private object object_51;

		private object object_52;

		public object Feed => object_23;

		public object Categories => object_52;

		public object Version => object_24;

		public object Source => object_46;

		public object Entry => object_47;

		public object Title => object_25;

		public object Link => object_27;

		public object Id => object_26;

		public object HRef => object_28;

		public object Rel => object_29;

		public object HRefLang => object_30;

		public object Length => object_31;

		public object Category => object_37;

		public object Updated => object_32;

		public object Published => object_33;

		public object Author => object_34;

		public object Contributor => object_35;

		public object Rights => object_36;

		public object Term => object_38;

		public object Scheme => object_39;

		public object Label => object_40;

		public object Summary => object_41;

		public object Content => object_42;

		public object Src => object_43;

		public object Subtitle => object_44;

		public object Uri => object_48;

		public object Generator => object_45;

		public object Email => object_49;

		public object Icon => object_50;

		public object Logo => object_51;

		public override void InitAtomParserNameTable()
		{
			base.InitAtomParserNameTable();
			object_23 = base.Nametable.Add("feed");
			object_24 = base.Nametable.Add("version");
			object_46 = base.Nametable.Add("source");
			object_47 = base.Nametable.Add("entry");
			object_25 = base.Nametable.Add("title");
			object_27 = base.Nametable.Add("link");
			object_26 = base.Nametable.Add("id");
			object_28 = base.Nametable.Add("href");
			object_29 = base.Nametable.Add("rel");
			object_30 = base.Nametable.Add("hreflang");
			object_31 = base.Nametable.Add("length");
			object_32 = base.Nametable.Add("updated");
			object_33 = base.Nametable.Add("published");
			object_34 = base.Nametable.Add("author");
			object_35 = base.Nametable.Add("contributor");
			object_36 = base.Nametable.Add("rights");
			object_37 = base.Nametable.Add("category");
			object_38 = base.Nametable.Add("term");
			object_39 = base.Nametable.Add("scheme");
			object_40 = base.Nametable.Add("label");
			object_41 = base.Nametable.Add("summary");
			object_42 = base.Nametable.Add("content");
			object_43 = base.Nametable.Add("src");
			object_48 = base.Nametable.Add("uri");
			object_45 = base.Nametable.Add("generator");
			object_49 = base.Nametable.Add("email");
			object_50 = base.Nametable.Add("icon");
			object_51 = base.Nametable.Add("logo");
			object_44 = base.Nametable.Add("subtitle");
			object_52 = base.Nametable.Add("categories");
		}
	}
}
