using System;
using System.Xml;

namespace Google.GData.Client
{
	public class GDataBatchEntryData : IExtensionElementFactory
	{
		private GDataBatchOperationType gdataBatchOperationType_0;

		private string string_0;

		private GDataBatchStatus gdataBatchStatus_0;

		private GDataBatchInterrupt gdataBatchInterrupt_0;

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

		public string Id
		{
			get
			{
				return string_0;
			}
			set
			{
				string_0 = value;
			}
		}

		public GDataBatchInterrupt Interrupt
		{
			get
			{
				return gdataBatchInterrupt_0;
			}
			set
			{
				gdataBatchInterrupt_0 = value;
			}
		}

		public GDataBatchStatus Status
		{
			get
			{
				if (gdataBatchStatus_0 == null)
				{
					gdataBatchStatus_0 = new GDataBatchStatus();
				}
				return gdataBatchStatus_0;
			}
			set
			{
				gdataBatchStatus_0 = value;
			}
		}

		public string XmlName => "operation";

		public string XmlNameSpace => "http://schemas.google.com/gdata/batch";

		public string XmlPrefix => "batch";

		public GDataBatchEntryData()
		{
			gdataBatchOperationType_0 = GDataBatchOperationType.Default;
		}

		public GDataBatchEntryData(GDataBatchOperationType type)
		{
			Type = type;
		}

		public GDataBatchEntryData(string id, GDataBatchOperationType type)
			: this(type)
		{
			Id = id;
		}

		public void Save(XmlWriter writer)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			if (Id != null)
			{
				writer.WriteElementString("id", "http://schemas.google.com/gdata/batch", string_0);
			}
			if (Type != GDataBatchOperationType.Default)
			{
				writer.WriteStartElement(XmlPrefix, XmlName, XmlNameSpace);
				writer.WriteAttributeString("type", gdataBatchOperationType_0.ToString());
				writer.WriteEndElement();
			}
			if (gdataBatchStatus_0 != null)
			{
				gdataBatchStatus_0.Save(writer);
			}
		}

		public IExtensionElementFactory CreateInstance(XmlNode node, AtomFeedParser parser)
		{
			throw new Exception("The method or operation is not implemented.");
		}
	}
}
