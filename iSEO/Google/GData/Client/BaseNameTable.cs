using System.Xml;

namespace Google.GData.Client
{
	public class BaseNameTable
	{
		public const string NSOpenSearchRss = "http://a9.com/-/spec/opensearchrss/1.0/";

		public const string NSOpenSearch11 = "http://a9.com/-/spec/opensearch/1.1/";

		public const string NSAtom = "http://www.w3.org/2005/Atom";

		public const string NSAppPublishing = "http://purl.org/atom/app#";

		public const string NSAppPublishingFinal = "http://www.w3.org/2007/app";

		public const string NSXml = "http://www.w3.org/XML/1998/namespace";

		public const string gNamespace = "http://schemas.google.com/g/2005";

		public const string gBatchNamespace = "http://schemas.google.com/gdata/batch";

		public const string gNamespacePrefix = "http://schemas.google.com/g/2005#";

		public const string ServicePost = "http://schemas.google.com/g/2005#post";

		public const string ServiceFeed = "http://schemas.google.com/g/2005#feed";

		public const string ServiceBatch = "http://schemas.google.com/g/2005#batch";

		public const string gKind = "http://schemas.google.com/g/2005#kind";

		public const string gLabels = "http://schemas.google.com/g/2005/labels";

		public const string ServiceEdit = "edit";

		public const string ServiceNext = "next";

		public const string ServicePrev = "previous";

		public const string ServiceSelf = "self";

		public const string ServiceAlternate = "alternate";

		public const string ServiceMedia = "edit-media";

		public const string AtomPrefix = "atom";

		public const string gDataPrefix = "gd";

		public const string gBatchPrefix = "batch";

		public const string gdErrors = "errors";

		public const string gdError = "error";

		public const string gdDomain = "domain";

		public const string gdCode = "code";

		public const string gdLocation = "location";

		public const string gdInternalReason = "internalReason";

		public const string gAppPublishingPrefix = "app";

		public const string XmlElementPubControl = "control";

		public const string XmlElementPubDraft = "draft";

		public const string XmlElementPubEdited = "edited";

		public const string XmlEtagAttribute = "etag";

		public const string XmlElementBatchId = "id";

		public const string XmlElementBatchOperation = "operation";

		public const string XmlElementBatchStatus = "status";

		public const string XmlElementBatchInterrupt = "interrupted";

		public const string XmlAttributeBatchContentType = "content-type";

		public const string XmlAttributeBatchStatusCode = "code";

		public const string XmlAttributeBatchReason = "reason";

		public const string XmlElementBatchErrors = "errors";

		public const string XmlElementBatchError = "error";

		public const string XmlAttributeBatchSuccess = "success";

		public const string XmlAttributeBatchParsed = "parsed";

		public const string XmlAttributeBatchField = "field";

		public const string XmlAttributeBatchUnprocessed = "unprocessed";

		public const string XmlValue = "value";

		public const string XmlName = "name";

		public const string XmlAttributeType = "type";

		public const string XmlAttributeKey = "key";

		private NameTable nameTable_0;

		private object object_0;

		private object object_1;

		private object object_2;

		private object object_3;

		private object object_4;

		private object object_5;

		private object object_6;

		private object object_7;

		private object object_8;

		private object object_9;

		private object object_10;

		private object object_11;

		private object object_12;

		private object object_13;

		private object object_14;

		private object object_15;

		private object object_16;

		private object object_17;

		private object object_18;

		private object object_19;

		private object object_20;

		private object object_21;

		private object object_22;

		internal NameTable Nametable => nameTable_0;

		public object BatchId => object_5;

		public object BatchOperation => object_7;

		public object BatchStatus => object_6;

		public object BatchInterrupt => object_8;

		public object BatchContentType => object_9;

		public object BatchStatusCode => object_10;

		public object BatchErrors => object_12;

		public object BatchError => object_13;

		public object BatchReason => object_11;

		public object BatchField => object_17;

		public object BatchUnprocessed => object_18;

		public object BatchSuccessCount => object_14;

		public object BatchFailureCount => object_15;

		public object BatchParsedCount => object_16;

		public object TotalResults => object_0;

		public object StartIndex => object_1;

		public object ItemsPerPage => object_2;

		public static string Parameter => "parameter";

		public object Base => object_3;

		public object Language => object_4;

		public object Value => object_20;

		public object Type => object_19;

		public object Name => object_21;

		public object ETag => object_22;

		public virtual void InitAtomParserNameTable()
		{
			nameTable_0 = new NameTable();
			object_0 = nameTable_0.Add("totalResults");
			object_1 = nameTable_0.Add("startIndex");
			object_2 = nameTable_0.Add("itemsPerPage");
			object_3 = nameTable_0.Add("base");
			object_4 = nameTable_0.Add("lang");
			object_5 = nameTable_0.Add("id");
			object_7 = nameTable_0.Add("operation");
			object_6 = nameTable_0.Add("status");
			object_8 = nameTable_0.Add("interrupted");
			object_9 = nameTable_0.Add("content-type");
			object_10 = nameTable_0.Add("code");
			object_11 = nameTable_0.Add("reason");
			object_12 = nameTable_0.Add("errors");
			object_13 = nameTable_0.Add("error");
			object_14 = nameTable_0.Add("success");
			object_15 = object_13;
			object_16 = nameTable_0.Add("parsed");
			object_17 = nameTable_0.Add("field");
			object_18 = nameTable_0.Add("unprocessed");
			object_19 = nameTable_0.Add("type");
			object_20 = nameTable_0.Add("value");
			object_21 = nameTable_0.Add("name");
			object_22 = nameTable_0.Add("etag");
		}

		public static string OpenSearchNamespace(IVersionAware v)
		{
			int num = 1;
			if (v != null)
			{
				num = v.ProtocolMajor;
			}
			if (num == 1)
			{
				return "http://a9.com/-/spec/opensearchrss/1.0/";
			}
			return "http://a9.com/-/spec/opensearch/1.1/";
		}

		public static string AppPublishingNamespace(IVersionAware v)
		{
			int num = 1;
			if (v != null)
			{
				num = v.ProtocolMajor;
			}
			if (num == 1)
			{
				return "http://purl.org/atom/app#";
			}
			return "http://www.w3.org/2007/app";
		}
	}
}
