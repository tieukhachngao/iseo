using System.Collections;
using System.Collections.Generic;
using System.Xml;
using Google.GData.Client;

namespace Google.GData.Extensions
{
	public abstract class ExtensionBase : IExtensionElementFactory, IVersionAware
	{
		private string string_0;

		private string string_1;

		private string string_2;

		private List<XmlNode> list_0;

		private SortedList sortedList_0;

		private SortedList sortedList_1;

		private Class59 class59_0 = new Class59();

		internal Class59 VersionInfo => class59_0;

		public int ProtocolMajor
		{
			get
			{
				return class59_0.ProtocolMajor;
			}
			set
			{
				class59_0.ProtocolMajor = value;
				VersionInfoChanged();
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
				VersionInfoChanged();
			}
		}

		public SortedList Attributes => method_0();

		public SortedList AttributeNamespaces => method_1();

		public string XmlName => string_0;

		public string XmlNameSpace => string_2;

		public string XmlPrefix => string_1;

		public List<XmlNode> ChildNodes
		{
			get
			{
				if (list_0 == null)
				{
					list_0 = new List<XmlNode>();
				}
				return list_0;
			}
		}

		protected ExtensionBase(string name, string prefix, string ns)
		{
			string_0 = name;
			string_1 = prefix;
			string_2 = ns;
		}

		protected virtual void VersionInfoChanged()
		{
		}

		protected void SetXmlNamespace(string ns)
		{
			string_2 = ns;
		}

		internal SortedList method_0()
		{
			if (sortedList_0 == null)
			{
				sortedList_0 = new SortedList();
			}
			return sortedList_0;
		}

		internal SortedList method_1()
		{
			if (sortedList_1 == null)
			{
				sortedList_1 = new SortedList();
			}
			return sortedList_1;
		}

		public override string ToString()
		{
			return base.ToString() + " for: " + XmlNameSpace + "- " + XmlName;
		}

		public virtual IExtensionElementFactory CreateInstance(XmlNode node, AtomFeedParser parser)
		{
			ExtensionBase extensionBase = null;
			if (node != null)
			{
				object localName = node.LocalName;
				if (!localName.Equals(XmlName) || !node.NamespaceURI.Equals(XmlNameSpace))
				{
					return null;
				}
			}
			extensionBase = MemberwiseClone() as ExtensionBase;
			extensionBase.InitInstance(this);
			extensionBase.ProcessAttributes(node);
			extensionBase.ProcessChildNodes(node, parser);
			return extensionBase;
		}

		public virtual void ProcessChildNodes(XmlNode node, AtomFeedParser parser)
		{
			if (node == null || !node.HasChildNodes)
			{
				return;
			}
			for (XmlNode xmlNode = node.FirstChild; xmlNode != null; xmlNode = xmlNode.NextSibling)
			{
				if (xmlNode.NodeType == XmlNodeType.Element)
				{
					ChildNodes.Add(xmlNode);
				}
			}
		}

		protected void InitInstance(ExtensionBase factory)
		{
			sortedList_0 = null;
			sortedList_1 = null;
			list_0 = null;
			for (int i = 0; i < factory.method_0().Count; i++)
			{
				string key = factory.method_0().GetKey(i) as string;
				string value = factory.method_0().GetByIndex(i) as string;
				method_0().Add(key, value);
			}
		}

		public virtual void ProcessAttributes(XmlNode node)
		{
			if (node != null && node.Attributes != null)
			{
				for (int i = 0; i < node.Attributes.Count; i++)
				{
					method_0()[node.Attributes[i].LocalName] = node.Attributes[i].Value;
				}
			}
		}

		public virtual void Save(XmlWriter writer)
		{
			writer.WriteStartElement(XmlPrefix, XmlName, XmlNameSpace);
			if (sortedList_0 != null)
			{
				for (int i = 0; i < method_0().Count; i++)
				{
					if (method_0().GetByIndex(i) == null)
					{
						continue;
					}
					string text = method_0().GetKey(i) as string;
					string text2 = Utilities.ConvertToXSDString(method_0().GetByIndex(i));
					string text3 = method_1()[text] as string;
					if (Utilities.IsPersistable(text) && Utilities.IsPersistable(text2))
					{
						if (text3 == null)
						{
							writer.WriteAttributeString(text, text2);
						}
						else
						{
							writer.WriteAttributeString(text, text3, text2);
						}
					}
				}
			}
			SaveInnerXml(writer);
			foreach (XmlNode childNode in ChildNodes)
			{
				childNode?.WriteTo(writer);
			}
			writer.WriteEndElement();
		}

		public virtual void SaveInnerXml(XmlWriter writer)
		{
		}
	}
}
