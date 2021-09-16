using System;
using System.Globalization;
using System.Text;

namespace Google.GData.Client
{
	public class FeedQuery : ISupportsEtag
	{
		private string string_0;

		private QueryCategoryCollection queryCategoryCollection_0;

		private string string_1;

		private string string_2;

		private DateTime dateTime_0;

		private DateTime dateTime_1;

		private DateTime dateTime_2;

		private DateTime dateTime_3;

		private int int_0;

		private int int_1;

		private AlternativeFormat alternativeFormat_0;

		private DateTime dateTime_4;

		private bool bool_0;

		private bool bool_1;

		private string string_3;

		protected string baseUri;

		private string string_4;

		public string BaseAddress
		{
			get
			{
				return baseUri;
			}
			set
			{
				baseUri = value;
				UseSSL = baseUri.StartsWith("https://");
			}
		}

		public Uri Uri
		{
			get
			{
				string text = GetBaseUri();
				string basePath = ((text == null) ? string.Empty : text.Replace(UnusedProtocol, DefaultProtocol));
				return new Uri(CalculateQuery(basePath));
			}
			set
			{
				ParseUri(value);
			}
		}

		public bool CategoryQueriesAsParameter
		{
			get
			{
				return bool_1;
			}
			set
			{
				bool_1 = value;
			}
		}

		[Obsolete("This is deprecated and replaced by UseSSL on the service and the requestsettings")]
		public bool UseSSL
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

		private string DefaultProtocol
		{
			get
			{
				if (!UseSSL)
				{
					return "http://";
				}
				return "https://";
			}
		}

		private string UnusedProtocol
		{
			get
			{
				if (!UseSSL)
				{
					return "https://";
				}
				return "http://";
			}
		}

		public string Query
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

		public string OAuthRequestorId
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

		public QueryCategoryCollection Categories
		{
			get
			{
				if (queryCategoryCollection_0 == null)
				{
					queryCategoryCollection_0 = new QueryCategoryCollection();
				}
				return queryCategoryCollection_0;
			}
		}

		public string Etag
		{
			get
			{
				return string_4;
			}
			set
			{
				string_4 = value;
			}
		}

		public string ExtraParameters
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

		public string Author
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

		public DateTime StartDate
		{
			get
			{
				return dateTime_0;
			}
			set
			{
				dateTime_0 = value;
			}
		}

		public DateTime EndDate
		{
			get
			{
				return dateTime_1;
			}
			set
			{
				dateTime_1 = value;
			}
		}

		public DateTime MinPublication
		{
			get
			{
				return dateTime_2;
			}
			set
			{
				dateTime_2 = value;
			}
		}

		public DateTime MaxPublication
		{
			get
			{
				return dateTime_3;
			}
			set
			{
				dateTime_3 = value;
			}
		}

		public DateTime ModifiedSince
		{
			get
			{
				return dateTime_4;
			}
			set
			{
				dateTime_4 = value;
			}
		}

		public virtual int StartIndex
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

		public virtual int NumberToRetrieve
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

		public AlternativeFormat FeedFormat
		{
			get
			{
				return alternativeFormat_0;
			}
			set
			{
				alternativeFormat_0 = value;
			}
		}

		public FeedQuery()
		{
			FeedFormat = AlternativeFormat.Atom;
		}

		public FeedQuery(string baseUri)
		{
			FeedFormat = AlternativeFormat.Atom;
			this.baseUri = baseUri;
			UseSSL = this.baseUri.StartsWith("https://");
		}

		internal static void smethod_0(FeedQuery A_0, RequestSettings A_1)
		{
			if (A_1.PageSize != -1)
			{
				A_0.NumberToRetrieve = A_1.PageSize;
			}
			if (A_1.OAuthUser != null)
			{
				A_0.OAuthRequestorId = A_1.OAuthUser;
				if (A_1.OAuthDomain != null)
				{
					A_0.OAuthRequestorId = A_0.OAuthRequestorId + "@" + A_1.OAuthDomain;
				}
			}
		}

		protected virtual string GetBaseUri()
		{
			return baseUri;
		}

		public static void Parse(Uri uri, out Service service, out FeedQuery query)
		{
			query = new FeedQuery();
			query.ParseUri(uri);
			service = new Service();
		}

		protected virtual Uri ParseUri(Uri targetUri)
		{
			Reset();
			StringBuilder stringBuilder = null;
			UriBuilder uriBuilder = null;
			if (targetUri != null)
			{
				ValidateUri(targetUri);
				stringBuilder = new StringBuilder("", 2048);
				uriBuilder = new UriBuilder(targetUri);
				uriBuilder.Path = null;
				uriBuilder.Query = null;
				string[] segments = targetUri.Segments;
				bool flag = false;
				string[] array = segments;
				foreach (string text in array)
				{
					string text2 = smethod_1(text);
					if (text2.Equals("-"))
					{
						flag = true;
					}
					else if (flag)
					{
						method_1(text2);
					}
					else
					{
						stringBuilder.Append(text);
					}
				}
				char[] delimiters = new char[2] { '?', '&' };
				string source = HttpUtility.UrlDecode(targetUri.Query);
				TokenCollection tokenCollection = new TokenCollection(source, delimiters);
				foreach (string item in tokenCollection)
				{
					if (item.Length > 0)
					{
						char[] separator = new char[1] { '=' };
						string[] array2 = item.Split(separator, 2);
						switch (array2[0])
						{
						case "q":
							Query = array2[1];
							break;
						case "author":
							Author = array2[1];
							break;
						case "start-index":
							StartIndex = int.Parse(array2[1], CultureInfo.InvariantCulture);
							break;
						case "max-results":
							NumberToRetrieve = int.Parse(array2[1], CultureInfo.InvariantCulture);
							break;
						case "updated-min":
							StartDate = DateTime.Parse(array2[1], CultureInfo.InvariantCulture);
							break;
						case "updated-max":
							EndDate = DateTime.Parse(array2[1], CultureInfo.InvariantCulture);
							break;
						case "published-min":
							MinPublication = DateTime.Parse(array2[1], CultureInfo.InvariantCulture);
							break;
						case "published-max":
							MaxPublication = DateTime.Parse(array2[1], CultureInfo.InvariantCulture);
							break;
						case "category":
							method_0(array2[1]);
							break;
						case "xoauth_requestor_id":
							OAuthRequestorId = array2[1];
							break;
						}
					}
				}
			}
			if (stringBuilder != null)
			{
				if (stringBuilder[stringBuilder.Length - 1] == '/')
				{
					stringBuilder.Length--;
				}
				uriBuilder.Path = stringBuilder.ToString();
				baseUri = uriBuilder.Uri.AbsoluteUri;
				UseSSL = baseUri.StartsWith("https://");
			}
			return null;
		}

		private void method_0(string A_0)
		{
			char[] delimiters = new char[1] { ',' };
			TokenCollection tokenCollection = new TokenCollection(A_0, delimiters);
			foreach (string item in tokenCollection)
			{
				method_1(item);
			}
		}

		private void method_1(string A_0)
		{
			A_0 = A_0.Replace("%7B", "{");
			A_0 = A_0.Replace("%7D", "}");
			A_0 = A_0.Replace("%7C", "|");
			A_0 = Utilities.UrlDecodedValue(A_0);
			TokenCollection tokenCollection = new TokenCollection(A_0, new char[1] { '|' });
			QueryCategoryOperator op = QueryCategoryOperator.AND;
			foreach (string item in tokenCollection)
			{
				QueryCategory value = new QueryCategory(item, op);
				Categories.Add(value);
				op = QueryCategoryOperator.OR;
			}
		}

		protected Uri ParseUri(string target)
		{
			Reset();
			if (target != null)
			{
				return ParseUri(new Uri(target));
			}
			return null;
		}

		internal static string smethod_1(string A_0)
		{
			if (A_0 == null)
			{
				throw new ArgumentNullException("part");
			}
			string text = A_0.Trim();
			if (text.EndsWith("/"))
			{
				text = text.Substring(0, text.Length - 1);
			}
			if (text.StartsWith("/"))
			{
				text = text.Substring(1, text.Length - 1);
			}
			return text;
		}

		protected static void ValidateUri(Uri uriToTest)
		{
			if (uriToTest == null)
			{
				throw new ArgumentNullException("uriToTest");
			}
			if (!(uriToTest.Scheme == Uri.UriSchemeFile) && !(uriToTest.Scheme == Uri.UriSchemeHttp) && !(uriToTest.Scheme == Uri.UriSchemeHttps))
			{
				throw new ClientQueryException("Only HTTP/HTTPS 1.1 protocol is currently supported");
			}
		}

		protected virtual void Reset()
		{
			string_0 = (string_1 = (string_3 = string.Empty));
			queryCategoryCollection_0 = null;
			dateTime_1 = (dateTime_0 = Utilities.EmptyDate);
			DateTime dateTime2 = (MinPublication = (MaxPublication = Utilities.EmptyDate));
			dateTime_4 = DateTime.MinValue;
			int_1 = 0;
			int_0 = 0;
			alternativeFormat_0 = AlternativeFormat.Atom;
		}

		protected virtual string CalculateQuery(string basePath)
		{
			StringBuilder stringBuilder = new StringBuilder(basePath, 2048);
			char a_ = InsertionParameter(basePath);
			a_ = method_2(stringBuilder, a_);
			if (FeedFormat != 0)
			{
				stringBuilder.Append(a_);
				stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "alt={0}", new object[1] { FormatToString(FeedFormat) });
				a_ = '&';
			}
			a_ = AppendQueryPart(Query, "q", a_, stringBuilder);
			a_ = AppendQueryPart(Author, "author", a_, stringBuilder);
			a_ = AppendQueryPart(StartDate, "updated-min", a_, stringBuilder);
			a_ = AppendQueryPart(EndDate, "updated-max", a_, stringBuilder);
			a_ = AppendQueryPart(MinPublication, "published-min", a_, stringBuilder);
			a_ = AppendQueryPart(MaxPublication, "published-max", a_, stringBuilder);
			a_ = AppendQueryPart(StartIndex, 0, "start-index", a_, stringBuilder);
			a_ = AppendQueryPart(NumberToRetrieve, 0, "max-results", a_, stringBuilder);
			a_ = AppendQueryPart(OAuthRequestorId, "xoauth_requestor_id", a_, stringBuilder);
			if (Utilities.IsPersistable(ExtraParameters))
			{
				stringBuilder.Append(a_);
				stringBuilder.Append(ExtraParameters);
			}
			return stringBuilder.ToString();
		}

		protected char InsertionParameter(string basePath)
		{
			char result = '?';
			if (basePath.IndexOf('?') != -1)
			{
				result = '&';
			}
			return result;
		}

		private char method_2(StringBuilder A_0, char A_1)
		{
			bool flag = true;
			int length = A_0.Length;
			string value = (CategoryQueriesAsParameter ? (A_1 + "category=") : "/-/");
			string value2 = (CategoryQueriesAsParameter ? "," : "/");
			foreach (QueryCategory category in Categories)
			{
				string text = Utilities.UriEncodeReserved(category.Category.UriString);
				if (Utilities.IsPersistable(text))
				{
					if (flag)
					{
						A_0.Append(value);
					}
					else
					{
						switch (category.Operator)
						{
						case QueryCategoryOperator.AND:
							A_0.Append(value2);
							break;
						case QueryCategoryOperator.OR:
							A_0.Append("|");
							break;
						}
					}
					flag = false;
					if (category.Excluded)
					{
						A_0.AppendFormat(CultureInfo.InvariantCulture, "-{0}", new object[1] { text });
					}
					else
					{
						A_0.AppendFormat(CultureInfo.InvariantCulture, "{0}", new object[1] { text });
					}
					continue;
				}
				throw new ClientQueryException("One of the categories could not be persisted to a string");
			}
			if (A_0.Length > length && CategoryQueriesAsParameter)
			{
				return '&';
			}
			return A_1;
		}

		protected static char AppendQueryPart(string value, string parameterName, char connect, StringBuilder builder)
		{
			if (builder == null)
			{
				throw new ArgumentNullException("builder");
			}
			if (builder.ToString().IndexOf(parameterName + "=") == -1 && Utilities.IsPersistable(value))
			{
				builder.Append(connect);
				builder.AppendFormat(CultureInfo.InvariantCulture, parameterName + "={0}", new object[1] { Utilities.UriEncodeReserved(value) });
				connect = '&';
			}
			return connect;
		}

		protected static char AppendQueryPart(int value, int defValue, string parameterName, char connect, StringBuilder builder)
		{
			if (builder == null)
			{
				throw new ArgumentNullException("builder");
			}
			if (builder.ToString().IndexOf(parameterName + "=") == -1 && value != defValue)
			{
				builder.Append(connect);
				builder.AppendFormat(CultureInfo.InvariantCulture, parameterName + "={0:d}", new object[1] { value });
				connect = '&';
			}
			return connect;
		}

		[CLSCompliant(false)]
		protected static char AppendQueryPart(uint value, uint defValue, string parameterName, char connect, StringBuilder builder)
		{
			if (builder == null)
			{
				throw new ArgumentNullException("builder");
			}
			if (builder.ToString().IndexOf(parameterName + "=") == -1 && value != defValue)
			{
				builder.Append(connect);
				builder.AppendFormat(CultureInfo.InvariantCulture, parameterName + "={0:d}", new object[1] { value });
				connect = '&';
			}
			return connect;
		}

		protected static char AppendQueryPart(DateTime value, string parameterName, char connect, StringBuilder builder)
		{
			if (builder == null)
			{
				throw new ArgumentNullException("builder");
			}
			if (builder.ToString().IndexOf(parameterName + "=") == -1 && Utilities.IsPersistable(value))
			{
				return AppendQueryPart(Utilities.LocalDateTimeInUTC(value), parameterName, connect, builder);
			}
			return connect;
		}

		protected static string FormatToString(AlternativeFormat format)
		{
			return format switch
			{
				AlternativeFormat.Atom => "atom", 
				AlternativeFormat.Rss => "rss", 
				AlternativeFormat.OpenSearchRss => "osrss", 
				_ => null, 
			};
		}
	}
}
