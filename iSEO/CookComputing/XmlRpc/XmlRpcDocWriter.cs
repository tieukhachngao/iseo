using System;
using System.Collections;
using System.Reflection;
using System.Web.UI;

namespace CookComputing.XmlRpc
{
	public class XmlRpcDocWriter
	{
		public static void WriteDoc(HtmlTextWriter wrtr, Type type, bool autoDocVersion)
		{
			XmlRpcServiceInfo xmlRpcServiceInfo = XmlRpcServiceInfo.CreateServiceInfo(type);
			wrtr.WriteFullBeginTag("html");
			wrtr.WriteLine();
			WriteHead(wrtr, xmlRpcServiceInfo.Name);
			wrtr.WriteLine();
			WriteBody(wrtr, type, autoDocVersion);
			wrtr.WriteEndTag("html");
		}

		public static void WriteHead(HtmlTextWriter wrtr, string title)
		{
			wrtr.WriteFullBeginTag("head");
			wrtr.WriteLine();
			smethod_0(wrtr);
			smethod_1(wrtr, title);
			wrtr.WriteEndTag("head");
		}

		public static void WriteFooter(HtmlTextWriter wrtr, Type type, bool autoDocVersion)
		{
			wrtr.WriteBeginTag("div");
			wrtr.WriteAttribute("id", "content");
			wrtr.Write('>');
			wrtr.WriteLine();
			wrtr.WriteFullBeginTag("h2");
			wrtr.Write("&nbsp;");
			wrtr.WriteEndTag("h2");
			wrtr.WriteLine();
			if (autoDocVersion)
			{
				AssemblyName name = type.Assembly.GetName();
				wrtr.Write("{0} {1}.{2}.{3}&nbsp;&nbsp;&nbsp;", name.Name, name.Version.Major, name.Version.Minor, name.Version.Build);
				AssemblyName name2 = typeof(XmlRpcServerProtocol).Assembly.GetName();
				wrtr.Write("{0} {1}.{2}.{3}&nbsp;&nbsp;&nbsp;", name2.Name, name2.Version.Major, name2.Version.Minor, name2.Version.Build);
				wrtr.Write(".NET CLR {0}.{1}.{2}&nbsp;&nbsp;&nbsp;", Environment.Version.Major, Environment.Version.Minor, Environment.Version.Build);
			}
			wrtr.WriteEndTag("div");
			wrtr.WriteLine();
		}

		private static void smethod_0(HtmlTextWriter A_0)
		{
			A_0.WriteBeginTag("style");
			A_0.WriteAttribute("type", "text/css");
			A_0.Write('>');
			A_0.WriteLine();
			A_0.WriteLine("BODY { color: #000000; background-color: white; font-family: Verdana; margin-left: 0px; margin-top: 0px; }");
			A_0.WriteLine("#content { margin-left: 30px; font-size: .70em; padding-bottom: 2em; }");
			A_0.WriteLine("A:link { color: #336699; font-weight: bold; text-decoration: underline; }");
			A_0.WriteLine("A:visited { color: #6699cc; font-weight: bold; text-decoration: underline; }");
			A_0.WriteLine("A:active { color: #336699; font-weight: bold; text-decoration: underline; }");
			A_0.WriteLine("A:hover { color: cc3300; font-weight: bold; text-decoration: underline; }");
			A_0.WriteLine("P { color: #000000; margin-top: 0px; margin-bottom: 12px; font-family: Verdana; }");
			A_0.WriteLine("pre { background-color: #e5e5cc; padding: 5px; font-family: Courier New; font-size: x-small; margin-top: -5px; border: 1px #f0f0e0 solid; }");
			A_0.WriteLine("td { color: #000000; font-family: Verdana; font-size: .7em; border: solid 1px;  }");
			A_0.WriteLine("h2 { font-size: 1.5em; font-weight: bold; margin-top: 25px; margin-bottom: 10px; border-top: 1px solid #003366; margin-left: -15px; color: #003366; }");
			A_0.WriteLine("h3 { font-size: 1.1em; color: #000000; margin-left: -15px; margin-top: 10px; margin-bottom: 10px; }");
			A_0.WriteLine("ul, ol { margin-top: 10px; margin-left: 20px; }");
			A_0.WriteLine("li { margin-top: 10px; color: #000000; }");
			A_0.WriteLine("font.value { color: darkblue; font: bold; }");
			A_0.WriteLine("font.key { color: darkgreen; font: bold; }");
			A_0.WriteLine(".heading1 { color: #ffffff; font-family: Tahoma; font-size: 26px; font-weight: normal; background-color: #003366; margin-top: 0px; margin-bottom: 0px; margin-left: -30px; padding-top: 10px; padding-bottom: 3px; padding-left: 15px; width: 105%; }");
			A_0.WriteLine(".intro { margin-left: -15px; }");
			A_0.WriteLine("table { border: solid 1px; }");
			A_0.WriteEndTag("style");
			A_0.WriteLine();
		}

		private static void smethod_1(HtmlTextWriter A_0, string A_1)
		{
			A_0.WriteFullBeginTag("title");
			A_0.Write(A_1);
			A_0.WriteEndTag("title");
			A_0.WriteLine();
		}

		public static void WriteBody(HtmlTextWriter wrtr, Type type, bool autoDocVersion)
		{
			wrtr.WriteFullBeginTag("body");
			wrtr.WriteLine();
			WriteType(wrtr, type);
			wrtr.WriteLine();
			WriteFooter(wrtr, type, autoDocVersion);
			wrtr.WriteEndTag("div");
			wrtr.WriteLine();
			wrtr.WriteEndTag("body");
			wrtr.WriteLine();
		}

		public static void WriteType(HtmlTextWriter wrtr, Type type)
		{
			ArrayList arrayList = new ArrayList();
			wrtr.WriteBeginTag("div");
			wrtr.WriteAttribute("id", "content");
			wrtr.Write('>');
			wrtr.WriteLine();
			XmlRpcServiceInfo xmlRpcServiceInfo = XmlRpcServiceInfo.CreateServiceInfo(type);
			wrtr.WriteBeginTag("p");
			wrtr.WriteAttribute("class", "heading1");
			wrtr.Write('>');
			wrtr.Write(xmlRpcServiceInfo.Name);
			wrtr.WriteEndTag("p");
			wrtr.WriteFullBeginTag("br");
			wrtr.WriteEndTag("br");
			wrtr.WriteLine();
			if (xmlRpcServiceInfo.Doc != "")
			{
				wrtr.WriteBeginTag("p");
				wrtr.WriteAttribute("class", "intro");
				wrtr.Write('>');
				wrtr.Write(xmlRpcServiceInfo.Doc);
				wrtr.WriteEndTag("p");
				wrtr.WriteLine();
			}
			wrtr.WriteBeginTag("p");
			wrtr.WriteAttribute("class", "intro");
			wrtr.Write('>');
			wrtr.Write("The following methods are supported:");
			wrtr.WriteEndTag("p");
			wrtr.WriteLine();
			wrtr.WriteFullBeginTag("ul");
			wrtr.WriteLine();
			XmlRpcMethodInfo[] methods = xmlRpcServiceInfo.Methods;
			foreach (XmlRpcMethodInfo xmlRpcMethodInfo in methods)
			{
				if (!xmlRpcMethodInfo.IsHidden)
				{
					wrtr.WriteFullBeginTag("li");
					wrtr.WriteBeginTag("a");
					wrtr.WriteAttribute("href", "#" + xmlRpcMethodInfo.XmlRpcName);
					wrtr.Write('>');
					wrtr.Write(xmlRpcMethodInfo.XmlRpcName);
					wrtr.WriteEndTag("a");
					wrtr.WriteEndTag("li");
					wrtr.WriteLine();
				}
			}
			wrtr.WriteEndTag("ul");
			wrtr.WriteLine();
			XmlRpcMethodInfo[] methods2 = xmlRpcServiceInfo.Methods;
			foreach (XmlRpcMethodInfo xmlRpcMethodInfo2 in methods2)
			{
				if (!xmlRpcMethodInfo2.IsHidden)
				{
					smethod_2(wrtr, xmlRpcMethodInfo2, arrayList);
				}
			}
			for (int k = 0; k < arrayList.Count; k++)
			{
				smethod_3(wrtr, arrayList[k] as Type, arrayList);
			}
			wrtr.WriteEndTag("div");
			wrtr.WriteLine();
		}

		private static void smethod_2(HtmlTextWriter A_0, XmlRpcMethodInfo A_1, ArrayList A_2)
		{
			A_0.WriteFullBeginTag("span");
			A_0.WriteLine();
			A_0.WriteFullBeginTag("h2");
			A_0.WriteBeginTag("a");
			A_0.WriteAttribute("name", "#" + A_1.XmlRpcName);
			A_0.Write('>');
			A_0.Write("method " + A_1.XmlRpcName);
			A_0.WriteEndTag("a");
			A_0.WriteEndTag("h2");
			A_0.WriteLine();
			if (A_1.Doc != "")
			{
				A_0.WriteBeginTag("p");
				A_0.WriteAttribute("class", "intro");
				A_0.Write('>');
				A_0.Write(A_1.Doc);
				A_0.WriteEndTag("p");
				A_0.WriteLine();
			}
			A_0.WriteFullBeginTag("h3");
			A_0.Write("Parameters");
			A_0.WriteEndTag("h3");
			A_0.WriteLine();
			A_0.WriteBeginTag("table");
			A_0.WriteAttribute("cellspacing", "0");
			A_0.WriteAttribute("cellpadding", "5");
			A_0.WriteAttribute("width", "90%");
			A_0.Write('>');
			if (A_1.Parameters.Length > 0)
			{
				XmlRpcParameterInfo[] parameters = A_1.Parameters;
				foreach (XmlRpcParameterInfo xmlRpcParameterInfo in parameters)
				{
					A_0.WriteFullBeginTag("tr");
					A_0.WriteBeginTag("td");
					A_0.WriteAttribute("width", "33%");
					A_0.Write('>');
					smethod_4(A_0, xmlRpcParameterInfo.Type, xmlRpcParameterInfo.IsParams, A_2);
					A_0.WriteEndTag("td");
					A_0.WriteFullBeginTag("td");
					if (xmlRpcParameterInfo.Doc == "")
					{
						A_0.Write(xmlRpcParameterInfo.Name);
					}
					else
					{
						A_0.Write(xmlRpcParameterInfo.Name);
						A_0.Write(" - ");
						A_0.Write(xmlRpcParameterInfo.Doc);
					}
					A_0.WriteEndTag("td");
					A_0.WriteEndTag("tr");
				}
			}
			else
			{
				A_0.WriteFullBeginTag("tr");
				A_0.WriteBeginTag("td");
				A_0.WriteAttribute("width", "33%");
				A_0.Write('>');
				A_0.Write("none");
				A_0.WriteEndTag("td");
				A_0.WriteFullBeginTag("td");
				A_0.Write("&nbsp;");
				A_0.WriteEndTag("td");
				A_0.WriteEndTag("tr");
			}
			A_0.WriteEndTag("table");
			A_0.WriteLine();
			A_0.WriteFullBeginTag("h3");
			A_0.Write("Return Value");
			A_0.WriteEndTag("h3");
			A_0.WriteLine();
			A_0.WriteBeginTag("table");
			A_0.WriteAttribute("cellspacing", "0");
			A_0.WriteAttribute("cellpadding", "5");
			A_0.WriteAttribute("width", "90%");
			A_0.Write('>');
			A_0.WriteFullBeginTag("tr");
			A_0.WriteBeginTag("td");
			A_0.WriteAttribute("width", "33%");
			A_0.Write('>');
			smethod_4(A_0, A_1.ReturnType, A_2: false, A_2);
			A_0.WriteEndTag("td");
			A_0.WriteFullBeginTag("td");
			if (A_1.ReturnDoc != "")
			{
				A_0.Write(A_1.ReturnDoc);
			}
			else
			{
				A_0.Write("&nbsp;");
			}
			A_0.WriteEndTag("td");
			A_0.WriteEndTag("tr");
			A_0.WriteEndTag("table");
			A_0.WriteLine();
			A_0.WriteEndTag("span");
			A_0.WriteLine();
		}

		private static void smethod_3(HtmlTextWriter A_0, Type A_1, ArrayList A_2)
		{
			A_0.WriteFullBeginTag("span");
			A_0.WriteLine();
			A_0.WriteFullBeginTag("h2");
			A_0.WriteBeginTag("a");
			A_0.WriteAttribute("name", "#" + A_1.Name);
			A_0.Write('>');
			A_0.Write("struct " + A_1.Name);
			A_0.WriteEndTag("a");
			A_0.WriteEndTag("h2");
			A_0.WriteLine();
			A_0.WriteFullBeginTag("h3");
			A_0.Write("Members");
			A_0.WriteEndTag("h3");
			A_0.WriteLine();
			A_0.WriteEndTag("span");
			A_0.WriteLine();
			A_0.WriteBeginTag("table");
			A_0.WriteAttribute("cellspacing", "0");
			A_0.WriteAttribute("cellpadding", "5");
			A_0.WriteAttribute("width", "90%");
			A_0.Write('>');
			MappingAction mappingAction = MappingAction.Error;
			Attribute customAttribute = Attribute.GetCustomAttribute(A_1, typeof(XmlRpcMissingMappingAttribute));
			if (customAttribute != null && customAttribute is XmlRpcMissingMappingAttribute)
			{
				mappingAction = (customAttribute as XmlRpcMissingMappingAttribute).Action;
			}
			MemberInfo[] members = A_1.GetMembers();
			MemberInfo[] array = members;
			foreach (MemberInfo memberInfo in array)
			{
				if (memberInfo.MemberType != MemberTypes.Field)
				{
					continue;
				}
				FieldInfo fieldInfo = (FieldInfo)memberInfo;
				A_0.WriteFullBeginTag("tr");
				A_0.WriteBeginTag("td");
				A_0.WriteAttribute("width", "33%");
				A_0.Write('>');
				smethod_4(A_0, fieldInfo.FieldType, A_2: false, A_2);
				A_0.WriteEndTag("td");
				A_0.WriteFullBeginTag("td");
				MappingAction mappingAction2 = mappingAction;
				Attribute customAttribute2 = Attribute.GetCustomAttribute(fieldInfo, typeof(XmlRpcMissingMappingAttribute));
				if (customAttribute2 != null && customAttribute2 is XmlRpcMissingMappingAttribute)
				{
					mappingAction2 = (customAttribute2 as XmlRpcMissingMappingAttribute).Action;
				}
				string text = fieldInfo.Name + " ";
				string text2 = "";
				Attribute customAttribute3 = Attribute.GetCustomAttribute(fieldInfo, typeof(XmlRpcMemberAttribute));
				if (customAttribute2 != null && customAttribute3 is XmlRpcMemberAttribute)
				{
					if ((customAttribute3 as XmlRpcMemberAttribute).Member != "")
					{
						text = (customAttribute3 as XmlRpcMemberAttribute).Member + " ";
					}
					text2 = (customAttribute3 as XmlRpcMemberAttribute).Description;
				}
				if (mappingAction2 == MappingAction.Ignore)
				{
					text += " (optional) ";
				}
				if (text2 != "")
				{
					text = text + "- " + text2;
				}
				A_0.Write(text);
				A_0.WriteEndTag("td");
				A_0.WriteEndTag("tr");
			}
			A_0.WriteEndTag("table");
			A_0.WriteLine();
		}

		private static void smethod_4(HtmlTextWriter A_0, Type A_1, bool A_2, ArrayList A_3)
		{
			string text = (A_2 ? "varargs" : (((object)A_1 == typeof(object)) ? "any" : XmlRpcServiceInfo.GetXmlRpcTypeString(A_1)));
			A_0.Write(text);
			if (text == "struct" && (object)A_1 != typeof(XmlRpcStruct))
			{
				if (!A_3.Contains(A_1))
				{
					A_3.Add(A_1);
				}
				A_0.Write(" ");
				A_0.WriteBeginTag("a");
				A_0.WriteAttribute("href", "#" + A_1.Name);
				A_0.Write('>');
				A_0.Write(A_1.Name);
				A_0.WriteEndTag("a");
			}
			else
			{
				if ((!(text == "array") && !(text == "varargs")) || A_1.GetArrayRank() != 1)
				{
					return;
				}
				A_0.Write(" of ");
				Type elementType = A_1.GetElementType();
				string text2 = (((object)elementType == typeof(object)) ? "any" : XmlRpcServiceInfo.GetXmlRpcTypeString(elementType));
				A_0.Write(text2);
				if (text2 == "struct" && (object)elementType != typeof(XmlRpcStruct))
				{
					if (!A_3.Contains(elementType))
					{
						A_3.Add(elementType);
					}
					A_0.Write(" ");
					A_0.WriteBeginTag("a");
					A_0.WriteAttribute("href", "#" + elementType.Name);
					A_0.Write('>');
					A_0.Write(elementType.Name);
					A_0.WriteEndTag("a");
				}
			}
		}
	}
}
