using System;
using System.Collections;
using System.Collections.Specialized;
using System.IO;
using System.Security.Permissions;
using System.Text;
using System.Web;

namespace Google.GData.Client
{
	[AspNetHostingPermission(SecurityAction.LinkDemand, Level = AspNetHostingPermissionLevel.Minimal)]
	public sealed class HttpUtility
	{
		private static Hashtable hashtable_0;

		private static object object_0 = new object();

		private static char[] char_0 = "0123456789abcdef".ToCharArray();

		private static Hashtable Entities
		{
			get
			{
				lock (object_0)
				{
					if (hashtable_0 == null)
					{
						smethod_0();
					}
					return hashtable_0;
				}
			}
		}

		private static void smethod_0()
		{
			hashtable_0 = new Hashtable();
			hashtable_0.Add("nbsp", '\u00a0');
			hashtable_0.Add("iexcl", '¡');
			hashtable_0.Add("cent", '¢');
			hashtable_0.Add("pound", '£');
			hashtable_0.Add("curren", '¤');
			hashtable_0.Add("yen", '¥');
			hashtable_0.Add("brvbar", '¦');
			hashtable_0.Add("sect", '§');
			hashtable_0.Add("uml", '\u00a8');
			hashtable_0.Add("copy", '©');
			hashtable_0.Add("ordf", 'ª');
			hashtable_0.Add("laquo", '«');
			hashtable_0.Add("not", '¬');
			hashtable_0.Add("shy", '­');
			hashtable_0.Add("reg", '®');
			hashtable_0.Add("macr", '\u00af');
			hashtable_0.Add("deg", '°');
			hashtable_0.Add("plusmn", '±');
			hashtable_0.Add("sup2", '²');
			hashtable_0.Add("sup3", '³');
			hashtable_0.Add("acute", '\u00b4');
			hashtable_0.Add("micro", 'µ');
			hashtable_0.Add("para", '¶');
			hashtable_0.Add("middot", '·');
			hashtable_0.Add("cedil", '\u00b8');
			hashtable_0.Add("sup1", '¹');
			hashtable_0.Add("ordm", 'º');
			hashtable_0.Add("raquo", '»');
			hashtable_0.Add("frac14", '¼');
			hashtable_0.Add("frac12", '½');
			hashtable_0.Add("frac34", '¾');
			hashtable_0.Add("iquest", '¿');
			hashtable_0.Add("Agrave", 'À');
			hashtable_0.Add("Aacute", 'Á');
			hashtable_0.Add("Acirc", 'Â');
			hashtable_0.Add("Atilde", 'Ã');
			hashtable_0.Add("Auml", 'Ä');
			hashtable_0.Add("Aring", 'Å');
			hashtable_0.Add("AElig", 'Æ');
			hashtable_0.Add("Ccedil", 'Ç');
			hashtable_0.Add("Egrave", 'È');
			hashtable_0.Add("Eacute", 'É');
			hashtable_0.Add("Ecirc", 'Ê');
			hashtable_0.Add("Euml", 'Ë');
			hashtable_0.Add("Igrave", 'Ì');
			hashtable_0.Add("Iacute", 'Í');
			hashtable_0.Add("Icirc", 'Î');
			hashtable_0.Add("Iuml", 'Ï');
			hashtable_0.Add("ETH", 'Ð');
			hashtable_0.Add("Ntilde", 'Ñ');
			hashtable_0.Add("Ograve", 'Ò');
			hashtable_0.Add("Oacute", 'Ó');
			hashtable_0.Add("Ocirc", 'Ô');
			hashtable_0.Add("Otilde", 'Õ');
			hashtable_0.Add("Ouml", 'Ö');
			hashtable_0.Add("times", '×');
			hashtable_0.Add("Oslash", 'Ø');
			hashtable_0.Add("Ugrave", 'Ù');
			hashtable_0.Add("Uacute", 'Ú');
			hashtable_0.Add("Ucirc", 'Û');
			hashtable_0.Add("Uuml", 'Ü');
			hashtable_0.Add("Yacute", 'Ý');
			hashtable_0.Add("THORN", 'Þ');
			hashtable_0.Add("szlig", 'ß');
			hashtable_0.Add("agrave", 'à');
			hashtable_0.Add("aacute", 'á');
			hashtable_0.Add("acirc", 'â');
			hashtable_0.Add("atilde", 'ã');
			hashtable_0.Add("auml", 'ä');
			hashtable_0.Add("aring", 'å');
			hashtable_0.Add("aelig", 'æ');
			hashtable_0.Add("ccedil", 'ç');
			hashtable_0.Add("egrave", 'è');
			hashtable_0.Add("eacute", 'é');
			hashtable_0.Add("ecirc", 'ê');
			hashtable_0.Add("euml", 'ë');
			hashtable_0.Add("igrave", 'ì');
			hashtable_0.Add("iacute", 'í');
			hashtable_0.Add("icirc", 'î');
			hashtable_0.Add("iuml", 'ï');
			hashtable_0.Add("eth", 'ð');
			hashtable_0.Add("ntilde", 'ñ');
			hashtable_0.Add("ograve", 'ò');
			hashtable_0.Add("oacute", 'ó');
			hashtable_0.Add("ocirc", 'ô');
			hashtable_0.Add("otilde", 'õ');
			hashtable_0.Add("ouml", 'ö');
			hashtable_0.Add("divide", '÷');
			hashtable_0.Add("oslash", 'ø');
			hashtable_0.Add("ugrave", 'ù');
			hashtable_0.Add("uacute", 'ú');
			hashtable_0.Add("ucirc", 'û');
			hashtable_0.Add("uuml", 'ü');
			hashtable_0.Add("yacute", 'ý');
			hashtable_0.Add("thorn", 'þ');
			hashtable_0.Add("yuml", 'ÿ');
			hashtable_0.Add("fnof", 'ƒ');
			hashtable_0.Add("Alpha", 'Α');
			hashtable_0.Add("Beta", 'Β');
			hashtable_0.Add("Gamma", 'Γ');
			hashtable_0.Add("Delta", 'Δ');
			hashtable_0.Add("Epsilon", 'Ε');
			hashtable_0.Add("Zeta", 'Ζ');
			hashtable_0.Add("Eta", 'Η');
			hashtable_0.Add("Theta", 'Θ');
			hashtable_0.Add("Iota", 'Ι');
			hashtable_0.Add("Kappa", 'Κ');
			hashtable_0.Add("Lambda", 'Λ');
			hashtable_0.Add("Mu", 'Μ');
			hashtable_0.Add("Nu", 'Ν');
			hashtable_0.Add("Xi", 'Ξ');
			hashtable_0.Add("Omicron", 'Ο');
			hashtable_0.Add("Pi", 'Π');
			hashtable_0.Add("Rho", 'Ρ');
			hashtable_0.Add("Sigma", 'Σ');
			hashtable_0.Add("Tau", 'Τ');
			hashtable_0.Add("Upsilon", 'Υ');
			hashtable_0.Add("Phi", 'Φ');
			hashtable_0.Add("Chi", 'Χ');
			hashtable_0.Add("Psi", 'Ψ');
			hashtable_0.Add("Omega", 'Ω');
			hashtable_0.Add("alpha", 'α');
			hashtable_0.Add("beta", 'β');
			hashtable_0.Add("gamma", 'γ');
			hashtable_0.Add("delta", 'δ');
			hashtable_0.Add("epsilon", 'ε');
			hashtable_0.Add("zeta", 'ζ');
			hashtable_0.Add("eta", 'η');
			hashtable_0.Add("theta", 'θ');
			hashtable_0.Add("iota", 'ι');
			hashtable_0.Add("kappa", 'κ');
			hashtable_0.Add("lambda", 'λ');
			hashtable_0.Add("mu", 'μ');
			hashtable_0.Add("nu", 'ν');
			hashtable_0.Add("xi", 'ξ');
			hashtable_0.Add("omicron", 'ο');
			hashtable_0.Add("pi", 'π');
			hashtable_0.Add("rho", 'ρ');
			hashtable_0.Add("sigmaf", 'ς');
			hashtable_0.Add("sigma", 'σ');
			hashtable_0.Add("tau", 'τ');
			hashtable_0.Add("upsilon", 'υ');
			hashtable_0.Add("phi", 'φ');
			hashtable_0.Add("chi", 'χ');
			hashtable_0.Add("psi", 'ψ');
			hashtable_0.Add("omega", 'ω');
			hashtable_0.Add("thetasym", 'ϑ');
			hashtable_0.Add("upsih", 'ϒ');
			hashtable_0.Add("piv", 'ϖ');
			hashtable_0.Add("bull", '•');
			hashtable_0.Add("hellip", '…');
			hashtable_0.Add("prime", '′');
			hashtable_0.Add("Prime", '″');
			hashtable_0.Add("oline", '‾');
			hashtable_0.Add("frasl", '⁄');
			hashtable_0.Add("weierp", '℘');
			hashtable_0.Add("image", 'ℑ');
			hashtable_0.Add("real", 'ℜ');
			hashtable_0.Add("trade", '™');
			hashtable_0.Add("alefsym", 'ℵ');
			hashtable_0.Add("larr", '←');
			hashtable_0.Add("uarr", '↑');
			hashtable_0.Add("rarr", '→');
			hashtable_0.Add("darr", '↓');
			hashtable_0.Add("harr", '↔');
			hashtable_0.Add("crarr", '↵');
			hashtable_0.Add("lArr", '⇐');
			hashtable_0.Add("uArr", '⇑');
			hashtable_0.Add("rArr", '⇒');
			hashtable_0.Add("dArr", '⇓');
			hashtable_0.Add("hArr", '⇔');
			hashtable_0.Add("forall", '∀');
			hashtable_0.Add("part", '∂');
			hashtable_0.Add("exist", '∃');
			hashtable_0.Add("empty", '∅');
			hashtable_0.Add("nabla", '∇');
			hashtable_0.Add("isin", '∈');
			hashtable_0.Add("notin", '∉');
			hashtable_0.Add("ni", '∋');
			hashtable_0.Add("prod", '∏');
			hashtable_0.Add("sum", '∑');
			hashtable_0.Add("minus", '−');
			hashtable_0.Add("lowast", '∗');
			hashtable_0.Add("radic", '√');
			hashtable_0.Add("prop", '∝');
			hashtable_0.Add("infin", '∞');
			hashtable_0.Add("ang", '∠');
			hashtable_0.Add("and", '∧');
			hashtable_0.Add("or", '∨');
			hashtable_0.Add("cap", '∩');
			hashtable_0.Add("cup", '∪');
			hashtable_0.Add("int", '∫');
			hashtable_0.Add("there4", '∴');
			hashtable_0.Add("sim", '∼');
			hashtable_0.Add("cong", '≅');
			hashtable_0.Add("asymp", '≈');
			hashtable_0.Add("ne", '≠');
			hashtable_0.Add("equiv", '≡');
			hashtable_0.Add("le", '≤');
			hashtable_0.Add("ge", '≥');
			hashtable_0.Add("sub", '⊂');
			hashtable_0.Add("sup", '⊃');
			hashtable_0.Add("nsub", '⊄');
			hashtable_0.Add("sube", '⊆');
			hashtable_0.Add("supe", '⊇');
			hashtable_0.Add("oplus", '⊕');
			hashtable_0.Add("otimes", '⊗');
			hashtable_0.Add("perp", '⊥');
			hashtable_0.Add("sdot", '⋅');
			hashtable_0.Add("lceil", '⌈');
			hashtable_0.Add("rceil", '⌉');
			hashtable_0.Add("lfloor", '⌊');
			hashtable_0.Add("rfloor", '⌋');
			hashtable_0.Add("lang", '〈');
			hashtable_0.Add("rang", '〉');
			hashtable_0.Add("loz", '◊');
			hashtable_0.Add("spades", '♠');
			hashtable_0.Add("clubs", '♣');
			hashtable_0.Add("hearts", '♥');
			hashtable_0.Add("diams", '♦');
			hashtable_0.Add("quot", '"');
			hashtable_0.Add("amp", '&');
			hashtable_0.Add("lt", '<');
			hashtable_0.Add("gt", '>');
			hashtable_0.Add("OElig", 'Œ');
			hashtable_0.Add("oelig", 'œ');
			hashtable_0.Add("Scaron", 'Š');
			hashtable_0.Add("scaron", 'š');
			hashtable_0.Add("Yuml", 'Ÿ');
			hashtable_0.Add("circ", 'ˆ');
			hashtable_0.Add("tilde", '\u02dc');
			hashtable_0.Add("ensp", '\u2002');
			hashtable_0.Add("emsp", '\u2003');
			hashtable_0.Add("thinsp", '\u2009');
			hashtable_0.Add("zwnj", '\u200c');
			hashtable_0.Add("zwj", '\u200d');
			hashtable_0.Add("lrm", '\u200e');
			hashtable_0.Add("rlm", '\u200f');
			hashtable_0.Add("ndash", '–');
			hashtable_0.Add("mdash", '—');
			hashtable_0.Add("lsquo", '‘');
			hashtable_0.Add("rsquo", '’');
			hashtable_0.Add("sbquo", '‚');
			hashtable_0.Add("ldquo", '“');
			hashtable_0.Add("rdquo", '”');
			hashtable_0.Add("bdquo", '„');
			hashtable_0.Add("dagger", '†');
			hashtable_0.Add("Dagger", '‡');
			hashtable_0.Add("permil", '‰');
			hashtable_0.Add("lsaquo", '‹');
			hashtable_0.Add("rsaquo", '›');
			hashtable_0.Add("euro", '€');
		}

		public static void HtmlAttributeEncode(string s, TextWriter output)
		{
			output.Write(HtmlAttributeEncode(s));
		}

		public static string HtmlAttributeEncode(string s)
		{
			if (s == null)
			{
				return null;
			}
			bool flag = false;
			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] == '&' || s[i] == '"' || s[i] == '<')
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return s;
			}
			StringBuilder stringBuilder = new StringBuilder();
			int length = s.Length;
			for (int j = 0; j < length; j++)
			{
				switch (s[j])
				{
				default:
					stringBuilder.Append(s[j]);
					break;
				case '<':
					stringBuilder.Append("&lt;");
					break;
				case '&':
					stringBuilder.Append("&amp;");
					break;
				case '"':
					stringBuilder.Append("&quot;");
					break;
				}
			}
			return stringBuilder.ToString();
		}

		public static string UrlDecode(string str)
		{
			return UrlDecode(str, Encoding.UTF8);
		}

		private static char[] smethod_1(MemoryStream A_0, Encoding A_1)
		{
			return A_1.GetChars(A_0.GetBuffer(), 0, (int)A_0.Length);
		}

		private static void smethod_2(IList A_0, char A_1, Encoding A_2)
		{
			if (A_1 > 'ÿ')
			{
				byte[] bytes = A_2.GetBytes(new char[1] { A_1 });
				foreach (byte b in bytes)
				{
					A_0.Add(b);
				}
			}
			else
			{
				A_0.Add((byte)A_1);
			}
		}

		public static string UrlDecode(string s, Encoding e)
		{
			if (s == null)
			{
				return null;
			}
			if (s.IndexOf('%') == -1 && s.IndexOf('+') == -1)
			{
				return s;
			}
			if (e == null)
			{
				e = Encoding.UTF8;
			}
			long num = s.Length;
			ArrayList arrayList = new ArrayList();
			for (int i = 0; i < num; i++)
			{
				char c = s[i];
				if (c == '%' && i + 2 < num && s[i + 1] != '%')
				{
					int num2;
					if (s[i + 1] == 'u' && i + 5 < num)
					{
						num2 = smethod_5(s, i + 2, 4);
						if (num2 != -1)
						{
							smethod_2(arrayList, (char)num2, e);
							i += 5;
						}
						else
						{
							smethod_2(arrayList, '%', e);
						}
					}
					else if ((num2 = smethod_5(s, i + 1, 2)) != -1)
					{
						smethod_2(arrayList, (char)num2, e);
						i += 2;
					}
					else
					{
						smethod_2(arrayList, '%', e);
					}
				}
				else if (c == '+')
				{
					smethod_2(arrayList, ' ', e);
				}
				else
				{
					smethod_2(arrayList, c, e);
				}
			}
			byte[] bytes = (byte[])arrayList.ToArray(typeof(byte));
			arrayList = null;
			return e.GetString(bytes);
		}

		public static string UrlDecode(byte[] bytes, Encoding e)
		{
			if (bytes == null)
			{
				return null;
			}
			return UrlDecode(bytes, 0, bytes.Length, e);
		}

		private static int smethod_3(byte A_0)
		{
			char c = (char)A_0;
			if (c >= '0' && c <= '9')
			{
				return c - 48;
			}
			if (c >= 'a' && c <= 'f')
			{
				return c - 97 + 10;
			}
			if (c >= 'A' && c <= 'F')
			{
				return c - 65 + 10;
			}
			return -1;
		}

		private static int smethod_4(byte[] A_0, int A_1, int A_2)
		{
			int num = 0;
			int num2 = A_2 + A_1;
			int num3 = A_1;
			while (true)
			{
				if (num3 < num2)
				{
					int num4 = smethod_3(A_0[num3]);
					if (num4 == -1)
					{
						break;
					}
					num = (num << 4) + num4;
					num3++;
					continue;
				}
				return num;
			}
			return -1;
		}

		private static int smethod_5(string A_0, int A_1, int A_2)
		{
			int num = 0;
			int num2 = A_2 + A_1;
			int num3 = A_1;
			while (true)
			{
				if (num3 < num2)
				{
					char c = A_0[num3];
					if (c <= '\u007f')
					{
						int num4 = smethod_3((byte)c);
						if (num4 == -1)
						{
							break;
						}
						num = (num << 4) + num4;
						num3++;
						continue;
					}
					return -1;
				}
				return num;
			}
			return -1;
		}

		public static string UrlDecode(byte[] bytes, int offset, int count, Encoding e)
		{
			if (bytes == null)
			{
				return null;
			}
			if (count == 0)
			{
				return string.Empty;
			}
			if (bytes == null)
			{
				throw new ArgumentNullException("bytes");
			}
			if (offset >= 0 && offset <= bytes.Length)
			{
				if (count >= 0 && offset + count <= bytes.Length)
				{
					StringBuilder stringBuilder = new StringBuilder();
					MemoryStream memoryStream = new MemoryStream();
					int num = count + offset;
					for (int i = offset; i < num; i++)
					{
						if (bytes[i] == 37 && i + 2 < count && bytes[i + 1] != 37)
						{
							int num2;
							if (bytes[i + 1] == 117 && i + 5 < num)
							{
								if (memoryStream.Length > 0L)
								{
									stringBuilder.Append(smethod_1(memoryStream, e));
									memoryStream.SetLength(0L);
								}
								num2 = smethod_4(bytes, i + 2, 4);
								if (num2 != -1)
								{
									stringBuilder.Append((char)num2);
									i += 5;
									continue;
								}
							}
							else if ((num2 = smethod_4(bytes, i + 1, 2)) != -1)
							{
								memoryStream.WriteByte((byte)num2);
								i += 2;
								continue;
							}
						}
						if (memoryStream.Length > 0L)
						{
							stringBuilder.Append(smethod_1(memoryStream, e));
							memoryStream.SetLength(0L);
						}
						if (bytes[i] == 43)
						{
							stringBuilder.Append(' ');
						}
						else
						{
							stringBuilder.Append((char)bytes[i]);
						}
					}
					if (memoryStream.Length > 0L)
					{
						stringBuilder.Append(smethod_1(memoryStream, e));
					}
					memoryStream = null;
					return stringBuilder.ToString();
				}
				throw new ArgumentOutOfRangeException("count");
			}
			throw new ArgumentOutOfRangeException("offset");
		}

		public static byte[] UrlDecodeToBytes(byte[] bytes)
		{
			if (bytes == null)
			{
				return null;
			}
			return UrlDecodeToBytes(bytes, 0, bytes.Length);
		}

		public static byte[] UrlDecodeToBytes(string str)
		{
			return UrlDecodeToBytes(str, Encoding.UTF8);
		}

		public static byte[] UrlDecodeToBytes(string str, Encoding e)
		{
			if (str == null)
			{
				return null;
			}
			if (e == null)
			{
				throw new ArgumentNullException("e");
			}
			return UrlDecodeToBytes(e.GetBytes(str));
		}

		public static byte[] UrlDecodeToBytes(byte[] bytes, int offset, int count)
		{
			if (bytes == null)
			{
				return null;
			}
			if (count == 0)
			{
				return new byte[0];
			}
			int num = bytes.Length;
			if (offset >= 0 && offset < num)
			{
				if (count >= 0 && offset <= num - count)
				{
					MemoryStream memoryStream = new MemoryStream();
					int num2 = offset + count;
					for (int i = offset; i < num2; i++)
					{
						char c = (char)bytes[i];
						switch (c)
						{
						case '+':
							c = ' ';
							break;
						case '%':
							if (i < num2 - 2)
							{
								int num3 = smethod_4(bytes, i + 1, 2);
								if (num3 != -1)
								{
									c = (char)num3;
									i += 2;
								}
							}
							break;
						}
						memoryStream.WriteByte((byte)c);
					}
					return memoryStream.ToArray();
				}
				throw new ArgumentOutOfRangeException("count");
			}
			throw new ArgumentOutOfRangeException("offset");
		}

		public static string UrlEncode(string str)
		{
			return UrlEncode(str, Encoding.UTF8);
		}

		public static string UrlEncode(string s, Encoding Enc)
		{
			if (s == null)
			{
				return null;
			}
			if (s == "")
			{
				return "";
			}
			bool flag = false;
			int length = s.Length;
			for (int i = 0; i < length; i++)
			{
				char c = s[i];
				if ((c < '0' || (c < 'A' && c > '9') || (c > 'Z' && c < 'a') || c > 'z') && !smethod_6(c))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return s;
			}
			byte[] bytes = new byte[Enc.GetMaxByteCount(s.Length)];
			int bytes2 = Enc.GetBytes(s, 0, s.Length, bytes, 0);
			return Encoding.ASCII.GetString(UrlEncodeToBytes(bytes, 0, bytes2));
		}

		public static string UrlEncode(byte[] bytes)
		{
			if (bytes == null)
			{
				return null;
			}
			if (bytes.Length == 0)
			{
				return "";
			}
			return Encoding.ASCII.GetString(UrlEncodeToBytes(bytes, 0, bytes.Length));
		}

		public static string UrlEncode(byte[] bytes, int offset, int count)
		{
			if (bytes == null)
			{
				return null;
			}
			if (bytes.Length == 0)
			{
				return "";
			}
			return Encoding.ASCII.GetString(UrlEncodeToBytes(bytes, offset, count));
		}

		public static byte[] UrlEncodeToBytes(string str)
		{
			return UrlEncodeToBytes(str, Encoding.UTF8);
		}

		public static byte[] UrlEncodeToBytes(string str, Encoding e)
		{
			if (str == null)
			{
				return null;
			}
			if (str == "")
			{
				return new byte[0];
			}
			byte[] bytes = e.GetBytes(str);
			return UrlEncodeToBytes(bytes, 0, bytes.Length);
		}

		public static byte[] UrlEncodeToBytes(byte[] bytes)
		{
			if (bytes == null)
			{
				return null;
			}
			if (bytes.Length == 0)
			{
				return new byte[0];
			}
			return UrlEncodeToBytes(bytes, 0, bytes.Length);
		}

		private static bool smethod_6(char A_0)
		{
			if (A_0 != '!' && A_0 != '\'' && A_0 != '(' && A_0 != ')' && A_0 != '*' && A_0 != '-' && A_0 != '.')
			{
				return A_0 == '_';
			}
			return true;
		}

		private static void smethod_7(char A_0, Stream A_1, bool A_2)
		{
			if (A_0 > 'ÿ')
			{
				A_1.WriteByte(37);
				A_1.WriteByte(117);
				int num = (int)A_0 >> 12;
				A_1.WriteByte((byte)char_0[num]);
				num = ((int)A_0 >> 8) & 0xF;
				A_1.WriteByte((byte)char_0[num]);
				num = ((int)A_0 >> 4) & 0xF;
				A_1.WriteByte((byte)char_0[num]);
				num = A_0 & 0xF;
				A_1.WriteByte((byte)char_0[num]);
			}
			else if (A_0 > ' ' && smethod_6(A_0))
			{
				A_1.WriteByte((byte)A_0);
			}
			else if (A_0 == ' ')
			{
				A_1.WriteByte(43);
			}
			else if (A_0 >= '0' && (A_0 >= 'A' || A_0 <= '9') && (A_0 <= 'Z' || A_0 >= 'a') && A_0 <= 'z')
			{
				A_1.WriteByte((byte)A_0);
			}
			else
			{
				if (A_2 && A_0 > '\u007f')
				{
					A_1.WriteByte(37);
					A_1.WriteByte(117);
					A_1.WriteByte(48);
					A_1.WriteByte(48);
				}
				else
				{
					A_1.WriteByte(37);
				}
				int num2 = (int)A_0 >> 4;
				A_1.WriteByte((byte)char_0[num2]);
				num2 = A_0 & 0xF;
				A_1.WriteByte((byte)char_0[num2]);
			}
		}

		public static byte[] UrlEncodeToBytes(byte[] bytes, int offset, int count)
		{
			if (bytes == null)
			{
				return null;
			}
			int num = bytes.Length;
			if (num == 0)
			{
				return new byte[0];
			}
			if (offset >= 0 && offset < num)
			{
				if (count >= 0 && count <= num - offset)
				{
					MemoryStream memoryStream = new MemoryStream(count);
					int num2 = offset + count;
					for (int i = offset; i < num2; i++)
					{
						smethod_7((char)bytes[i], memoryStream, A_2: false);
					}
					return memoryStream.ToArray();
				}
				throw new ArgumentOutOfRangeException("count");
			}
			throw new ArgumentOutOfRangeException("offset");
		}

		public static string UrlEncodeUnicode(string str)
		{
			if (str == null)
			{
				return null;
			}
			return Encoding.ASCII.GetString(UrlEncodeUnicodeToBytes(str));
		}

		public static byte[] UrlEncodeUnicodeToBytes(string str)
		{
			if (str == null)
			{
				return null;
			}
			if (str == "")
			{
				return new byte[0];
			}
			MemoryStream memoryStream = new MemoryStream(str.Length);
			foreach (char a_ in str)
			{
				smethod_7(a_, memoryStream, A_2: true);
			}
			return memoryStream.ToArray();
		}

		public static string HtmlDecode(string s)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (s.IndexOf('&') == -1)
			{
				return s;
			}
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilder stringBuilder2 = new StringBuilder();
			int length = s.Length;
			int num = 0;
			int num2 = 0;
			bool flag = false;
			for (int i = 0; i < length; i++)
			{
				char c = s[i];
				if (num == 0)
				{
					if (c == '&')
					{
						stringBuilder.Append(c);
						num = 1;
					}
					else
					{
						stringBuilder2.Append(c);
					}
					continue;
				}
				if (c == '&')
				{
					num = 1;
					if (flag)
					{
						stringBuilder.Append(num2.ToString(Class60.cultureInfo_0));
						flag = false;
					}
					stringBuilder2.Append(stringBuilder.ToString());
					stringBuilder.Length = 0;
					stringBuilder.Append('&');
					continue;
				}
				switch (num)
				{
				case 1:
					if (c == ';')
					{
						num = 0;
						stringBuilder2.Append(stringBuilder.ToString());
						stringBuilder2.Append(c);
						stringBuilder.Length = 0;
					}
					else
					{
						num2 = 0;
						num = ((c == '#') ? 3 : 2);
						stringBuilder.Append(c);
					}
					break;
				case 2:
					stringBuilder.Append(c);
					if (c == ';')
					{
						string text = stringBuilder.ToString();
						if (text.Length > 1 && Entities.ContainsKey(text.Substring(1, text.Length - 2)))
						{
							text = Entities[text.Substring(1, text.Length - 2)].ToString();
						}
						stringBuilder2.Append(text);
						num = 0;
						stringBuilder.Length = 0;
					}
					break;
				case 3:
					if (c == ';')
					{
						if (num2 > 65535)
						{
							stringBuilder2.Append("&#");
							stringBuilder2.Append(num2.ToString(Class60.cultureInfo_0));
							stringBuilder2.Append(";");
						}
						else
						{
							stringBuilder2.Append((char)num2);
						}
						num = 0;
						stringBuilder.Length = 0;
						flag = false;
					}
					else if (char.IsDigit(c))
					{
						num2 = num2 * 10 + (c - 48);
						flag = true;
					}
					else
					{
						num = 2;
						if (flag)
						{
							stringBuilder.Append(num2.ToString(Class60.cultureInfo_0));
							flag = false;
						}
						stringBuilder.Append(c);
					}
					break;
				}
			}
			if (stringBuilder.Length > 0)
			{
				stringBuilder2.Append(stringBuilder.ToString());
			}
			else if (flag)
			{
				stringBuilder2.Append(num2.ToString(Class60.cultureInfo_0));
			}
			return stringBuilder2.ToString();
		}

		public static void HtmlDecode(string s, TextWriter output)
		{
			if (s != null)
			{
				output.Write(HtmlDecode(s));
			}
		}

		public static string HtmlEncode(string s)
		{
			if (s == null)
			{
				return null;
			}
			bool flag = false;
			foreach (char c in s)
			{
				if (c == '&' || c == '"' || c == '<' || c == '>' || c > '\u009f')
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return s;
			}
			StringBuilder stringBuilder = new StringBuilder();
			int length = s.Length;
			for (int j = 0; j < length; j++)
			{
				switch (s[j])
				{
				case '<':
					stringBuilder.Append("&lt;");
					continue;
				case '>':
					stringBuilder.Append("&gt;");
					continue;
				case '&':
					stringBuilder.Append("&amp;");
					continue;
				case '"':
					stringBuilder.Append("&quot;");
					continue;
				}
				if (s[j] > '\u009f')
				{
					stringBuilder.Append("&#");
					stringBuilder.Append(((int)s[j]).ToString(Class60.cultureInfo_0));
					stringBuilder.Append(";");
				}
				else
				{
					stringBuilder.Append(s[j]);
				}
			}
			return stringBuilder.ToString();
		}

		public static void HtmlEncode(string s, TextWriter output)
		{
			if (s != null)
			{
				output.Write(HtmlEncode(s));
			}
		}

		internal static void smethod_8(string A_0, Encoding A_1, NameValueCollection A_2)
		{
			if (A_0.Length == 0)
			{
				return;
			}
			string text = HtmlDecode(A_0);
			int length = text.Length;
			int num = 0;
			bool flag = true;
			while (num <= length)
			{
				int num2 = -1;
				int num3 = -1;
				for (int i = num; i < length; i++)
				{
					if (num2 == -1 && text[i] == '=')
					{
						num2 = i + 1;
					}
					else if (text[i] == '&')
					{
						num3 = i;
						break;
					}
				}
				if (flag)
				{
					flag = false;
					if (text[num] == '?')
					{
						num++;
					}
				}
				string name;
				if (num2 == -1)
				{
					name = null;
					num2 = num;
				}
				else
				{
					name = UrlDecode(text.Substring(num, num2 - num - 1), A_1);
				}
				if (num3 < 0)
				{
					num = -1;
					num3 = text.Length;
				}
				else
				{
					num = num3 + 1;
				}
				string value = UrlDecode(text.Substring(num2, num3 - num2), A_1);
				A_2.Add(name, value);
				if (num == -1)
				{
					break;
				}
			}
		}
	}
}
