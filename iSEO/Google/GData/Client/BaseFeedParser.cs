using System;
using System.IO;
using System.Threading;
using System.Xml;
using Google.GData.Extensions;

namespace Google.GData.Client
{
	public abstract class BaseFeedParser
	{
		private FeedParserEventHandler feedParserEventHandler_0;

		private ExtensionElementEventHandler extensionElementEventHandler_0;

		private XmlDocument xmlDocument_0;

		protected XmlDocument Document
		{
			get
			{
				if (xmlDocument_0 == null)
				{
					xmlDocument_0 = new XmlDocument();
				}
				return xmlDocument_0;
			}
		}

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

		public abstract void Parse(Stream streamInput, AtomFeed feed);

		protected AtomEntry OnCreateNewEntry()
		{
			FeedParserEventArgs feedParserEventArgs = new FeedParserEventArgs();
			OnNewAtomEntry(feedParserEventArgs);
			if (feedParserEventArgs.Entry == null)
			{
				return new AtomEntry();
			}
			return feedParserEventArgs.Entry;
		}

		protected void OnNewAtomEntry(AtomEntry newEntry)
		{
			FeedParserEventArgs args = new FeedParserEventArgs(null, newEntry);
			OnNewAtomEntry(args);
		}

		protected void OnParsingDone()
		{
			FeedParserEventArgs args = new FeedParserEventArgs(null, null);
			OnNewAtomEntry(args);
		}

		protected void OnNewAtomEntry(AtomFeed feed)
		{
			FeedParserEventArgs args = new FeedParserEventArgs(feed, null);
			OnNewAtomEntry(args);
		}

		protected void OnNewExtensionElement(XmlNode node, AtomBase baseObject)
		{
			ExtensionElementEventArgs extensionElementEventArgs = new ExtensionElementEventArgs();
			extensionElementEventArgs.ExtensionElement = node;
			extensionElementEventArgs.Base = baseObject;
			if (extensionElementEventHandler_0 != null)
			{
				extensionElementEventHandler_0(this, extensionElementEventArgs);
			}
			if (!extensionElementEventArgs.DiscardEntry)
			{
				baseObject.ExtensionElements.Add(new XmlExtension(node));
			}
		}

		protected void OnNewExtensionElement(XmlReader reader, AtomBase baseObject)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			if (baseObject == null)
			{
				throw new ArgumentNullException("baseObject");
			}
			if (reader.NodeType == XmlNodeType.Element || reader.NodeType == XmlNodeType.Attribute)
			{
				XmlNode xmlNode = Document.ReadNode(reader);
				if (xmlNode != null)
				{
					OnNewExtensionElement(xmlNode, baseObject);
				}
			}
		}

		protected virtual void OnNewAtomEntry(FeedParserEventArgs args)
		{
			if (feedParserEventHandler_0 != null)
			{
				feedParserEventHandler_0(this, args);
			}
		}

		protected static bool NextElement(XmlReader reader)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			while (reader.Read() && reader.NodeType != XmlNodeType.Element)
			{
			}
			return !reader.EOF;
		}

		protected static bool NextChildElement(XmlReader reader, ref int depth)
		{
			return Utilities.NextChildElement(reader, ref depth);
		}

		protected static bool MoveToStartElement(XmlReader reader)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			if (reader.NodeType != XmlNodeType.Attribute && reader.NodeType != XmlNodeType.Text)
			{
				while (reader.NodeType != XmlNodeType.Element && reader.Read() && !reader.EOF)
				{
				}
			}
			else
			{
				reader.MoveToElement();
			}
			return !reader.EOF;
		}
	}
}
