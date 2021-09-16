using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml;

namespace Google.GData.Client
{
	public class GDataBatchStatus : IExtensionElementFactory
	{
		public const int CodeDefault = -1;

		private int int_0;

		private string string_0;

		private string string_1;

		private List<GDataBatchError> list_0;

		public int Code
		{
			get
			{
				return int_0;
			}
			set
			{
				int_0 = value;
			}
		}

		public string Reason
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

		public string ContentType
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

		public List<GDataBatchError> Errors
		{
			get
			{
				if (list_0 == null)
				{
					list_0 = new List<GDataBatchError>();
				}
				return list_0;
			}
		}

		public string XmlName => "status";

		public string XmlNameSpace => "http://schemas.google.com/gdata/batch";

		public string XmlPrefix => "batch";

		public GDataBatchStatus()
		{
			Code = -1;
		}

		public void Save(XmlWriter writer)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			writer.WriteStartElement("batch", "status", "batch");
			if (Code != -1)
			{
				writer.WriteAttributeString("code", Code.ToString(CultureInfo.InvariantCulture));
			}
			if (Utilities.IsPersistable(ContentType))
			{
				writer.WriteAttributeString("content-type", ContentType);
			}
			if (Utilities.IsPersistable(Reason))
			{
				writer.WriteAttributeString("reason", Reason);
			}
			writer.WriteEndElement();
		}

		public static GDataBatchStatus ParseBatchStatus(XmlReader reader, AtomFeedParser parser)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			GDataBatchStatus gDataBatchStatus = null;
			object localName = reader.LocalName;
			if (localName.Equals(parser.Nametable.BatchStatus))
			{
				gDataBatchStatus = new GDataBatchStatus();
				if (reader.HasAttributes)
				{
					while (reader.MoveToNextAttribute())
					{
						localName = reader.LocalName;
						if (localName.Equals(parser.Nametable.BatchReason))
						{
							gDataBatchStatus.Reason = Utilities.DecodedValue(reader.Value);
						}
						else if (localName.Equals(parser.Nametable.BatchContentType))
						{
							gDataBatchStatus.ContentType = Utilities.DecodedValue(reader.Value);
						}
						else if (localName.Equals(parser.Nametable.BatchStatusCode))
						{
							gDataBatchStatus.Code = int.Parse(Utilities.DecodedValue(reader.Value), CultureInfo.InvariantCulture);
						}
					}
				}
				reader.MoveToElement();
				int depth = -1;
				while (Utilities.NextChildElement(reader, ref depth))
				{
					localName = reader.LocalName;
					if (localName.Equals(parser.Nametable.BatchErrors))
					{
						GDataBatchError.ParseBatchErrors(reader, parser, gDataBatchStatus);
					}
				}
			}
			return gDataBatchStatus;
		}

		public IExtensionElementFactory CreateInstance(XmlNode node, AtomFeedParser parser)
		{
			return ParseBatchStatus(new XmlNodeReader(node), parser);
		}
	}
}
