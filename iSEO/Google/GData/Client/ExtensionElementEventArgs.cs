using System;
using System.Xml;

namespace Google.GData.Client
{
	public class ExtensionElementEventArgs : EventArgs
	{
		private bool bool_0;

		private AtomBase atomBase_0;

		private XmlNode xmlNode_0;

		public bool DiscardEntry
		{
			get
			{
				return bool_0;
			}
			set
			{
				bool_0 = value;
			}
		}

		public XmlNode ExtensionElement
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

		public AtomBase Base
		{
			get
			{
				return atomBase_0;
			}
			set
			{
				atomBase_0 = value;
			}
		}
	}
}
