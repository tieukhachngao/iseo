using System;
using System.Xml;

namespace Google.GData.Client
{
	public class GDataBatchFeedData : IExtensionElementFactory
	{
		private GDataBatchOperationType gdataBatchOperationType_0;

		public GDataBatchOperationType Type
		{
			get
			{
				return gdataBatchOperationType_0;
			}
			set
			{
				gdataBatchOperationType_0 = value;
			}
		}

		public string XmlName => "operation";

		public string XmlNameSpace => "http://schemas.google.com/gdata/batch";

		public string XmlPrefix => "batch";

		public GDataBatchFeedData()
		{
			gdataBatchOperationType_0 = GDataBatchOperationType.Default;
		}

		public void Save(XmlWriter writer)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			if (Type != GDataBatchOperationType.Default)
			{
				writer.WriteStartElement(XmlPrefix, XmlName, XmlNameSpace);
				writer.WriteAttributeString("type", gdataBatchOperationType_0.ToString());
				writer.WriteEndElement();
			}
		}

		public IExtensionElementFactory CreateInstance(XmlNode node, AtomFeedParser parser)
		{
			throw new Exception("The method or operation is not implemented.");
		}
	}
}
