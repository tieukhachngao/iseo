using System;
using System.Xml;

namespace Google.GData.Client
{
	public class GDataBatchError : IExtensionElementFactory
	{
		private string string_0;

		private string string_1;

		private string string_2;

		public string Type
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

		public string Field
		{
			get
			{
				return string_2;
			}
			set
			{
				string_2 = value;
			}
		}

		public string Reason
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

		public string XmlName => "error";

		public string XmlNameSpace => "http://schemas.google.com/gdata/batch";

		public string XmlPrefix => "batch";

		public void Save(XmlWriter writer)
		{
		}

		public static void ParseBatchErrors(XmlReader reader, AtomFeedParser parser, GDataBatchStatus status)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			object localName = reader.LocalName;
			if (!localName.Equals(parser.Nametable.BatchErrors))
			{
				return;
			}
			int depth = -1;
			while (Utilities.NextChildElement(reader, ref depth))
			{
				localName = reader.LocalName;
				if (localName.Equals(parser.Nametable.BatchError))
				{
					status.Errors.Add(ParseBatchError(reader, parser));
				}
			}
		}

		public static GDataBatchError ParseBatchError(XmlReader reader, AtomFeedParser parser)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			object localName = reader.LocalName;
			GDataBatchError gDataBatchError = null;
			if (localName.Equals(parser.Nametable.BatchError))
			{
				gDataBatchError = new GDataBatchError();
				if (reader.HasAttributes)
				{
					while (reader.MoveToNextAttribute())
					{
						localName = reader.LocalName;
						if (localName.Equals(parser.Nametable.BatchReason))
						{
							gDataBatchError.Reason = Utilities.DecodedValue(reader.Value);
						}
						else if (localName.Equals(parser.Nametable.Type))
						{
							gDataBatchError.Type = Utilities.DecodedValue(reader.Value);
						}
						else if (localName.Equals(parser.Nametable.BatchField))
						{
							gDataBatchError.Field = Utilities.DecodedValue(reader.Value);
						}
					}
				}
			}
			return gDataBatchError;
		}

		public IExtensionElementFactory CreateInstance(XmlNode node, AtomFeedParser parser)
		{
			return ParseBatchError(new XmlNodeReader(node), parser);
		}
	}
}
