using System;
using System.Globalization;
using System.Xml;

namespace Google.GData.Client
{
	public class GDataBatchInterrupt : IExtensionElementFactory
	{
		private string string_0;

		private int int_0;

		private int int_1;

		private int int_2;

		private int int_3;

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

		public int Successes
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

		public int Failures
		{
			get
			{
				return int_1;
			}
			set
			{
				int_1 = value;
			}
		}

		public int Unprocessed
		{
			get
			{
				return int_3;
			}
			set
			{
				int_3 = value;
			}
		}

		public int Parsed
		{
			get
			{
				return int_2;
			}
			set
			{
				int_2 = value;
			}
		}

		public string XmlName => "interrupted";

		public string XmlNameSpace => "http://schemas.google.com/gdata/batch";

		public string XmlPrefix => "batch";

		public void Save(XmlWriter writer)
		{
		}

		public static GDataBatchInterrupt ParseBatchInterrupt(XmlReader reader, AtomFeedParser parser)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			object localName = reader.LocalName;
			GDataBatchInterrupt gDataBatchInterrupt = null;
			if (localName.Equals(parser.Nametable.BatchInterrupt))
			{
				gDataBatchInterrupt = new GDataBatchInterrupt();
				if (reader.HasAttributes)
				{
					while (reader.MoveToNextAttribute())
					{
						localName = reader.LocalName;
						if (localName.Equals(parser.Nametable.BatchReason))
						{
							gDataBatchInterrupt.Reason = Utilities.DecodedValue(reader.Value);
						}
						else if (localName.Equals(parser.Nametable.BatchSuccessCount))
						{
							gDataBatchInterrupt.Successes = int.Parse(Utilities.DecodedValue(reader.Value), CultureInfo.InvariantCulture);
						}
						else if (localName.Equals(parser.Nametable.BatchFailureCount))
						{
							gDataBatchInterrupt.Failures = int.Parse(Utilities.DecodedValue(reader.Value), CultureInfo.InvariantCulture);
						}
						else if (localName.Equals(parser.Nametable.BatchParsedCount))
						{
							gDataBatchInterrupt.Parsed = int.Parse(Utilities.DecodedValue(reader.Value), CultureInfo.InvariantCulture);
						}
						else if (localName.Equals(parser.Nametable.BatchUnprocessed))
						{
							gDataBatchInterrupt.Unprocessed = int.Parse(Utilities.DecodedValue(reader.Value), CultureInfo.InvariantCulture);
						}
					}
				}
			}
			return gDataBatchInterrupt;
		}

		public IExtensionElementFactory CreateInstance(XmlNode node, AtomFeedParser parser)
		{
			return ParseBatchInterrupt(new XmlNodeReader(node), parser);
		}
	}
}
