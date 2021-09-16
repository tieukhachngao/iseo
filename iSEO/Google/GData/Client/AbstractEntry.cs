using System;
using System.Xml;
using Google.GData.Extensions;
using Google.GData.Extensions.AppControl;

namespace Google.GData.Client
{
	public abstract class AbstractEntry : AtomEntry, ISupportsEtag
	{
		private string string_1;

		private MediaSource mediaSource_0;

		public MediaSource MediaSource
		{
			get
			{
				return mediaSource_0;
			}
			set
			{
				mediaSource_0 = value;
			}
		}

		public string Etag
		{
			get
			{
				return string_1;
			}
			set
			{
				string_1 = value;
			}
		}

		public AppEdited Edited
		{
			get
			{
				return FindExtension("edited", "http://www.w3.org/2007/app") as AppEdited;
			}
			set
			{
				ReplaceExtension("edited", "http://www.w3.org/2007/app", value);
			}
		}

		public AbstractEntry()
		{
			AddExtension(new AppEdited());
		}

		protected override void AddOtherNamespaces(XmlWriter writer)
		{
			base.AddOtherNamespaces(writer);
			Utilities.EnsureGDataNamespace(writer);
		}

		protected override bool SkipNode(XmlNode node)
		{
			if (base.SkipNode(node))
			{
				return true;
			}
			if (node.NodeType == XmlNodeType.Attribute && node.Name.StartsWith("xmlns"))
			{
				return string.Compare(node.Value, "http://schemas.google.com/g/2005") == 0;
			}
			return false;
		}

		public void ToggleCategory(AtomCategory cat, bool value)
		{
			if (value)
			{
				if (!base.Categories.Contains(cat))
				{
					base.Categories.Add(cat);
				}
			}
			else
			{
				base.Categories.Remove(cat);
			}
		}

		public string GetExtensionValue(string extension, string ns)
		{
			return (FindExtension(extension, ns) as SimpleElement)?.Value;
		}

		public SimpleElement SetExtensionValue(string extension, string ns, string newValue)
		{
			if (extension == null)
			{
				throw new ArgumentNullException("extension");
			}
			SimpleElement simpleElement = FindExtension(extension, ns) as SimpleElement;
			if (simpleElement == null)
			{
				simpleElement = CreateExtension(extension, ns) as SimpleElement;
				if (simpleElement == null)
				{
					throw new ArgumentException("The namespace or tagname was invalid");
				}
				base.ExtensionElements.Add(simpleElement);
			}
			simpleElement.Value = newValue;
			return simpleElement;
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
