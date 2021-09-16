using System.Collections.Generic;
using System.Xml;
using Google.GData.Client;

namespace Google.GData.Extensions
{
	public class SimpleContainer : ExtensionBase, IExtensionContainer
	{
		private ExtensionList extensionList_0;

		private ExtensionList extensionList_1;

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

		protected SimpleContainer(string name, string prefix, string ns)
			: base(name, prefix, ns)
		{
		}

		public IExtensionElementFactory FindExtension(string localName, string ns)
		{
			return Utilities.FindExtension(ExtensionElements, localName, ns);
		}

		public void ReplaceExtension(string localName, string ns, IExtensionElementFactory obj)
		{
			DeleteExtensions(localName, ns);
			ExtensionElements.Add(obj);
		}

		public void ReplaceFactory(string localName, string ns, IExtensionElementFactory obj)
		{
			ExtensionList extensionList = Utilities.FindExtensions(ExtensionFactories, localName, ns, new ExtensionList(this));
			foreach (IExtensionElementFactory item in extensionList)
			{
				ExtensionFactories.Remove(item);
			}
			ExtensionFactories.Add(obj);
		}

		public ExtensionList FindExtensions(string localName, string ns)
		{
			return Utilities.FindExtensions(ExtensionElements, localName, ns, new ExtensionList(this));
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
				extensionList_0.Remove(item);
			}
			return extensionList.Count;
		}

		public override IExtensionElementFactory CreateInstance(XmlNode node, AtomFeedParser parser)
		{
			if (node != null)
			{
				object localName = node.LocalName;
				if (!localName.Equals(base.XmlName) || !node.NamespaceURI.Equals(base.XmlNameSpace))
				{
					return null;
				}
			}
			SimpleContainer simpleContainer = null;
			simpleContainer = MemberwiseClone() as SimpleContainer;
			simpleContainer.InitInstance(this);
			simpleContainer.ProcessAttributes(node);
			simpleContainer.ProcessChildNodes(node, parser);
			return simpleContainer;
		}

		protected override void VersionInfoChanged()
		{
			base.VersionInfoChanged();
			base.VersionInfo.method_1(extensionList_0);
			base.VersionInfo.method_1(extensionList_1);
		}

		public override void ProcessChildNodes(XmlNode node, AtomFeedParser parser)
		{
			if (node == null || !node.HasChildNodes)
			{
				return;
			}
			for (XmlNode xmlNode = node.FirstChild; xmlNode != null; xmlNode = xmlNode.NextSibling)
			{
				bool flag = false;
				if (xmlNode is XmlElement)
				{
					foreach (IExtensionElementFactory extensionFactory in ExtensionFactories)
					{
						if (string.Compare(xmlNode.NamespaceURI, extensionFactory.XmlNameSpace) == 0 && string.Compare(xmlNode.LocalName, extensionFactory.XmlName) == 0)
						{
							ExtensionElements.Add(extensionFactory.CreateInstance(xmlNode, parser));
							flag = true;
							break;
						}
					}
				}
				if (!flag)
				{
					base.ChildNodes.Add(xmlNode);
				}
			}
		}

		public override void SaveInnerXml(XmlWriter writer)
		{
			if (extensionList_0 == null)
			{
				return;
			}
			foreach (IExtensionElementFactory extensionElement in ExtensionElements)
			{
				extensionElement.Save(writer);
			}
		}

		protected void SetStringValue<T>(string value, string elementName, string ns) where T : new()
		{
			T val = default(T);
			if (!string.IsNullOrEmpty(value))
			{
				val = new T
				{
					Value = value
				};
			}
			ReplaceExtension(elementName, ns, (IExtensionElementFactory)(object)val);
		}

		protected string GetStringValue<T>(string elementName, string ns)
		{
			IExtensionElementFactory extensionElementFactory = FindExtension(elementName, ns);
			return ((SimpleElement)(T)((extensionElementFactory is T) ? extensionElementFactory : null))?.Value;
		}
	}
}
