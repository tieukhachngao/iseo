using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Xml;

namespace Google.GData.Client
{
	public sealed class Utilities
	{
		public const string XSDTrue = "true";

		public const string XSDFalse = "false";

		public const string DefaultUser = "default";

		public static DateTime EmptyDate => new DateTime(1, 1, 1);

		private Utilities()
		{
		}

		public static bool IsPersistable(string toPersist)
		{
			if (!string.IsNullOrEmpty(toPersist) && toPersist.Trim().Length != 0)
			{
				return true;
			}
			return false;
		}

		public static bool IsPersistable(AtomUri uriString)
		{
			if (!(uriString == null))
			{
				return IsPersistable(uriString.ToString());
			}
			return false;
		}

		public static bool IsPersistable(int number)
		{
			if (number != 0)
			{
				return true;
			}
			return false;
		}

		public static bool IsPersistable(DateTime testDate)
		{
			if (!(testDate == EmptyDate))
			{
				return true;
			}
			return false;
		}

		public static string ConvertBooleanToXSDString(bool flag)
		{
			if (!flag)
			{
				return "false";
			}
			return "true";
		}

		public static string ConvertToXSDString(object obj)
		{
			if (obj is bool)
			{
				return ConvertBooleanToXSDString((bool)obj);
			}
			return Convert.ToString(obj, CultureInfo.InvariantCulture);
		}

		public static string EncodeString(string content)
		{
			Encoding uTF = Encoding.UTF8;
			byte[] array = EncodeStringToUtf8(content);
			char[] array2 = new char[uTF.GetCharCount(array, 0, array.Length)];
			uTF.GetChars(array, 0, array.Length, array2, 0);
			return new string(array2);
		}

		public static byte[] EncodeStringToUtf8(string content)
		{
			Encoding uTF = Encoding.UTF8;
			Encoding unicode = Encoding.Unicode;
			byte[] bytes = unicode.GetBytes(content);
			return Encoding.Convert(unicode, uTF, bytes);
		}

		public static string EncodeSlugHeader(string slug)
		{
			if (slug == null)
			{
				return "";
			}
			byte[] array = EncodeStringToUtf8(slug);
			if (array == null)
			{
				return "";
			}
			StringBuilder stringBuilder = new StringBuilder(256);
			byte[] array2 = array;
			foreach (byte b in array2)
			{
				if (b >= 32 && b != 37 && b <= 126)
				{
					stringBuilder.Append((char)b);
					continue;
				}
				stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "%{0:X}", new object[1] { b });
			}
			return stringBuilder.ToString();
		}

		public static string DecodedValue(string value)
		{
			return HttpUtility.HtmlDecode(value);
		}

		public static string UrlDecodedValue(string value)
		{
			return HttpUtility.UrlDecode(value);
		}

		public static string UriEncodeReserved(string content)
		{
			if (content == null)
			{
				return null;
			}
			StringBuilder stringBuilder = new StringBuilder(256);
			foreach (char c in content)
			{
				if (c != ';' && c != '/' && c != '?' && c != ':' && c != '@' && c != '&' && c != '=' && c != '+' && c != '$' && c != ',' && c != '#' && c != '%')
				{
					stringBuilder.Append(c);
				}
				else
				{
					stringBuilder.Append(Uri.HexEscape(c));
				}
			}
			return stringBuilder.ToString();
		}

		public static bool IsWeakETag(string eTag)
		{
			return eTag?.StartsWith("W/") ?? true;
		}

		public static bool IsWeakETag(ISupportsEtag ise)
		{
			string eTag = null;
			if (ise != null)
			{
				eTag = ise.Etag;
			}
			return IsWeakETag(eTag);
		}

		public static string UriEncodeUnsafe(string content)
		{
			if (content == null)
			{
				return null;
			}
			StringBuilder stringBuilder = new StringBuilder(256);
			foreach (char c in content)
			{
				if (c != ';' && c != '/' && c != '?' && c != ':' && c != '@' && c != '&' && c != '=' && c != '+' && c != '$' && c != ',' && c != ' ' && c != '\'' && c != '"' && c != '>' && c != '<' && c != '#' && c != '%')
				{
					stringBuilder.Append(c);
				}
				else
				{
					stringBuilder.Append(Uri.HexEscape(c));
				}
			}
			return stringBuilder.ToString();
		}

		public static string LocalDateInUTC(DateTime dateTime)
		{
			return dateTime.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
		}

		public static string LocalDateTimeInUTC(DateTime dateTime)
		{
			TimeSpan utcOffset = TimeZone.CurrentTimeZone.GetUtcOffset(dateTime);
			string text = dateTime.ToString("s", CultureInfo.InvariantCulture);
			return text + FormatTimeOffset(utcOffset);
		}

		public static bool NextChildElement(XmlReader reader, ref int depth)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			if (reader.Depth == depth)
			{
				return false;
			}
			if (reader.NodeType == XmlNodeType.Element && depth >= 0 && reader.Depth > depth)
			{
				return true;
			}
			if (depth == -1)
			{
				depth = reader.Depth;
			}
			do
			{
				if (reader.Read())
				{
					if (reader.NodeType != XmlNodeType.EndElement || reader.Depth > depth)
					{
						if (reader.NodeType == XmlNodeType.Element && reader.Depth > depth)
						{
							return true;
						}
						continue;
					}
					return false;
				}
				return !reader.EOF;
			}
			while (reader.NodeType != XmlNodeType.Element || reader.Depth != depth);
			return false;
		}

		public static string FormatTimeOffset(TimeSpan spanFromUtc)
		{
			if (spanFromUtc == TimeSpan.Zero)
			{
				return "Z";
			}
			TimeSpan a_ = spanFromUtc.Duration();
			if (spanFromUtc > TimeSpan.Zero)
			{
				return "+" + smethod_0(a_);
			}
			return "-" + smethod_0(a_);
		}

		internal static string smethod_0(TimeSpan A_0)
		{
			return string.Format(CultureInfo.InvariantCulture, "{0:00}:{1:00}", new object[2] { A_0.Hours, A_0.Minutes });
		}

		internal static string smethod_1(AtomUri A_0, AtomUri A_1, string A_2)
		{
			try
			{
				Uri uri = null;
				Uri uri2 = null;
				Uri uri3 = null;
				if (A_1 != null && A_1.ToString() != null)
				{
					uri2 = new Uri(A_1.ToString());
				}
				uri = ((!(A_0 != null) || A_0.ToString() == null) ? uri2 : ((!(uri2 != null)) ? new Uri(A_0.ToString()) : new Uri(uri2, A_0.ToString())));
				uri3 = ((A_2 == null) ? uri : ((!(uri != null)) ? new Uri(A_2.ToString()) : new Uri(uri, A_2.ToString())));
				return (uri3 != null) ? uri3.AbsoluteUri : null;
			}
			catch (UriFormatException)
			{
				return "Unsupported URI format";
			}
		}

		public static string EnsureAtomNamespace(XmlWriter writer)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			string text = writer.LookupPrefix("http://www.w3.org/2005/Atom");
			if (text == null)
			{
				writer.WriteAttributeString("xmlns", null, "http://www.w3.org/2005/Atom");
			}
			return text;
		}

		public static string EnsureGDataNamespace(XmlWriter writer)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			string text = writer.LookupPrefix("http://schemas.google.com/g/2005");
			if (text == null)
			{
				writer.WriteAttributeString("xmlns", "gd", null, "http://schemas.google.com/g/2005");
			}
			return text;
		}

		public static string EnsureGDataBatchNamespace(XmlWriter writer)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			string text = writer.LookupPrefix("http://schemas.google.com/gdata/batch");
			if (text == null)
			{
				writer.WriteAttributeString("xmlns", "batch", null, "http://schemas.google.com/gdata/batch");
			}
			return text;
		}

		public static string FindToken(TokenCollection tokens, string key)
		{
			if (tokens == null)
			{
				throw new ArgumentNullException("tokens");
			}
			string result = null;
			bool flag = false;
			foreach (string token in tokens)
			{
				if (!flag)
				{
					if (key == token)
					{
						flag = true;
					}
					continue;
				}
				return token;
			}
			return result;
		}

		public static TokenCollection ParseStreamInTokenCollection(Stream inputStream)
		{
			ASCIIEncoding encoding = new ASCIIEncoding();
			StreamReader streamReader = new StreamReader(inputStream, encoding);
			string source = streamReader.ReadToEnd();
			streamReader.Close();
			return new TokenCollection(source, '=', separateLines: true, 2);
		}

		public static string ParseValueFormStream(Stream inputStream, string key)
		{
			TokenCollection tokens = ParseStreamInTokenCollection(inputStream);
			return FindToken(tokens, key);
		}

		public static IExtensionElementFactory FindExtension(ExtensionList arrList, string localName, string ns)
		{
			if (arrList == null)
			{
				return null;
			}
			foreach (IExtensionElementFactory arr in arrList)
			{
				if (smethod_2(arr.XmlName, localName, arr.XmlNameSpace, ns))
				{
					return arr;
				}
			}
			return null;
		}

		public static ExtensionList FindExtensions(ExtensionList arrList, string localName, string ns, ExtensionList arr)
		{
			if (arrList == null)
			{
				throw new ArgumentNullException("arrList");
			}
			if (arr == null)
			{
				throw new ArgumentNullException("arr");
			}
			foreach (IExtensionElementFactory arr2 in arrList)
			{
				XmlNode xmlNode = arr2 as XmlNode;
				if (xmlNode != null)
				{
					if (smethod_2(xmlNode.LocalName, localName, xmlNode.NamespaceURI, ns))
					{
						arr.Add(arr2);
					}
					continue;
				}
				IExtensionElementFactory extensionElementFactory = arr2;
				if (extensionElementFactory != null && smethod_2(extensionElementFactory.XmlName, localName, extensionElementFactory.XmlNameSpace, ns))
				{
					arr.Add(arr2);
				}
			}
			return arr;
		}

		public static List<T> FindExtensions<T>(ExtensionList arrList, string localName, string ns)
		{
			List<T> list = new List<T>();
			if (arrList == null)
			{
				throw new ArgumentNullException("arrList");
			}
			foreach (IExtensionElementFactory arr in arrList)
			{
				if (arr is T)
				{
					T val = (T)arr;
					if (val != null && smethod_2(((IExtensionElementFactory)val).XmlName, localName, ((IExtensionElementFactory)val).XmlNameSpace, ns))
					{
						list.Add(val);
					}
				}
			}
			return list;
		}

		public static string GetAttributeValue(string attributeName, XmlNode xmlNode)
		{
			if (xmlNode != null && attributeName != null && xmlNode.Attributes != null && xmlNode.Attributes[attributeName] != null)
			{
				return xmlNode.Attributes[attributeName].Value;
			}
			return null;
		}

		public static string GetAssemblyVersion()
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			if ((object)executingAssembly != null)
			{
				string[] array = executingAssembly.FullName.Split(',');
				if (array != null && array.Length > 1)
				{
					return array[1].Trim();
				}
			}
			return "1.0.0";
		}

		public static string ConstructUserAgent(string applicationName, string serviceName)
		{
			return "G-" + applicationName + "/" + serviceName + "-CS-" + GetAssemblyVersion();
		}

		private static bool smethod_2(string A_0, string A_1, string A_2, string A_3)
		{
			if (string.Compare(A_0, A_1) == 0)
			{
				if (A_2 == null)
				{
					return true;
				}
				if (string.Compare(A_2, A_3) == 0)
				{
					return true;
				}
			}
			return false;
		}

		public static string QueryClientLoginToken(GDataCredentials gc, string serviceName, string applicationName, bool fUseKeepAlive, Uri clientLoginHandler)
		{
			return QueryClientLoginToken(gc, serviceName, applicationName, fUseKeepAlive, null, clientLoginHandler);
		}

		public static string QueryClientLoginToken(GDataCredentials gc, string serviceName, string applicationName, bool fUseKeepAlive, IWebProxy proxyServer, Uri clientLoginHandler)
		{
			if (gc == null)
			{
				throw new ArgumentNullException("nc", "No credentials supplied");
			}
			HttpWebRequest httpWebRequest = WebRequest.Create(clientLoginHandler) as HttpWebRequest;
			httpWebRequest.KeepAlive = fUseKeepAlive;
			if (proxyServer != null)
			{
				httpWebRequest.Proxy = proxyServer;
			}
			string text = "accountType=";
			text = (string.IsNullOrEmpty(gc.AccountType) ? (text + "HOSTED_OR_GOOGLE") : (text + gc.AccountType));
			WebResponse webResponse = null;
			HttpWebResponse httpWebResponse = null;
			string text2 = null;
			try
			{
				httpWebRequest.ContentType = "application/x-www-form-urlencoded";
				httpWebRequest.Method = "POST";
				ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
				string content = ((gc.Username == null) ? "" : gc.Username);
				string content2 = ((gc.method_0() == null) ? "" : gc.method_0());
				string text3 = "Email=" + UriEncodeUnsafe(content) + "&";
				text3 = text3 + "Passwd=" + UriEncodeUnsafe(content2) + "&";
				text3 = text3 + "source=" + UriEncodeUnsafe(applicationName) + "&";
				text3 = text3 + "service=" + UriEncodeUnsafe(serviceName) + "&";
				if (gc.CaptchaAnswer != null)
				{
					text3 = text3 + "logincaptcha=" + UriEncodeUnsafe(gc.CaptchaAnswer) + "&";
				}
				if (gc.CaptchaToken != null)
				{
					text3 = text3 + "logintoken=" + UriEncodeUnsafe(gc.CaptchaToken) + "&";
				}
				text3 += text;
				byte[] bytes = aSCIIEncoding.GetBytes(text3);
				httpWebRequest.ContentLength = bytes.Length;
				Stream requestStream = httpWebRequest.GetRequestStream();
				requestStream.Write(bytes, 0, bytes.Length);
				requestStream.Close();
				webResponse = httpWebRequest.GetResponse();
				httpWebResponse = webResponse as HttpWebResponse;
			}
			catch (WebException ex)
			{
				httpWebResponse = ex.Response as HttpWebResponse;
				if (httpWebResponse == null)
				{
					throw;
				}
			}
			if (httpWebResponse != null)
			{
				if (!httpWebResponse.ContentType.StartsWith("text"))
				{
					throw new GDataRequestException("Execution of authentication request returned unexpected content type: " + httpWebResponse.ContentType, httpWebResponse);
				}
				TokenCollection tokenCollection = ParseStreamInTokenCollection(httpWebResponse.GetResponseStream());
				text2 = FindToken(tokenCollection, "Auth");
				if (text2 == null)
				{
					throw smethod_3(tokenCollection, httpWebResponse);
				}
				int statusCode = (int)httpWebResponse.StatusCode;
				if (statusCode != 200)
				{
					throw new GDataRequestException("Execution of authentication request returned unexpected result: " + statusCode, httpWebResponse);
				}
			}
			webResponse?.Close();
			return text2;
		}

		private static LoggedException smethod_3(TokenCollection A_0, HttpWebResponse A_1)
		{
			string text = FindToken(A_0, "Error");
			int statusCode = (int)A_1.StatusCode;
			if (text != null && text.Length != 0)
			{
				if ("BadAuthentication".Equals(text))
				{
					return new InvalidCredentialsException("Invalid credentials");
				}
				if ("AccountDeleted".Equals(text))
				{
					return new AccountDeletedException("Account deleted");
				}
				if ("AccountDisabled".Equals(text))
				{
					return new AccountDisabledException("Account disabled");
				}
				if ("NotVerified".Equals(text))
				{
					return new NotVerifiedException("Not verified");
				}
				if ("TermsNotAgreed".Equals(text))
				{
					return new TermsNotAgreedException("Terms not agreed");
				}
				if ("ServiceUnavailable".Equals(text))
				{
					return new ServiceUnavailableException("Service unavailable");
				}
				if ("CaptchaRequired".Equals(text))
				{
					string value = FindToken(A_0, "CaptchaUrl");
					string token = FindToken(A_0, "CaptchaToken");
					StringBuilder stringBuilder = new StringBuilder();
					stringBuilder.Append("https").Append("://");
					stringBuilder.Append("www.google.com");
					stringBuilder.Append("/accounts");
					stringBuilder.Append('/').Append(value);
					return new CaptchaRequiredException("Captcha required", stringBuilder.ToString(), token);
				}
				return new AuthenticationException("Error authenticating (check service name): " + text);
			}
			throw new GDataRequestException("Execution of authentication request returned unexpected result: " + statusCode, A_1);
		}
	}
}
