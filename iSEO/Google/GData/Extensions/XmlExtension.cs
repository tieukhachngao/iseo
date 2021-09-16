using System.Xml;
using Google.GData.Client;

namespace Google.GData.Extensions
{
	public class XmlExtension : IExtensionElementFactory
	{
		private XmlNode xmlNode_0;

		public XmlNode Node
		{
			get
			{
				return xmlNode_0;
			}
			set
			{
				xmlNode_0 = value;
			}
		}

		public string XmlName
		{
			get
			{
				if (xmlNode_0 != null)
				{
					return xmlNode_0.LocalName;
				}
				return null;
			}
		}

		public string XmlNameSpace
		{
			get
			{
				if (xmlNode_0 != null)
				{
					return xmlNode_0.NamespaceURI;
				}
				return null;
			}
		}

		public string XmlPrefix
		{
			get
			{
				if (xmlNode_0 != null)
				{
					return xmlNode_0.Prefix;
				}
				return null;
			}
		}

		public XmlExtension(XmlNode node)
		{
			xmlNode_0 = node;
		}

		public override string ToString()
		{
			return base.ToString() + " for: " + XmlNameSpace + "- " + XmlName;
		}

		public static implicit operator XmlNode(XmlExtension x)
		{
			return x.Node;
		}

		public virtual IExtensionElementFactory CreateInstance(XmlNode node, AtomFeedParser parser)
		{
			return new XmlExtension(node);
		}

		public virtual void Save(XmlWriter writer)
		{
			if (Node != null)
			{
				Node.WriteTo(writer);
			}
		}
	}
}
