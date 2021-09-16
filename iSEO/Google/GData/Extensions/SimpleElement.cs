using System;
using System.Globalization;
using System.Xml;
using Google.GData.Client;

namespace Google.GData.Extensions
{
	public abstract class SimpleElement : ExtensionBase
	{
		private string string_3;

		public virtual string Value
		{
			get
			{
				return string_3;
			}
			set
			{
				string_3 = value;
			}
		}

		public int IntegerValue
		{
			get
			{
				return Convert.ToInt32(Value, CultureInfo.InvariantCulture);
			}
			set
			{
				Value = value.ToString(CultureInfo.InvariantCulture);
			}
		}

		[CLSCompliant(false)]
		public uint UnsignedIntegerValue
		{
			get
			{
				return Convert.ToUInt32(Value, CultureInfo.InvariantCulture);
			}
			set
			{
				Value = value.ToString(CultureInfo.InvariantCulture);
			}
		}

		[CLSCompliant(false)]
		public ulong UnsignedLongValue
		{
			get
			{
				return Convert.ToUInt64(Value, CultureInfo.InvariantCulture);
			}
			set
			{
				Value = value.ToString(CultureInfo.InvariantCulture);
			}
		}

		public double FloatValue
		{
			get
			{
				return Convert.ToDouble(Value, CultureInfo.InvariantCulture);
			}
			set
			{
				Value = value.ToString(CultureInfo.InvariantCulture);
			}
		}

		public virtual bool BooleanValue
		{
			get
			{
				return "true" == Value;
			}
			set
			{
				Value = (value ? "true" : "false");
			}
		}

		protected SimpleElement(string name, string prefix, string ns)
			: base(name, prefix, ns)
		{
		}

		protected SimpleElement(string name, string prefix, string ns, string value)
			: base(name, prefix, ns)
		{
			string_3 = value;
		}

		public override string ToString()
		{
			return base.ToString() + " for: " + base.XmlNameSpace + " - " + base.XmlName;
		}

		public override IExtensionElementFactory CreateInstance(XmlNode node, AtomFeedParser parser)
		{
			SimpleElement simpleElement = null;
			if (node != null)
			{
				object localName = node.LocalName;
				if (!localName.Equals(base.XmlName) || !node.NamespaceURI.Equals(base.XmlNameSpace))
				{
					return null;
				}
			}
			simpleElement = MemberwiseClone() as SimpleElement;
			simpleElement.InitInstance(this);
			if (node != null)
			{
				simpleElement.ProcessAttributes(node);
				if (node.HasChildNodes)
				{
					XmlNode xmlNode = node.ChildNodes[0];
					if (xmlNode.NodeType == XmlNodeType.Text && node.ChildNodes.Count == 1)
					{
						simpleElement.Value = node.InnerText;
					}
					else
					{
						simpleElement.ProcessChildNodes(node, parser);
					}
				}
			}
			return simpleElement;
		}

		public override void SaveInnerXml(XmlWriter writer)
		{
			if (string_3 != null)
			{
				writer.WriteString(string_3);
			}
		}
	}
}
