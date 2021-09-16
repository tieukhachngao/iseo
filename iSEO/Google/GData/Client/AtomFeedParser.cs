using System;
using System.Globalization;
using System.IO;
using System.Xml;

namespace Google.GData.Client
{
	public class AtomFeedParser : BaseFeedParser
	{
		private AtomParserNameTable atomParserNameTable_0;

		private Class59 class59_0 = new Class59();

		public AtomParserNameTable Nametable => atomParserNameTable_0;

		public AtomFeedParser()
		{
			atomParserNameTable_0 = new AtomParserNameTable();
			atomParserNameTable_0.InitAtomParserNameTable();
		}

		public AtomFeedParser(IVersionAware v)
		{
			atomParserNameTable_0 = new AtomParserNameTable();
			atomParserNameTable_0.InitAtomParserNameTable();
			class59_0 = new Class59(v);
		}

		public override void Parse(Stream streamInput, AtomFeed feed)
		{
			try
			{
				XmlReader reader = new XmlTextReader(streamInput, atomParserNameTable_0.Nametable);
				BaseFeedParser.MoveToStartElement(reader);
				ParseFeed(reader, feed);
			}
			catch (Exception innerException)
			{
				throw new ClientFeedException("Parsing failed", innerException);
			}
		}

		public AtomCategoryCollection ParseCategories(XmlReader reader, AtomBase owner)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			AtomCategoryCollection atomCategoryCollection = new AtomCategoryCollection();
			BaseFeedParser.MoveToStartElement(reader);
			object localName = reader.LocalName;
			if (IsCurrentNameSpace(reader, BaseNameTable.AppPublishingNamespace(owner)) && localName.Equals(atomParserNameTable_0.Categories))
			{
				int depth = -1;
				while (BaseFeedParser.NextChildElement(reader, ref depth))
				{
					localName = reader.LocalName;
					if (IsCurrentNameSpace(reader, "http://www.w3.org/2005/Atom") && localName.Equals(atomParserNameTable_0.Category))
					{
						AtomCategory value = ParseCategory(reader, owner);
						atomCategoryCollection.Add(value);
					}
				}
				return atomCategoryCollection;
			}
			throw new ClientFeedException("An invalid Atom Document was passed to the parser. This was not an app:categories document: " + localName);
		}

		protected void ParseFeed(XmlReader reader, AtomFeed feed)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			if (feed == null)
			{
				throw new ArgumentNullException("feed");
			}
			object localName = reader.LocalName;
			if (localName.Equals(atomParserNameTable_0.Feed))
			{
				ParseSource(reader, feed);
				OnNewAtomEntry(feed);
			}
			else if (localName.Equals(atomParserNameTable_0.Entry))
			{
				ParseEntry(reader);
			}
			OnParsingDone();
			feed.method_0(A_0: false);
		}

		protected void ParseSource(XmlReader reader, AtomSource source)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			int depth = -1;
			ParseBasicAttributes(reader, source);
			while (BaseFeedParser.NextChildElement(reader, ref depth))
			{
				object localName = reader.LocalName;
				AtomFeed atomFeed = source as AtomFeed;
				if (IsCurrentNameSpace(reader, "http://www.w3.org/2005/Atom"))
				{
					if (localName.Equals(atomParserNameTable_0.Title))
					{
						source.Title = ParseTextConstruct(reader, source);
					}
					else if (localName.Equals(atomParserNameTable_0.Updated))
					{
						source.Updated = DateTime.Parse(Utilities.DecodedValue(reader.ReadString()), CultureInfo.InvariantCulture);
					}
					else if (localName.Equals(atomParserNameTable_0.Link))
					{
						source.Links.Add(ParseLink(reader, source));
					}
					else if (localName.Equals(atomParserNameTable_0.Id))
					{
						source.Id = source.CreateAtomSubElement(reader, this) as AtomId;
						ParseBaseLink(reader, source.Id);
					}
					else if (localName.Equals(atomParserNameTable_0.Icon))
					{
						source.Icon = source.CreateAtomSubElement(reader, this) as AtomIcon;
						ParseBaseLink(reader, source.Icon);
					}
					else if (localName.Equals(atomParserNameTable_0.Logo))
					{
						source.Logo = source.CreateAtomSubElement(reader, this) as AtomLogo;
						ParseBaseLink(reader, source.Logo);
					}
					else if (localName.Equals(atomParserNameTable_0.Author))
					{
						source.Authors.Add(ParsePerson(reader, source));
					}
					else if (localName.Equals(atomParserNameTable_0.Contributor))
					{
						source.Contributors.Add(ParsePerson(reader, source));
					}
					else if (localName.Equals(atomParserNameTable_0.Subtitle))
					{
						source.Subtitle = ParseTextConstruct(reader, source);
					}
					else if (localName.Equals(atomParserNameTable_0.Rights))
					{
						source.Rights = ParseTextConstruct(reader, source);
					}
					else if (localName.Equals(atomParserNameTable_0.Generator))
					{
						source.Generator = ParseGenerator(reader, source);
					}
					else if (localName.Equals(atomParserNameTable_0.Category))
					{
						source.Categories.Add(ParseCategory(reader, source));
					}
					else if (atomFeed != null && localName.Equals(atomParserNameTable_0.Entry))
					{
						ParseEntry(reader);
					}
					reader.Read();
				}
				else if (atomFeed != null && IsCurrentNameSpace(reader, "http://schemas.google.com/gdata/batch"))
				{
					ParseBatch(reader, atomFeed);
				}
				else if (atomFeed != null && IsCurrentNameSpace(reader, BaseNameTable.OpenSearchNamespace(class59_0)))
				{
					if (localName.Equals(atomParserNameTable_0.TotalResults))
					{
						atomFeed.TotalResults = int.Parse(Utilities.DecodedValue(reader.ReadString()), CultureInfo.InvariantCulture);
					}
					else if (localName.Equals(atomParserNameTable_0.StartIndex))
					{
						atomFeed.StartIndex = int.Parse(Utilities.DecodedValue(reader.ReadString()), CultureInfo.InvariantCulture);
					}
					else if (localName.Equals(atomParserNameTable_0.ItemsPerPage))
					{
						atomFeed.ItemsPerPage = int.Parse(Utilities.DecodedValue(reader.ReadString()), CultureInfo.InvariantCulture);
					}
				}
				else
				{
					ParseExtensionElements(reader, source);
				}
			}
		}

		protected static bool IsCurrentNameSpace(XmlReader reader, string namespaceToCompare)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			string text = reader.NamespaceURI;
			if (text.Length == 0)
			{
				text = reader.LookupNamespace(string.Empty);
			}
			return text == namespaceToCompare;
		}

		protected bool ParseBaseAttributes(XmlReader reader, AtomBase baseObject)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			if (baseObject == null)
			{
				throw new ArgumentNullException("baseObject");
			}
			bool flag = false;
			flag = true;
			object localName = reader.LocalName;
			if (IsCurrentNameSpace(reader, "http://www.w3.org/XML/1998/namespace"))
			{
				if (localName.Equals(atomParserNameTable_0.Base))
				{
					baseObject.Base = new AtomUri(reader.Value);
					flag = false;
				}
				else if (localName.Equals(atomParserNameTable_0.Language))
				{
					baseObject.Language = Utilities.DecodedValue(reader.Value);
					flag = false;
				}
			}
			else if (IsCurrentNameSpace(reader, "http://schemas.google.com/g/2005"))
			{
				ISupportsEtag supportsEtag = baseObject as ISupportsEtag;
				if (supportsEtag != null && localName.Equals(atomParserNameTable_0.ETag))
				{
					supportsEtag.Etag = reader.Value;
					flag = false;
				}
			}
			if (flag)
			{
				OnNewExtensionElement(reader, baseObject);
			}
			return flag;
		}

		protected void ParseExtensionElements(XmlReader reader, AtomBase baseObject)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader", "No XmlReader supplied");
			}
			if (baseObject == null)
			{
				throw new ArgumentNullException("baseObject", "No baseObject supplied");
			}
			if (!IsCurrentNameSpace(reader, "http://www.w3.org/2005/Atom"))
			{
				OnNewExtensionElement(reader, baseObject);
				reader.MoveToElement();
			}
		}

		protected void ParseBasicAttributes(XmlReader reader, AtomBase baseObject)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			if (baseObject == null)
			{
				throw new ArgumentNullException("baseObject");
			}
			if (reader.NodeType == XmlNodeType.Element && reader.HasAttributes)
			{
				while (reader.MoveToNextAttribute())
				{
					ParseBaseAttributes(reader, baseObject);
				}
				reader.MoveToElement();
			}
		}

		protected void ParseBaseLink(XmlReader reader, AtomBaseLink baseLink)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			if (baseLink == null)
			{
				throw new ArgumentNullException("baseLink");
			}
			ParseBasicAttributes(reader, baseLink);
			if (reader.NodeType == XmlNodeType.Element)
			{
				baseLink.Uri = new AtomUri(Utilities.DecodedValue(reader.ReadString()));
			}
		}

		protected AtomPerson ParsePerson(XmlReader reader, AtomBase owner)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			if (owner == null)
			{
				throw new ArgumentNullException("owner");
			}
			object obj = null;
			AtomPerson atomPerson = owner.CreateAtomSubElement(reader, this) as AtomPerson;
			ParseBasicAttributes(reader, atomPerson);
			int depth = -1;
			while (BaseFeedParser.NextChildElement(reader, ref depth))
			{
				obj = reader.LocalName;
				if (obj.Equals(atomParserNameTable_0.Name))
				{
					atomPerson.Name = Utilities.DecodedValue(reader.ReadString());
					reader.Read();
				}
				else if (obj.Equals(atomParserNameTable_0.Uri))
				{
					atomPerson.Uri = new AtomUri(Utilities.DecodedValue(reader.ReadString()));
					reader.Read();
				}
				else if (obj.Equals(atomParserNameTable_0.Email))
				{
					atomPerson.Email = Utilities.DecodedValue(reader.ReadString());
					reader.Read();
				}
				else
				{
					ParseExtensionElements(reader, atomPerson);
				}
			}
			return atomPerson;
		}

		protected AtomCategory ParseCategory(XmlReader reader, AtomBase owner)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			if (owner == null)
			{
				throw new ArgumentNullException("owner");
			}
			AtomCategory atomCategory = owner.CreateAtomSubElement(reader, this) as AtomCategory;
			if (atomCategory != null)
			{
				bool isEmptyElement = reader.IsEmptyElement;
				if (reader.HasAttributes)
				{
					while (reader.MoveToNextAttribute())
					{
						object localName = reader.LocalName;
						if (localName.Equals(atomParserNameTable_0.Term))
						{
							atomCategory.Term = Utilities.DecodedValue(reader.Value);
						}
						else if (localName.Equals(atomParserNameTable_0.Scheme))
						{
							atomCategory.Scheme = new AtomUri(reader.Value);
						}
						else if (localName.Equals(atomParserNameTable_0.Label))
						{
							atomCategory.Label = Utilities.DecodedValue(reader.Value);
						}
						else
						{
							ParseBaseAttributes(reader, atomCategory);
						}
					}
				}
				if (!isEmptyElement)
				{
					reader.MoveToElement();
					int depth = -1;
					while (BaseFeedParser.NextChildElement(reader, ref depth))
					{
						ParseExtensionElements(reader, atomCategory);
					}
				}
			}
			return atomCategory;
		}

		protected AtomLink ParseLink(XmlReader reader, AtomBase owner)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			if (owner == null)
			{
				throw new ArgumentNullException("owner");
			}
			bool isEmptyElement = reader.IsEmptyElement;
			AtomLink atomLink = owner.CreateAtomSubElement(reader, this) as AtomLink;
			object obj = null;
			if (reader.HasAttributes)
			{
				while (reader.MoveToNextAttribute())
				{
					obj = reader.LocalName;
					if (obj.Equals(atomParserNameTable_0.HRef))
					{
						atomLink.HRef = new AtomUri(reader.Value);
					}
					else if (obj.Equals(atomParserNameTable_0.Rel))
					{
						atomLink.Rel = Utilities.DecodedValue(reader.Value);
					}
					else if (obj.Equals(atomParserNameTable_0.Type))
					{
						atomLink.Type = Utilities.DecodedValue(reader.Value);
					}
					else if (obj.Equals(atomParserNameTable_0.HRefLang))
					{
						atomLink.HRefLang = Utilities.DecodedValue(reader.Value);
					}
					else if (obj.Equals(atomParserNameTable_0.Title))
					{
						atomLink.Title = Utilities.DecodedValue(reader.Value);
					}
					else if (obj.Equals(atomParserNameTable_0.Length))
					{
						atomLink.Length = int.Parse(Utilities.DecodedValue(reader.Value), CultureInfo.InvariantCulture);
					}
					else
					{
						ParseBaseAttributes(reader, atomLink);
					}
				}
			}
			if (!isEmptyElement)
			{
				reader.MoveToElement();
				int depth = -1;
				while (BaseFeedParser.NextChildElement(reader, ref depth))
				{
					ParseExtensionElements(reader, atomLink);
				}
			}
			return atomLink;
		}

		public void ParseEntry(XmlReader reader)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			object localName = reader.LocalName;
			if (!localName.Equals(atomParserNameTable_0.Entry))
			{
				throw new ClientFeedException("trying to parse an atom entry, but reader is not at the right spot");
			}
			AtomEntry atomEntry = OnCreateNewEntry();
			ParseBasicAttributes(reader, atomEntry);
			int depth = -1;
			while (BaseFeedParser.NextChildElement(reader, ref depth))
			{
				localName = reader.LocalName;
				if (IsCurrentNameSpace(reader, "http://www.w3.org/2005/Atom"))
				{
					if (localName.Equals(atomParserNameTable_0.Id))
					{
						atomEntry.Id = atomEntry.CreateAtomSubElement(reader, this) as AtomId;
						ParseBaseLink(reader, atomEntry.Id);
					}
					else if (localName.Equals(atomParserNameTable_0.Link))
					{
						atomEntry.Links.Add(ParseLink(reader, atomEntry));
					}
					else if (localName.Equals(atomParserNameTable_0.Updated))
					{
						atomEntry.Updated = DateTime.Parse(Utilities.DecodedValue(reader.ReadString()), CultureInfo.InvariantCulture);
					}
					else if (localName.Equals(atomParserNameTable_0.Published))
					{
						atomEntry.Published = DateTime.Parse(Utilities.DecodedValue(reader.ReadString()), CultureInfo.InvariantCulture);
					}
					else if (localName.Equals(atomParserNameTable_0.Author))
					{
						atomEntry.Authors.Add(ParsePerson(reader, atomEntry));
					}
					else if (localName.Equals(atomParserNameTable_0.Contributor))
					{
						atomEntry.Contributors.Add(ParsePerson(reader, atomEntry));
					}
					else if (localName.Equals(atomParserNameTable_0.Rights))
					{
						atomEntry.Rights = ParseTextConstruct(reader, atomEntry);
					}
					else if (localName.Equals(atomParserNameTable_0.Category))
					{
						AtomCategory value = ParseCategory(reader, atomEntry);
						atomEntry.Categories.Add(value);
					}
					else if (localName.Equals(atomParserNameTable_0.Summary))
					{
						atomEntry.Summary = ParseTextConstruct(reader, atomEntry);
					}
					else if (localName.Equals(atomParserNameTable_0.Content))
					{
						atomEntry.Content = ParseContent(reader, atomEntry);
					}
					else if (localName.Equals(atomParserNameTable_0.Source))
					{
						atomEntry.Source = atomEntry.CreateAtomSubElement(reader, this) as AtomSource;
						ParseSource(reader, atomEntry.Source);
					}
					else if (localName.Equals(atomParserNameTable_0.Title))
					{
						atomEntry.Title = ParseTextConstruct(reader, atomEntry);
					}
					reader.Read();
				}
				else if (IsCurrentNameSpace(reader, "http://schemas.google.com/gdata/batch"))
				{
					ParseBatch(reader, atomEntry);
				}
				else
				{
					ParseExtensionElements(reader, atomEntry);
				}
			}
			OnNewAtomEntry(atomEntry);
		}

		protected void ParseBatch(XmlReader reader, AtomEntry entry)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			if (entry == null)
			{
				throw new ArgumentNullException("entry");
			}
			if (IsCurrentNameSpace(reader, "http://schemas.google.com/gdata/batch"))
			{
				object localName = reader.LocalName;
				if (entry.BatchData == null)
				{
					entry.BatchData = new GDataBatchEntryData();
				}
				GDataBatchEntryData batchData = entry.BatchData;
				if (localName.Equals(atomParserNameTable_0.BatchId))
				{
					batchData.Id = Utilities.DecodedValue(reader.ReadString());
				}
				else if (localName.Equals(atomParserNameTable_0.BatchOperation))
				{
					batchData.Type = ParseOperationType(reader);
				}
				else if (localName.Equals(atomParserNameTable_0.BatchStatus))
				{
					batchData.Status = GDataBatchStatus.ParseBatchStatus(reader, this);
				}
				else if (localName.Equals(atomParserNameTable_0.BatchInterrupt))
				{
					batchData.Interrupt = GDataBatchInterrupt.ParseBatchInterrupt(reader, this);
				}
				else
				{
					ParseExtensionElements(reader, entry);
				}
			}
		}

		protected GDataBatchOperationType ParseOperationType(XmlReader reader)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			GDataBatchOperationType result = GDataBatchOperationType.Default;
			object localName = reader.LocalName;
			if (localName.Equals(atomParserNameTable_0.BatchOperation) && reader.HasAttributes)
			{
				while (reader.MoveToNextAttribute())
				{
					localName = reader.LocalName;
					if (localName.Equals(atomParserNameTable_0.Type))
					{
						result = (GDataBatchOperationType)Enum.Parse(typeof(GDataBatchOperationType), Utilities.DecodedValue(reader.Value), ignoreCase: true);
					}
				}
			}
			return result;
		}

		protected void ParseBatch(XmlReader reader, AtomFeed feed)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			if (feed == null)
			{
				throw new ArgumentNullException("feed");
			}
			if (IsCurrentNameSpace(reader, "http://schemas.google.com/gdata/batch"))
			{
				object localName = reader.LocalName;
				if (feed.BatchData == null)
				{
					feed.BatchData = new GDataBatchFeedData();
				}
				GDataBatchFeedData batchData = feed.BatchData;
				if (localName.Equals(atomParserNameTable_0.BatchOperation))
				{
					batchData.Type = (GDataBatchOperationType)Enum.Parse(typeof(GDataBatchOperationType), reader.GetAttribute("type"), ignoreCase: true);
				}
				else
				{
					reader.Skip();
				}
			}
		}

		protected AtomTextConstruct ParseTextConstruct(XmlReader reader, AtomBase owner)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			if (owner == null)
			{
				throw new ArgumentNullException("owner");
			}
			AtomTextConstruct atomTextConstruct = owner.CreateAtomSubElement(reader, this) as AtomTextConstruct;
			if (reader.NodeType == XmlNodeType.Element)
			{
				if (reader.HasAttributes)
				{
					while (reader.MoveToNextAttribute())
					{
						object localName = reader.LocalName;
						if (localName.Equals(atomParserNameTable_0.Type))
						{
							atomTextConstruct.Type = (AtomTextConstructType)Enum.Parse(typeof(AtomTextConstructType), Utilities.DecodedValue(reader.Value), ignoreCase: true);
						}
						else
						{
							ParseBaseAttributes(reader, atomTextConstruct);
						}
					}
				}
				reader.MoveToElement();
				switch (atomTextConstruct.Type)
				{
				case AtomTextConstructType.text:
				case AtomTextConstructType.html:
					atomTextConstruct.Text = Utilities.DecodedValue(reader.ReadString());
					break;
				default:
					atomTextConstruct.Text = reader.ReadInnerXml();
					break;
				}
			}
			return atomTextConstruct;
		}

		protected AtomGenerator ParseGenerator(XmlReader reader, AtomBase owner)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			if (owner == null)
			{
				throw new ArgumentNullException("owner");
			}
			AtomGenerator atomGenerator = owner.CreateAtomSubElement(reader, this) as AtomGenerator;
			if (atomGenerator != null)
			{
				atomGenerator.Text = Utilities.DecodedValue(reader.ReadString());
				if (reader.HasAttributes)
				{
					while (reader.MoveToNextAttribute())
					{
						object localName = reader.LocalName;
						if (localName.Equals(atomParserNameTable_0.Uri))
						{
							atomGenerator.Uri = new AtomUri(reader.Value);
						}
						else if (localName.Equals(atomParserNameTable_0.Version))
						{
							atomGenerator.Version = Utilities.DecodedValue(reader.Value);
						}
						else
						{
							ParseBaseAttributes(reader, atomGenerator);
						}
					}
				}
			}
			return atomGenerator;
		}

		protected AtomContent ParseContent(XmlReader reader, AtomBase owner)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			if (owner == null)
			{
				throw new ArgumentNullException("owner");
			}
			AtomContent atomContent = owner.CreateAtomSubElement(reader, this) as AtomContent;
			if (atomContent != null)
			{
				if (reader.HasAttributes)
				{
					while (reader.MoveToNextAttribute())
					{
						object localName = reader.LocalName;
						if (localName.Equals(atomParserNameTable_0.Type))
						{
							atomContent.Type = Utilities.DecodedValue(reader.Value);
						}
						else if (localName.Equals(atomParserNameTable_0.Src))
						{
							atomContent.Src = new AtomUri(reader.Value);
						}
						else
						{
							ParseBaseAttributes(reader, atomContent);
						}
					}
				}
				if (BaseFeedParser.MoveToStartElement(reader))
				{
					if (!atomContent.Type.Equals("text") && !atomContent.Type.Equals("html") && !atomContent.Type.StartsWith("text/"))
					{
						if (!atomContent.Type.Equals("xhtml") && !atomContent.Type.Contains("/xml") && !atomContent.Type.Contains("+xml"))
						{
							atomContent.Content = Utilities.DecodedValue(reader.ReadString());
						}
						else if (!reader.IsEmptyElement)
						{
							int depth = -1;
							while (BaseFeedParser.NextChildElement(reader, ref depth))
							{
								ParseExtensionElements(reader, atomContent);
							}
						}
					}
					else
					{
						atomContent.Content = Utilities.DecodedValue(reader.ReadString());
					}
				}
			}
			return atomContent;
		}
	}
}
