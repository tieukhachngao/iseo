using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using Google.GData.Extensions;

namespace Google.GData.Client
{
	public abstract class AtomBase : IVersionAware, IExtensionContainer
	{
		private AtomUri atomUri_0;

		private AtomUri atomUri_1;

		private string string_0;

		private ExtensionList extensionList_0;

		private ExtensionList extensionList_1;

		private bool bool_0;

		private bool bool_1;

		private Class59 class59_0 = new Class59();

		public bool Dirty
		{
			get
			{
				return bool_1;
			}
			set
			{
				bool_1 = value;
			}
		}

		protected AtomUri ImpliedBase
		{
			get
			{
				return atomUri_1;
			}
			set
			{
				atomUri_1 = value;
			}
		}

		public abstract string XmlName { get; }

		public AtomUri Base
		{
			get
			{
				return atomUri_0;
			}
			set
			{
				Dirty = true;
				atomUri_0 = value;
				if (bool_0)
				{
					BaseUriChanged(value);
				}
			}
		}

		public string Language
		{
			get
			{
				return string_0;
			}
			set
			{
				Dirty = true;
				string_0 = value;
			}
		}

		public ExtensionList ExtensionFactories
		{
			get
			{
				if (extensionList_1 == null)
				{
					extensionList_1 = new ExtensionList(this);
				}
				return extensionList_1;
			}
		}

		public ExtensionList ExtensionElements
		{
			get
			{
				if (extensionList_0 == null)
				{
					extensionList_0 = new ExtensionList(this);
				}
				return extensionList_0;
			}
		}

		public int ProtocolMajor
		{
			get
			{
				return class59_0.ProtocolMajor;
			}
			set
			{
				class59_0.ProtocolMajor = value;
				OnVersionInfoChanged();
			}
		}

		public int ProtocolMinor
		{
			get
			{
				return class59_0.ProtocolMinor;
			}
			set
			{
				class59_0.ProtocolMinor = value;
				OnVersionInfoChanged();
			}
		}

		internal void method_0(bool A_0)
		{
			WalkTree(new BaseMarkDirty(A_0));
		}

		public bool IsPersistable()
		{
			return WalkTree(new BaseIsPersistable());
		}

		public bool IsDirty()
		{
			return WalkTree(new BaseIsDirty());
		}

		public string GetAbsoluteUri(string part)
		{
			return Utilities.smethod_1(Base, ImpliedBase, part);
		}

		internal virtual void BaseUriChanged(AtomUri uriValue)
		{
			bool_0 = true;
			atomUri_1 = uriValue;
		}

		public void AddExtension(IExtensionElementFactory factory)
		{
			if (factory == null)
			{
				throw new ArgumentNullException("factory");
			}
			ExtensionFactories.Add(factory);
		}

		public void RemoveExtension(IExtensionElementFactory factory)
		{
			if (factory == null)
			{
				throw new ArgumentNullException("factory");
			}
			ExtensionFactories.Remove(factory.XmlNameSpace, factory.XmlName);
		}

		public virtual bool WalkTree(IBaseWalkerAction action)
		{
			if (action == null)
			{
				throw new ArgumentNullException("action");
			}
			return action.Go(this);
		}

		public IExtensionElementFactory FindExtension(string localName, string ns)
		{
			return Utilities.FindExtension(ExtensionElements, localName, ns);
		}

		public IExtensionElementFactory CreateExtension(string localName, string ns)
		{
			IExtensionElementFactory result = null;
			IExtensionElementFactory extensionElementFactory = FindExtensionFactory(localName, ns);
			if (extensionElementFactory != null)
			{
				result = extensionElementFactory.CreateInstance(null, null);
			}
			return result;
		}

		public IExtensionElementFactory FindExtensionFactory(string localName, string ns)
		{
			foreach (IExtensionElementFactory extensionFactory in ExtensionFactories)
			{
				if (string.Compare(ns, extensionFactory.XmlNameSpace, ignoreCase: true, CultureInfo.InvariantCulture) == 0 && string.Compare(localName, extensionFactory.XmlName) == 0)
				{
					return extensionFactory;
				}
			}
			return null;
		}

		public ExtensionList FindExtensions(string localName, string ns)
		{
			return FindExtensions(localName, ns, new ExtensionList(this));
		}

		public ExtensionList FindExtensions(string localName, string ns, ExtensionList arr)
		{
			return Utilities.FindExtensions(ExtensionElements, localName, ns, arr);
		}

		public List<T> FindExtensions<T>(string localName, string ns)
		{
			return Utilities.FindExtensions<T>(ExtensionElements, localName, ns);
		}

		public int DeleteExtensions(string localName, string ns)
		{
			ExtensionList extensionList = FindExtensions(localName, ns);
			foreach (IExtensionElementFactory item in extensionList)
			{
				ExtensionElements.Remove(item);
			}
			return extensionList.Count;
		}

		public int ReplaceExtensions(ExtensionList newList)
		{
			int num = 0;
			if (newList != null)
			{
				foreach (IExtensionElementFactory @new in newList)
				{
					string text = null;
					string ns = null;
					XmlNode xmlNode = @new as XmlNode;
					if (xmlNode != null)
					{
						text = xmlNode.LocalName;
						ns = xmlNode.NamespaceURI;
					}
					else
					{
						IExtensionElementFactory extensionElementFactory = @new as IExtensionElementFactory;
						if (extensionElementFactory != null)
						{
							text = extensionElementFactory.XmlName;
							ns = extensionElementFactory.XmlNameSpace;
						}
					}
					if (text != null)
					{
						num += DeleteExtensions(text, ns);
					}
				}
				{
					foreach (IExtensionElementFactory new2 in newList)
					{
						ExtensionElements.Add(new2);
					}
					return num;
				}
			}
			return num;
		}

		public void ReplaceExtension(string localName, string ns, IExtensionElementFactory obj)
		{
			DeleteExtensions(localName, ns);
			ExtensionElements.Add(obj);
		}

		public virtual AtomBase CreateAtomSubElement(XmlReader reader, AtomFeedParser parser)
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
			if (localName.Equals(parser.Nametable.Id))
			{
				return new AtomId();
			}
			if (localName.Equals(parser.Nametable.Link))
			{
				return new AtomLink();
			}
			if (localName.Equals(parser.Nametable.Icon))
			{
				return new AtomIcon();
			}
			if (localName.Equals(parser.Nametable.Logo))
			{
				return new AtomLogo();
			}
			if (localName.Equals(parser.Nametable.Author))
			{
				return new AtomPerson(AtomPersonType.Author);
			}
			if (localName.Equals(parser.Nametable.Contributor))
			{
				return new AtomPerson(AtomPersonType.Contributor);
			}
			if (localName.Equals(parser.Nametable.Title))
			{
				return new AtomTextConstruct(AtomTextConstructElementType.Title);
			}
			if (localName.Equals(parser.Nametable.Subtitle))
			{
				return new AtomTextConstruct(AtomTextConstructElementType.Subtitle);
			}
			if (localName.Equals(parser.Nametable.Rights))
			{
				return new AtomTextConstruct(AtomTextConstructElementType.Rights);
			}
			if (localName.Equals(parser.Nametable.Summary))
			{
				return new AtomTextConstruct(AtomTextConstructElementType.Summary);
			}
			if (localName.Equals(parser.Nametable.Generator))
			{
				return new AtomGenerator();
			}
			if (!localName.Equals(parser.Nametable.Category))
			{
				throw new NotImplementedException("AtomBase CreateChild should NEVER be called for: " + reader.LocalName);
			}
			return new AtomCategory();
		}

		public void SaveToXml(Stream stream)
		{
			if (stream == null)
			{
				throw new ArgumentNullException("stream");
			}
			XmlTextWriter xmlTextWriter = new XmlTextWriter(stream, Encoding.UTF8);
			xmlTextWriter.Formatting = Formatting.Indented;
			xmlTextWriter.WriteStartDocument();
			SaveToXml(xmlTextWriter);
			xmlTextWriter.Flush();
		}

		public void SaveToXml(XmlWriter writer)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			if (IsPersistable())
			{
				WriteElementStart(writer, XmlName);
				SaveXmlAttributes(writer);
				SaveInnerXml(writer);
				writer.WriteEndElement();
			}
			method_0(A_0: false);
		}

		protected virtual void SaveXmlAttributes(XmlWriter writer)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			if (Utilities.IsPersistable(atomUri_0))
			{
				writer.WriteAttributeString("xml", "base", "http://www.w3.org/XML/1998/namespace", Base.ToString());
			}
			if (Utilities.IsPersistable(string_0))
			{
				writer.WriteAttributeString("xml", "lang", "http://www.w3.org/XML/1998/namespace", Language);
			}
			ISupportsEtag supportsEtag = this as ISupportsEtag;
			if (supportsEtag != null && supportsEtag.Etag != null)
			{
				writer.WriteAttributeString("gd", "etag", "http://schemas.google.com/g/2005", supportsEtag.Etag);
			}
			foreach (IExtensionElementFactory extensionElement in ExtensionElements)
			{
				XmlExtension xmlExtension = extensionElement as XmlExtension;
				if (xmlExtension != null && xmlExtension.Node.NodeType == XmlNodeType.Attribute)
				{
					extensionElement.Save(writer);
				}
			}
			AddOtherNamespaces(writer);
			foreach (IExtensionElementFactory extensionElement2 in ExtensionElements)
			{
				XmlExtension xmlExtension2 = extensionElement2 as XmlExtension;
				if (xmlExtension2 == null || xmlExtension2.Node.NodeType != XmlNodeType.Attribute)
				{
					extensionElement2.Save(writer);
				}
			}
		}

		protected virtual bool SkipNode(XmlNode node)
		{
			if (node.NodeType == XmlNodeType.Attribute && string.Compare(node.Name, "xmlns") == 0 && string.Compare(node.Value, "http://www.w3.org/2005/Atom") == 0)
			{
				return true;
			}
			return false;
		}

		private bool method_1(XmlWriter A_0)
		{
			string text = A_0.LookupPrefix("http://www.w3.org/2005/Atom");
			if (text == null)
			{
				foreach (IExtensionElementFactory extensionElement in ExtensionElements)
				{
					XmlExtension xmlExtension = extensionElement as XmlExtension;
					if (xmlExtension != null && xmlExtension.Node.NodeType == XmlNodeType.Attribute && string.Compare(xmlExtension.Node.Name, "xmlns") == 0 && string.Compare(xmlExtension.Node.Value, "http://www.w3.org/2005/Atom") != 0)
					{
						return false;
					}
				}
				return true;
			}
			if (text.Length > 0)
			{
				return false;
			}
			return true;
		}

		protected void WriteElementStart(XmlWriter writer, string elementName)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			if (!method_1(writer))
			{
				writer.WriteStartElement("atom", elementName, "http://www.w3.org/2005/Atom");
			}
			else
			{
				writer.WriteStartElement(elementName);
			}
		}

		protected virtual void AddOtherNamespaces(XmlWriter writer)
		{
			Utilities.EnsureAtomNamespace(writer);
		}

		protected void WriteLocalDateTimeElement(XmlWriter writer, string elementName, DateTime dateTime)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			if (elementName == null)
			{
				throw new ArgumentNullException("elementName");
			}
			if (elementName.Length > 0 && Utilities.IsPersistable(dateTime))
			{
				string text = Utilities.LocalDateTimeInUTC(dateTime);
				WriteElementStart(writer, elementName);
				writer.WriteString(text);
				writer.WriteEndElement();
			}
		}

		protected virtual void SaveInnerXml(XmlWriter writer)
		{
		}

		protected static void WriteEncodedString(XmlWriter writer, string content)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer", "No valid xmlWriter");
			}
			if (Utilities.IsPersistable(content))
			{
				string text = Utilities.EncodeString(content);
				writer.WriteString(text);
			}
		}

		protected static void WriteEncodedString(XmlWriter writer, AtomUri content)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer", "No valid xmlWriter");
			}
			if (Utilities.IsPersistable(content))
			{
				string text = Utilities.EncodeString(content.ToString());
				writer.WriteString(text);
			}
		}

		protected static void WriteEncodedAttributeString(XmlWriter writer, string attributeName, AtomUri content)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer", "No valid xmlWriter");
			}
			if (attributeName == null)
			{
				throw new ArgumentNullException("attributeName", "No valid attributename");
			}
			if (Utilities.IsPersistable(content))
			{
				string value = Utilities.EncodeString(content.ToString());
				writer.WriteAttributeString(attributeName, value);
			}
		}

		protected static void WriteEncodedAttributeString(XmlWriter writer, string attributeName, string content)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			if (Utilities.IsPersistable(content))
			{
				string value = Utilities.EncodeString(content);
				writer.WriteAttributeString(attributeName, value);
			}
		}

		protected static void WriteEncodedElementString(XmlWriter writer, string elementName, string content)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			if (Utilities.IsPersistable(content))
			{
				string value = Utilities.EncodeString(content);
				writer.WriteElementString(elementName, "http://www.w3.org/2005/Atom", value);
			}
		}

		protected static void WriteEncodedElementString(XmlWriter writer, string elementName, AtomUri content)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			if (Utilities.IsPersistable(content))
			{
				string value = Utilities.EncodeString(content.ToString());
				writer.WriteElementString(elementName, "http://www.w3.org/2005/Atom", value);
			}
		}

		protected virtual void OnVersionInfoChanged()
		{
			WalkTree(new Class58(this));
		}

		internal void method_2(IVersionAware A_0)
		{
			class59_0 = new Class59(A_0);
			class59_0.method_1(ExtensionElements);
			class59_0.method_1(ExtensionFactories);
		}

		public virtual bool ShouldBePersisted()
		{
			if (!Utilities.IsPersistable(atomUri_0) && !Utilities.IsPersistable(string_0))
			{
				if (extensionList_0 != null && extensionList_0.Count > 0 && extensionList_0[0] != null)
				{
					return true;
				}
				return false;
			}
			return true;
		}
	}
}
