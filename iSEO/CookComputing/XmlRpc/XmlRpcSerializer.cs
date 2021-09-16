using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml;

namespace CookComputing.XmlRpc
{
	public class XmlRpcSerializer
	{
		private struct Struct1
		{
			public int int_0;

			public string string_0;
		}

		private struct Struct2
		{
			public string string_0;

			public string string_1;
		}

		public class ParseStack : Stack
		{
			public string m_parseType = "";

			public string ParseType => m_parseType;

			public ParseStack(string parseType)
			{
				m_parseType = parseType;
			}

			private void method_0(string A_0)
			{
				base.Push(A_0);
			}
		}

		private int int_0 = 2;

		private XmlRpcNonStandard xmlRpcNonStandard_0;

		private bool bool_0 = true;

		private bool bool_1 = true;

		private bool bool_2;

		private bool bool_3 = true;

		private Encoding encoding_0;

		public int Indentation
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

		public XmlRpcNonStandard NonStandard
		{
			get
			{
				return xmlRpcNonStandard_0;
			}
			set
			{
				xmlRpcNonStandard_0 = value;
			}
		}

		public bool UseEmptyParamsTag
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

		public bool UseIndentation
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

		public bool UseIntTag
		{
			get
			{
				return bool_2;
			}
			set
			{
				bool_2 = value;
			}
		}

		public bool UseStringTag
		{
			get
			{
				return bool_3;
			}
			set
			{
				bool_3 = value;
			}
		}

		public Encoding XmlEncoding
		{
			get
			{
				return encoding_0;
			}
			set
			{
				encoding_0 = value;
			}
		}

		private bool AllowInvalidHTTPContent => (xmlRpcNonStandard_0 & XmlRpcNonStandard.AllowInvalidHTTPContent) != 0;

		private bool AllowNonStandardDateTime => (xmlRpcNonStandard_0 & XmlRpcNonStandard.AllowNonStandardDateTime) != 0;

		private bool AllowStringFaultCode => (xmlRpcNonStandard_0 & XmlRpcNonStandard.AllowStringFaultCode) != 0;

		private bool IgnoreDuplicateMembers => (xmlRpcNonStandard_0 & XmlRpcNonStandard.IgnoreDuplicateMembers) != 0;

		private bool MapEmptyDateTimeToMinValue => (xmlRpcNonStandard_0 & XmlRpcNonStandard.MapEmptyDateTimeToMinValue) != 0;

		private bool MapZerosDateTimeToMinValue => (xmlRpcNonStandard_0 & XmlRpcNonStandard.MapZerosDateTimeToMinValue) != 0;

		public void SerializeRequest(Stream stm, XmlRpcRequest request)
		{
			XmlTextWriter xmlTextWriter = new XmlTextWriter(stm, encoding_0);
			method_21(xmlTextWriter);
			xmlTextWriter.WriteStartDocument();
			xmlTextWriter.WriteStartElement("", "methodCall", "");
			MappingAction a_ = MappingAction.Error;
			if (request.xmlRpcMethod == null)
			{
				xmlTextWriter.WriteElementString("methodName", request.method);
			}
			else
			{
				xmlTextWriter.WriteElementString("methodName", request.xmlRpcMethod);
			}
			if (request.args.Length > 0 || UseEmptyParamsTag)
			{
				xmlTextWriter.WriteStartElement("", "params", "");
				try
				{
					if (!method_28(request.mi))
					{
						method_0(xmlTextWriter, request, a_);
					}
					else
					{
						method_1(xmlTextWriter, request, a_);
					}
				}
				catch (XmlRpcUnsupportedTypeException ex)
				{
					throw new XmlRpcUnsupportedTypeException(ex.UnsupportedType, $"A parameter is of, or contains an instance of, type {ex.UnsupportedType} which cannot be mapped to an XML-RPC type");
				}
				xmlTextWriter.WriteEndElement();
			}
			xmlTextWriter.WriteEndElement();
			xmlTextWriter.Flush();
		}

		private void method_0(XmlTextWriter A_0, XmlRpcRequest A_1, MappingAction A_2)
		{
			ParameterInfo[] array = null;
			if ((object)A_1.mi != null)
			{
				array = A_1.mi.GetParameters();
			}
			int num = 0;
			while (true)
			{
				if (num >= A_1.args.Length)
				{
					return;
				}
				if (array != null)
				{
					if (num >= array.Length)
					{
						throw new XmlRpcInvalidParametersException("Number of request parameters greater than number of proxy method parameters.");
					}
					if (num == array.Length - 1 && Attribute.IsDefined(array[num], typeof(ParamArrayAttribute)))
					{
						Array array2 = (Array)A_1.args[num];
						foreach (object item in array2)
						{
							if (item != null)
							{
								A_0.WriteStartElement("", "param", "");
								Serialize(A_0, item, A_2);
								A_0.WriteEndElement();
								continue;
							}
							throw new XmlRpcNullParameterException("Null parameter in params array");
						}
						return;
					}
				}
				if (A_1.args[num] == null)
				{
					break;
				}
				A_0.WriteStartElement("", "param", "");
				Serialize(A_0, A_1.args[num], A_2);
				A_0.WriteEndElement();
				num++;
			}
			throw new XmlRpcNullParameterException($"Null method parameter #{num + 1}");
		}

		private void method_1(XmlTextWriter A_0, XmlRpcRequest A_1, MappingAction A_2)
		{
			ParameterInfo[] parameters = A_1.mi.GetParameters();
			if (A_1.args.Length > parameters.Length)
			{
				throw new XmlRpcInvalidParametersException("Number of request parameters greater than number of proxy method parameters.");
			}
			if (Attribute.IsDefined(parameters[A_1.args.Length - 1], typeof(ParamArrayAttribute)))
			{
				throw new XmlRpcInvalidParametersException("params parameter cannot be used with StructParams.");
			}
			A_0.WriteStartElement("", "param", "");
			A_0.WriteStartElement("", "value", "");
			A_0.WriteStartElement("", "struct", "");
			for (int i = 0; i < A_1.args.Length; i++)
			{
				if (A_1.args[i] != null)
				{
					A_0.WriteStartElement("", "member", "");
					A_0.WriteElementString("name", parameters[i].Name);
					Serialize(A_0, A_1.args[i], A_2);
					A_0.WriteEndElement();
					continue;
				}
				throw new XmlRpcNullParameterException($"Null method parameter #{i + 1}");
			}
			A_0.WriteEndElement();
			A_0.WriteEndElement();
			A_0.WriteEndElement();
		}

		public XmlRpcRequest DeserializeRequest(Stream stm, Type svcType)
		{
			if (stm == null)
			{
				throw new ArgumentNullException("stm", "XmlRpcSerializer.DeserializeRequest");
			}
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.PreserveWhitespace = true;
			try
			{
				xmlDocument.Load(stm);
			}
			catch (Exception innerEx)
			{
				throw new XmlRpcIllFormedXmlException("Request from client does not contain valid XML.", innerEx);
			}
			return DeserializeRequest(xmlDocument, svcType);
		}

		public XmlRpcRequest DeserializeRequest(TextReader txtrdr, Type svcType)
		{
			if (txtrdr == null)
			{
				throw new ArgumentNullException("txtrdr", "XmlRpcSerializer.DeserializeRequest");
			}
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.PreserveWhitespace = true;
			try
			{
				xmlDocument.Load(txtrdr);
			}
			catch (Exception innerEx)
			{
				throw new XmlRpcIllFormedXmlException("Request from client does not contain valid XML.", innerEx);
			}
			return DeserializeRequest(xmlDocument, svcType);
		}

		public XmlRpcRequest DeserializeRequest(XmlDocument xdoc, Type svcType)
		{
			XmlRpcRequest xmlRpcRequest = new XmlRpcRequest();
			XmlNode xmlNode = method_23(xdoc, "methodCall");
			if (xmlNode == null)
			{
				throw new XmlRpcInvalidXmlRpcException("Request XML not valid XML-RPC - missing methodCall element.");
			}
			XmlNode xmlNode2 = method_23(xmlNode, "methodName");
			if (xmlNode2 == null)
			{
				throw new XmlRpcInvalidXmlRpcException("Request XML not valid XML-RPC - missing methodName element.");
			}
			xmlRpcRequest.method = xmlNode2.FirstChild.Value;
			if (xmlRpcRequest.method == "")
			{
				throw new XmlRpcInvalidXmlRpcException("Request XML not valid XML-RPC - empty methodName.");
			}
			xmlRpcRequest.mi = null;
			ParameterInfo[] array = new ParameterInfo[0];
			if ((object)svcType != null)
			{
				XmlRpcServiceInfo xmlRpcServiceInfo = XmlRpcServiceInfo.CreateServiceInfo(svcType);
				xmlRpcRequest.mi = xmlRpcServiceInfo.GetMethodInfo(xmlRpcRequest.method);
				if ((object)xmlRpcRequest.mi == null)
				{
					string msg = $"unsupported method called: {xmlRpcRequest.method}";
					throw new XmlRpcUnsupportedMethodException(msg);
				}
				Attribute customAttribute = Attribute.GetCustomAttribute(xmlRpcRequest.mi, typeof(XmlRpcMethodAttribute));
				if (customAttribute == null)
				{
					throw new XmlRpcMethodAttributeException("Method must be marked with the XmlRpcMethod attribute.");
				}
				array = xmlRpcRequest.mi.GetParameters();
			}
			XmlNode xmlNode3 = method_23(xmlNode, "params");
			if (xmlNode3 == null)
			{
				if ((object)svcType != null)
				{
					if (array.Length == 0)
					{
						xmlRpcRequest.args = new object[0];
						return xmlRpcRequest;
					}
					throw new XmlRpcInvalidParametersException("Method takes parameters and params element is missing.");
				}
				xmlRpcRequest.args = new object[0];
				return xmlRpcRequest;
			}
			XmlNode[] array2 = method_24(xmlNode3, "param");
			int num = method_2(array);
			if (array2.Length < num)
			{
				throw new XmlRpcInvalidParametersException("Method takes parameters and there is incorrect number of param elements.");
			}
			ParseStack parseStack = new ParseStack("request");
			MappingAction a_ = MappingAction.Error;
			int num2 = ((num == -1) ? array2.Length : (num + 1));
			object[] array3 = new object[num2];
			int num3 = ((num == -1) ? array2.Length : num);
			int num4 = 0;
			while (true)
			{
				if (num4 < num3)
				{
					XmlNode a_2 = array2[num4];
					XmlNode xmlNode4 = method_23(a_2, "value");
					if (xmlNode4 != null)
					{
						XmlNode a_3 = method_25(xmlNode4);
						if ((object)svcType != null)
						{
							parseStack.Push($"parameter {num4 + 1}");
							array3[num4] = method_4(a_3, array[num4].ParameterType, parseStack, a_);
						}
						else
						{
							parseStack.Push($"parameter {num4}");
							array3[num4] = method_4(a_3, null, parseStack, a_);
						}
						parseStack.Pop();
						num4++;
						continue;
					}
					throw new XmlRpcInvalidXmlRpcException("Missing value element.");
				}
				if (num == -1)
				{
					break;
				}
				Type elementType = array[num].ParameterType.GetElementType();
				Array array4 = (Array)method_27(A_1: new object[1] { array2.Length - num }, A_0: array[num].ParameterType);
				for (int i = 0; i < array4.Length; i++)
				{
					XmlNode a_5 = array2[i + num];
					XmlNode xmlNode5 = method_23(a_5, "value");
					if (xmlNode5 != null)
					{
						XmlNode a_6 = method_25(xmlNode5);
						parseStack.Push($"parameter {i + 1 + num}");
						array4.SetValue(method_4(a_6, elementType, parseStack, a_), i);
						parseStack.Pop();
						continue;
					}
					throw new XmlRpcInvalidXmlRpcException("Missing value element.");
				}
				array3[num] = array4;
				break;
			}
			xmlRpcRequest.args = array3;
			return xmlRpcRequest;
		}

		private int method_2(ParameterInfo[] A_0)
		{
			if (A_0.Length == 0)
			{
				return -1;
			}
			if (Attribute.IsDefined(A_0[A_0.Length - 1], typeof(ParamArrayAttribute)))
			{
				return A_0.Length - 1;
			}
			return -1;
		}

		public void SerializeResponse(Stream stm, XmlRpcResponse response)
		{
			object obj = response.retVal;
			if (obj is XmlRpcFaultException)
			{
				SerializeFaultResponse(stm, (XmlRpcFaultException)obj);
				return;
			}
			XmlTextWriter xmlTextWriter = new XmlTextWriter(stm, encoding_0);
			method_21(xmlTextWriter);
			xmlTextWriter.WriteStartDocument();
			xmlTextWriter.WriteStartElement("", "methodResponse", "");
			xmlTextWriter.WriteStartElement("", "params", "");
			if (obj == null)
			{
				obj = "";
			}
			xmlTextWriter.WriteStartElement("", "param", "");
			MappingAction mappingAction = MappingAction.Error;
			try
			{
				Serialize(xmlTextWriter, obj, mappingAction);
			}
			catch (XmlRpcUnsupportedTypeException ex)
			{
				throw new XmlRpcInvalidReturnType($"Return value is of, or contains an instance of, type {ex.UnsupportedType} which cannot be mapped to an XML-RPC type");
			}
			xmlTextWriter.WriteEndElement();
			xmlTextWriter.WriteEndElement();
			xmlTextWriter.WriteEndElement();
			xmlTextWriter.Flush();
		}

		public XmlRpcResponse DeserializeResponse(Stream stm, Type svcType)
		{
			if (stm == null)
			{
				throw new ArgumentNullException("stm", "XmlRpcSerializer.DeserializeResponse");
			}
			if (AllowInvalidHTTPContent)
			{
				Stream stream = new MemoryStream();
				Util.CopyStream(stm, stream);
				stm = stream;
				stm.Position = 0L;
				while (true)
				{
					switch (stm.ReadByte())
					{
					case 9:
					case 10:
					case 13:
					case 32:
						continue;
					case -1:
						throw new XmlRpcIllFormedXmlException("Response from server does not contain valid XML.");
					}
					break;
				}
				stm.Position--;
			}
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.PreserveWhitespace = true;
			try
			{
				xmlDocument.Load(stm);
			}
			catch (Exception innerEx)
			{
				throw new XmlRpcIllFormedXmlException("Response from server does not contain valid XML.", innerEx);
			}
			return DeserializeResponse(xmlDocument, svcType);
		}

		public XmlRpcResponse DeserializeResponse(TextReader txtrdr, Type svcType)
		{
			if (txtrdr == null)
			{
				throw new ArgumentNullException("txtrdr", "XmlRpcSerializer.DeserializeResponse");
			}
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.PreserveWhitespace = true;
			try
			{
				xmlDocument.Load(txtrdr);
			}
			catch (Exception innerEx)
			{
				throw new XmlRpcIllFormedXmlException("Response from server does not contain valid XML.", innerEx);
			}
			return DeserializeResponse(xmlDocument, svcType);
		}

		public XmlRpcResponse DeserializeResponse(XmlDocument xdoc, Type returnType)
		{
			XmlRpcResponse xmlRpcResponse = new XmlRpcResponse();
			object obj = null;
			XmlNode xmlNode = method_23(xdoc, "methodResponse");
			if (xmlNode == null)
			{
				throw new XmlRpcInvalidXmlRpcException("Response XML not valid XML-RPC - missing methodResponse element.");
			}
			XmlNode xmlNode2 = method_23(xmlNode, "fault");
			if (xmlNode2 != null)
			{
				ParseStack a_ = new ParseStack("fault response");
				XmlRpcFaultException ex = method_20(xmlNode2, a_, MappingAction.Error);
				throw ex;
			}
			XmlNode xmlNode3 = method_23(xmlNode, "params");
			if (xmlNode3 == null && (object)returnType != null)
			{
				if ((object)returnType == typeof(void))
				{
					return new XmlRpcResponse(null);
				}
				throw new XmlRpcInvalidXmlRpcException("Response XML not valid XML-RPC - missing params element.");
			}
			XmlNode xmlNode4 = method_23(xmlNode3, "param");
			if (xmlNode4 == null && (object)returnType != null)
			{
				if ((object)returnType == typeof(void))
				{
					return new XmlRpcResponse(null);
				}
				throw new XmlRpcInvalidXmlRpcException("Response XML not valid XML-RPC - missing params element.");
			}
			XmlNode xmlNode5 = method_23(xmlNode4, "value");
			if (xmlNode5 == null)
			{
				throw new XmlRpcInvalidXmlRpcException("Response XML not valid XML-RPC - missing value element.");
			}
			if ((object)returnType == typeof(void))
			{
				obj = null;
			}
			else
			{
				ParseStack a_2 = new ParseStack("response");
				XmlNode a_3 = method_25(xmlNode5);
				obj = method_4(a_3, returnType, a_2, MappingAction.Error);
			}
			xmlRpcResponse.retVal = obj;
			return xmlRpcResponse;
		}

		public void Serialize(XmlTextWriter xtw, object o, MappingAction mappingAction)
		{
			Serialize(xtw, o, mappingAction, new ArrayList(16));
		}

		public void Serialize(XmlTextWriter xtw, object o, MappingAction mappingAction, ArrayList nestedObjs)
		{
			if (nestedObjs.Contains(o))
			{
				throw new XmlRpcUnsupportedTypeException(nestedObjs[0].GetType(), "Cannot serialize recursive data structure");
			}
			nestedObjs.Add(o);
			try
			{
				xtw.WriteStartElement("", "value", "");
				switch (XmlRpcServiceInfo.GetXmlRpcType(o.GetType()))
				{
				case XmlRpcType.tArray:
				{
					xtw.WriteStartElement("", "array", "");
					xtw.WriteStartElement("", "data", "");
					Array array3 = (Array)o;
					foreach (object item in array3)
					{
						if (item != null)
						{
							Serialize(xtw, item, mappingAction, nestedObjs);
							continue;
						}
						throw new XmlRpcMappingSerializeException($"Items in array cannot be 7a242eee02ac9392 ({o.GetType().GetElementType()}[]).");
					}
					xtw.WriteEndElement();
					xtw.WriteEndElement();
					break;
				}
				case XmlRpcType.tMultiDimArray:
				{
					Array array4 = (Array)o;
					int[] a_2 = new int[array4.Rank];
					method_3(xtw, array4, 0, a_2, mappingAction, nestedObjs);
					break;
				}
				case XmlRpcType.tBase64:
				{
					byte[] array2 = (byte[])o;
					xtw.WriteStartElement("", "base64", "");
					xtw.WriteBase64(array2, 0, array2.Length);
					xtw.WriteEndElement();
					break;
				}
				case XmlRpcType.tBoolean:
					if ((!(o is bool)) ? ((bool)(XmlRpcBoolean)o) : ((bool)o))
					{
						xtw.WriteElementString("boolean", "1");
					}
					else
					{
						xtw.WriteElementString("boolean", "0");
					}
					break;
				case XmlRpcType.tDateTime:
				{
					string value2 = ((!(o is DateTime)) ? ((DateTime)(XmlRpcDateTime)o) : ((DateTime)o)).ToString("yyyyMMdd'T'HH':'mm':'ss", DateTimeFormatInfo.InvariantInfo);
					xtw.WriteElementString("dateTime.iso8601", value2);
					break;
				}
				case XmlRpcType.tDouble:
					xtw.WriteElementString("double", ((!(o is double)) ? ((double)(XmlRpcDouble)o) : ((double)o)).ToString(null, CultureInfo.InvariantCulture));
					break;
				case XmlRpcType.tHashtable:
				{
					xtw.WriteStartElement("", "struct", "");
					XmlRpcStruct xmlRpcStruct = o as XmlRpcStruct;
					foreach (object key in xmlRpcStruct.Keys)
					{
						string text2 = key as string;
						xtw.WriteStartElement("", "member", "");
						xtw.WriteElementString("name", text2);
						Serialize(xtw, xmlRpcStruct[text2], mappingAction, nestedObjs);
						xtw.WriteEndElement();
					}
					xtw.WriteEndElement();
					break;
				}
				case XmlRpcType.tInt32:
					if (UseIntTag)
					{
						xtw.WriteElementString("int", o.ToString());
					}
					else
					{
						xtw.WriteElementString("i4", o.ToString());
					}
					break;
				case XmlRpcType.tString:
					if (UseStringTag)
					{
						xtw.WriteElementString("string", (string)o);
					}
					else
					{
						xtw.WriteString((string)o);
					}
					break;
				case XmlRpcType.tStruct:
				{
					MappingAction a_ = method_11(o.GetType(), mappingAction);
					xtw.WriteStartElement("", "struct", "");
					MemberInfo[] members = o.GetType().GetMembers();
					MemberInfo[] array = members;
					foreach (MemberInfo memberInfo in array)
					{
						if (Attribute.IsDefined(memberInfo, typeof(NonSerializedAttribute)))
						{
							continue;
						}
						if (memberInfo.MemberType == MemberTypes.Field)
						{
							FieldInfo fieldInfo = (FieldInfo)memberInfo;
							string text = fieldInfo.Name;
							Attribute customAttribute = Attribute.GetCustomAttribute(fieldInfo, typeof(XmlRpcMemberAttribute));
							if (customAttribute != null && customAttribute is XmlRpcMemberAttribute)
							{
								string member = ((XmlRpcMemberAttribute)customAttribute).Member;
								if (member != "")
								{
									text = member;
								}
							}
							if (fieldInfo.GetValue(o) == null)
							{
								if (method_12(o.GetType(), fieldInfo.Name, a_) != 0)
								{
									throw new XmlRpcMappingSerializeException("Member \"" + text + "\" of struct \"" + o.GetType().Name + "\" cannot be 7a242eee02ac9392.");
								}
							}
							else
							{
								xtw.WriteStartElement("", "member", "");
								xtw.WriteElementString("name", text);
								Serialize(xtw, fieldInfo.GetValue(o), mappingAction, nestedObjs);
								xtw.WriteEndElement();
							}
						}
						else
						{
							if (memberInfo.MemberType != MemberTypes.Property)
							{
								continue;
							}
							PropertyInfo propertyInfo = (PropertyInfo)memberInfo;
							string value = propertyInfo.Name;
							Attribute customAttribute2 = Attribute.GetCustomAttribute(propertyInfo, typeof(XmlRpcMemberAttribute));
							if (customAttribute2 != null && customAttribute2 is XmlRpcMemberAttribute)
							{
								string member2 = ((XmlRpcMemberAttribute)customAttribute2).Member;
								if (member2 != "")
								{
									value = member2;
								}
							}
							if (propertyInfo.GetValue(o, null) != null || method_12(o.GetType(), propertyInfo.Name, a_) != 0)
							{
								xtw.WriteStartElement("", "member", "");
								xtw.WriteElementString("name", value);
								Serialize(xtw, propertyInfo.GetValue(o, null), mappingAction, nestedObjs);
								xtw.WriteEndElement();
							}
						}
					}
					xtw.WriteEndElement();
					break;
				}
				case XmlRpcType.tVoid:
					xtw.WriteElementString("string", "");
					break;
				default:
					throw new XmlRpcUnsupportedTypeException(o.GetType());
				}
				xtw.WriteEndElement();
			}
			catch (NullReferenceException)
			{
				throw new XmlRpcNullReferenceException("Attempt to serialize data containing 7a242eee02ac9392 reference");
			}
			finally
			{
				nestedObjs.RemoveAt(nestedObjs.Count - 1);
			}
		}

		private void method_3(XmlTextWriter A_0, Array A_1, int A_2, int[] A_3, MappingAction A_4, ArrayList A_5)
		{
			A_0.WriteStartElement("", "array", "");
			A_0.WriteStartElement("", "data", "");
			if (A_2 < A_1.Rank - 1)
			{
				for (int i = 0; i < A_1.GetLength(A_2); i++)
				{
					A_3[A_2] = i;
					A_0.WriteStartElement("", "value", "");
					method_3(A_0, A_1, A_2 + 1, A_3, A_4, A_5);
					A_0.WriteEndElement();
				}
			}
			else
			{
				for (int j = 0; j < A_1.GetLength(A_2); j++)
				{
					A_3[A_2] = j;
					Serialize(A_0, A_1.GetValue(A_3), A_4, A_5);
				}
			}
			A_0.WriteEndElement();
			A_0.WriteEndElement();
		}

		private object method_4(XmlNode A_0, Type A_1, ParseStack A_2, MappingAction A_3)
		{
			Type ParsedType;
			Type ParsedArrayType;
			return ParseValue(A_0, A_1, A_2, A_3, out ParsedType, out ParsedArrayType);
		}

		public object ParseValue(XmlNode node, Type ValueType, ParseStack parseStack, MappingAction mappingAction, out Type ParsedType, out Type ParsedArrayType)
		{
			ParsedType = null;
			ParsedArrayType = null;
			Type type = ValueType;
			if ((object)type != null && (object)type.BaseType == null)
			{
				type = null;
			}
			object result = null;
			if (node == null)
			{
				result = "";
			}
			else if (!(node is XmlText) && !(node is XmlWhitespace))
			{
				if (node.Name == "array")
				{
					result = method_5(node, type, parseStack, mappingAction);
				}
				else if (node.Name == "base64")
				{
					result = method_19(node, type, parseStack, mappingAction);
				}
				else if (node.Name == "struct")
				{
					if ((object)type != null && (object)type != typeof(XmlRpcStruct) && !type.IsSubclassOf(typeof(XmlRpcStruct)))
					{
						result = method_8(node, type, parseStack, mappingAction);
					}
					else
					{
						if ((object)type == null || (object)type == typeof(object))
						{
							type = typeof(XmlRpcStruct);
						}
						result = method_13(node, type, parseStack, mappingAction);
					}
				}
				else if (!(node.Name == "i4") && !(node.Name == "int"))
				{
					if (node.Name == "string")
					{
						result = method_15(node, type, parseStack, mappingAction);
						ParsedType = typeof(string);
						ParsedArrayType = typeof(string[]);
					}
					else if (node.Name == "boolean")
					{
						result = method_16(node, type, parseStack, mappingAction);
						ParsedType = typeof(bool);
						ParsedArrayType = typeof(bool[]);
					}
					else if (node.Name == "double")
					{
						result = method_17(node, type, parseStack, mappingAction);
						ParsedType = typeof(double);
						ParsedArrayType = typeof(double[]);
					}
					else if (node.Name == "dateTime.iso8601")
					{
						result = method_18(node, type, parseStack, mappingAction);
						ParsedType = typeof(DateTime);
						ParsedArrayType = typeof(DateTime[]);
					}
				}
				else
				{
					result = method_14(node, type, parseStack, mappingAction);
					ParsedType = typeof(int);
					ParsedArrayType = typeof(int[]);
				}
			}
			else
			{
				if ((object)type != null && (object)type != typeof(string))
				{
					throw new XmlRpcTypeMismatchException(parseStack.ParseType + " contains implicit string value where " + XmlRpcServiceInfo.GetXmlRpcTypeString(type) + " expected " + method_22(parseStack));
				}
				result = node.Value;
			}
			return result;
		}

		private object method_5(XmlNode A_0, Type A_1, ParseStack A_2, MappingAction A_3)
		{
			if ((object)A_1 != null && !A_1.IsArray && (object)A_1 != typeof(Array) && (object)A_1 != typeof(object))
			{
				throw new XmlRpcTypeMismatchException(A_2.ParseType + " contains array value where " + XmlRpcServiceInfo.GetXmlRpcTypeString(A_1) + " expected " + method_22(A_2));
			}
			if ((object)A_1 != null)
			{
				XmlRpcType xmlRpcType = XmlRpcServiceInfo.GetXmlRpcType(A_1);
				if (xmlRpcType == XmlRpcType.tMultiDimArray)
				{
					A_2.Push("array mapped to type " + A_1.Name);
					return method_6(A_0, A_1, A_2, A_3);
				}
				A_2.Push("array mapped to type " + A_1.Name);
			}
			else
			{
				A_2.Push("array");
			}
			XmlNode a_ = method_23(A_0, "data");
			XmlNode[] array = method_24(a_, "value");
			int num = array.Length;
			object[] array2 = new object[num];
			Type type = null;
			type = (((object)A_1 == null || (object)A_1 == typeof(Array) || (object)A_1 == typeof(object)) ? typeof(object) : A_1.GetElementType());
			bool flag = false;
			Type type2 = null;
			int num2 = 0;
			XmlNode[] array3 = array;
			foreach (XmlNode a_2 in array3)
			{
				A_2.Push($"element {num2}");
				XmlNode node = method_25(a_2);
				array2[num2++] = ParseValue(node, type, A_2, A_3, out var _, out var ParsedArrayType);
				if (!flag)
				{
					type2 = ParsedArrayType;
					flag = true;
				}
				else if ((object)type2 != ParsedArrayType)
				{
					type2 = null;
				}
				A_2.Pop();
			}
			object[] a_3 = new object[1] { num };
			object obj = null;
			obj = (((object)A_1 != null && (object)A_1 != typeof(Array) && (object)A_1 != typeof(object)) ? method_27(A_1, a_3) : (((object)type2 != null) ? method_27(type2, a_3) : method_27(typeof(object[]), a_3)));
			for (int j = 0; j < array2.Length; j++)
			{
				((Array)obj).SetValue(array2[j], j);
			}
			A_2.Pop();
			return obj;
		}

		private object method_6(XmlNode A_0, Type A_1, ParseStack A_2, MappingAction A_3)
		{
			Type elementType = A_1.GetElementType();
			int arrayRank = A_1.GetArrayRank();
			ArrayList arrayList = new ArrayList();
			int[] array = new int[arrayRank];
			array.Initialize();
			method_7(A_0, arrayRank, 0, elementType, arrayList, array, A_2, A_3);
			object[] array2 = new object[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array2[i] = array[i];
			}
			Array array3 = (Array)method_27(A_1, array2);
			int length = array3.Length;
			for (int j = 0; j < length; j++)
			{
				int[] array4 = new int[array.Length];
				int num = 1;
				for (int num2 = array4.Length - 1; num2 >= 0; num2--)
				{
					array4[num2] = j / num % array[num2];
					num *= array[num2];
				}
				array3.SetValue(arrayList[j], array4);
			}
			return array3;
		}

		private void method_7(XmlNode A_0, int A_1, int A_2, Type A_3, ArrayList A_4, int[] A_5, ParseStack A_6, MappingAction A_7)
		{
			if (A_0.Name != "array")
			{
				throw new XmlRpcTypeMismatchException("param element does not contain array element.");
			}
			XmlNode a_ = method_23(A_0, "data");
			XmlNode[] array = method_24(a_, "value");
			int num = array.Length;
			if (A_5[A_2] != 0 && num != A_5[A_2])
			{
				throw new XmlRpcNonRegularArrayException("Multi-dimensional array must not be jagged.");
			}
			A_5[A_2] = num;
			if (A_2 < A_1 - 1)
			{
				XmlNode[] array2 = array;
				foreach (XmlNode a_2 in array2)
				{
					XmlNode a_3 = method_23(a_2, "array");
					method_7(a_3, A_1, A_2 + 1, A_3, A_4, A_5, A_6, A_7);
				}
			}
			else
			{
				XmlNode[] array3 = array;
				foreach (XmlNode a_4 in array3)
				{
					XmlNode a_5 = method_25(a_4);
					A_4.Add(method_4(a_5, A_3, A_6, A_7));
				}
			}
		}

		private object method_8(XmlNode A_0, Type A_1, ParseStack A_2, MappingAction A_3)
		{
			if (A_1.IsPrimitive)
			{
				throw new XmlRpcTypeMismatchException(A_2.ParseType + " contains struct value where " + XmlRpcServiceInfo.GetXmlRpcTypeString(A_1) + " expected " + method_22(A_2));
			}
			if (A_1.IsGenericType && (object)A_1.GetGenericTypeDefinition() == typeof(Nullable<>))
			{
				A_1 = A_1.GetGenericArguments()[0];
			}
			object obj;
			try
			{
				obj = Activator.CreateInstance(A_1);
			}
			catch (Exception)
			{
				throw new XmlRpcTypeMismatchException(A_2.ParseType + " contains struct value where " + XmlRpcServiceInfo.GetXmlRpcTypeString(A_1) + " expected (as type " + A_1.Name + ") " + method_22(A_2));
			}
			MappingAction mappingAction = A_3;
			if ((object)A_1 != null)
			{
				A_2.Push("struct mapped to type " + A_1.Name);
				mappingAction = method_11(A_1, A_3);
			}
			else
			{
				A_2.Push("struct");
			}
			Hashtable hashtable = new Hashtable();
			FieldInfo[] fields = A_1.GetFields();
			foreach (FieldInfo fieldInfo in fields)
			{
				if (!Attribute.IsDefined(fieldInfo, typeof(NonSerializedAttribute)))
				{
					hashtable.Add(fieldInfo.Name, fieldInfo.Name);
				}
			}
			PropertyInfo[] properties = A_1.GetProperties();
			foreach (PropertyInfo propertyInfo in properties)
			{
				if (!Attribute.IsDefined(propertyInfo, typeof(NonSerializedAttribute)))
				{
					hashtable.Add(propertyInfo.Name, propertyInfo.Name);
				}
			}
			XmlNode[] array = method_24(A_0, "member");
			int num = 0;
			XmlNode[] array2 = array;
			int num2 = 0;
			while (true)
			{
				if (num2 < array2.Length)
				{
					XmlNode xmlNode = array2[num2];
					if (!(xmlNode.Name != "member"))
					{
						method_26(xmlNode, "name", out var A_4, out var A_5, "value", out var A_6, out var A_7);
						if (A_4 == null || A_4.FirstChild == null)
						{
							throw new XmlRpcInvalidXmlRpcException(A_2.ParseType + " contains a member with missing name " + method_22(A_2));
						}
						if (A_5)
						{
							throw new XmlRpcInvalidXmlRpcException(A_2.ParseType + " contains member with more than one name element " + method_22(A_2));
						}
						string text = A_4.FirstChild.Value;
						if (A_6 == null)
						{
							throw new XmlRpcInvalidXmlRpcException(A_2.ParseType + " contains struct member " + text + " with missing value  " + method_22(A_2));
						}
						if (A_7)
						{
							throw new XmlRpcInvalidXmlRpcException(A_2.ParseType + " contains member with more than one value element " + method_22(A_2));
						}
						string text2 = method_10(A_1, text);
						if (text2 != null)
						{
							text = text2;
						}
						MemberInfo memberInfo = A_1.GetField(text);
						if ((object)memberInfo == null)
						{
							memberInfo = A_1.GetProperty(text);
						}
						if ((object)memberInfo != null)
						{
							if (hashtable.Contains(text))
							{
								hashtable.Remove(text);
								object value = null;
								switch (memberInfo.MemberType)
								{
								case MemberTypes.Property:
								{
									PropertyInfo propertyInfo2 = (PropertyInfo)memberInfo;
									if ((object)A_1 == null)
									{
										A_2.Push($"member {text}");
									}
									else
									{
										A_2.Push($"member {text} mapped to type {propertyInfo2.PropertyType.Name}");
									}
									XmlNode a_2 = method_25(A_6);
									value = method_4(a_2, propertyInfo2.PropertyType, A_2, A_3);
									A_2.Pop();
									propertyInfo2.SetValue(obj, value, null);
									break;
								}
								case MemberTypes.Field:
								{
									FieldInfo fieldInfo2 = (FieldInfo)memberInfo;
									if ((object)A_1 == null)
									{
										A_2.Push($"member {text}");
									}
									else
									{
										A_2.Push($"member {text} mapped to type {fieldInfo2.FieldType.Name}");
									}
									try
									{
										XmlNode a_ = method_25(A_6);
										value = method_4(a_, fieldInfo2.FieldType, A_2, A_3);
									}
									catch (XmlRpcInvalidXmlRpcException)
									{
										if ((object)A_1 != null && mappingAction == MappingAction.Error)
										{
											MappingAction mappingAction2 = method_12(A_1, text, MappingAction.Error);
											if (mappingAction2 == MappingAction.Error)
											{
												throw;
											}
										}
									}
									finally
									{
										A_2.Pop();
									}
									fieldInfo2.SetValue(obj, value);
									break;
								}
								}
								num++;
							}
							else
							{
								if (Attribute.IsDefined(memberInfo, typeof(NonSerializedAttribute)))
								{
									A_2.Push($"member {text}");
									throw new XmlRpcNonSerializedMember("Cannot map XML-RPC struct member onto member marked as [NonSerialized]:  " + method_22(A_2));
								}
								if (!IgnoreDuplicateMembers)
								{
									throw new XmlRpcInvalidXmlRpcException(A_2.ParseType + " contains struct value with duplicate member " + A_4.FirstChild.Value + " " + method_22(A_2));
								}
							}
						}
					}
					num2++;
					continue;
				}
				if (mappingAction == MappingAction.Error && hashtable.Count > 0)
				{
					method_9(A_1, hashtable, A_2);
				}
				break;
			}
			A_2.Pop();
			return obj;
		}

		private void method_9(Type A_0, Hashtable A_1, ParseStack A_2)
		{
			StringBuilder stringBuilder = new StringBuilder();
			int num = 0;
			string value = "";
			foreach (string key in A_1.Keys)
			{
				MappingAction mappingAction = method_12(A_0, key, MappingAction.Error);
				if (mappingAction == MappingAction.Error)
				{
					stringBuilder.Append(value);
					stringBuilder.Append(key);
					value = " ";
					num++;
				}
			}
			if (num > 0)
			{
				string text2 = "";
				if (num > 1)
				{
					text2 = "s";
				}
				throw new XmlRpcTypeMismatchException(A_2.ParseType + " contains struct value with missing non-optional member" + text2 + ": " + stringBuilder.ToString() + " " + method_22(A_2));
			}
		}

		private string method_10(Type A_0, string A_1)
		{
			if ((object)A_0 == null)
			{
				return null;
			}
			FieldInfo[] fields = A_0.GetFields();
			int num = 0;
			FieldInfo fieldInfo;
			while (true)
			{
				if (num < fields.Length)
				{
					fieldInfo = fields[num];
					Attribute customAttribute = Attribute.GetCustomAttribute(fieldInfo, typeof(XmlRpcMemberAttribute));
					if (customAttribute != null && customAttribute is XmlRpcMemberAttribute && ((XmlRpcMemberAttribute)customAttribute).Member == A_1)
					{
						break;
					}
					num++;
					continue;
				}
				PropertyInfo[] properties = A_0.GetProperties();
				int num2 = 0;
				PropertyInfo propertyInfo;
				while (true)
				{
					if (num2 < properties.Length)
					{
						propertyInfo = properties[num2];
						Attribute customAttribute2 = Attribute.GetCustomAttribute(propertyInfo, typeof(XmlRpcMemberAttribute));
						if (customAttribute2 != null && customAttribute2 is XmlRpcMemberAttribute && ((XmlRpcMemberAttribute)customAttribute2).Member == A_1)
						{
							break;
						}
						num2++;
						continue;
					}
					return null;
				}
				return propertyInfo.Name;
			}
			return fieldInfo.Name;
		}

		private MappingAction method_11(Type A_0, MappingAction A_1)
		{
			if ((object)A_0 == null)
			{
				return A_1;
			}
			Attribute customAttribute = Attribute.GetCustomAttribute(A_0, typeof(XmlRpcMissingMappingAttribute));
			if (customAttribute != null)
			{
				return ((XmlRpcMissingMappingAttribute)customAttribute).Action;
			}
			return A_1;
		}

		private MappingAction method_12(Type A_0, string A_1, MappingAction A_2)
		{
			if ((object)A_0 == null)
			{
				return A_2;
			}
			Attribute attribute = null;
			FieldInfo field = A_0.GetField(A_1);
			if ((object)field != null)
			{
				attribute = Attribute.GetCustomAttribute(field, typeof(XmlRpcMissingMappingAttribute));
			}
			else
			{
				PropertyInfo property = A_0.GetProperty(A_1);
				attribute = Attribute.GetCustomAttribute(property, typeof(XmlRpcMissingMappingAttribute));
			}
			if (attribute != null)
			{
				return ((XmlRpcMissingMappingAttribute)attribute).Action;
			}
			return A_2;
		}

		private object method_13(XmlNode A_0, Type A_1, ParseStack A_2, MappingAction A_3)
		{
			XmlRpcStruct xmlRpcStruct = new XmlRpcStruct();
			A_2.Push("struct mapped to XmlRpcStruct");
			try
			{
				XmlNode[] array = method_24(A_0, "member");
				XmlNode[] array2 = array;
				foreach (XmlNode xmlNode in array2)
				{
					if (xmlNode.Name != "member")
					{
						continue;
					}
					method_26(xmlNode, "name", out var A_4, out var A_5, "value", out var A_6, out var A_7);
					if (A_4 != null && A_4.FirstChild != null)
					{
						if (!A_5)
						{
							string value = A_4.FirstChild.Value;
							if (A_6 != null)
							{
								if (!A_7)
								{
									if (xmlRpcStruct.Contains(value))
									{
										if (!IgnoreDuplicateMembers)
										{
											throw new XmlRpcInvalidXmlRpcException(A_2.ParseType + " contains struct value with duplicate member " + A_4.FirstChild.Value + " " + method_22(A_2));
										}
									}
									else
									{
										A_2.Push($"member {value}");
										object value2;
										try
										{
											XmlNode a_ = method_25(A_6);
											value2 = method_4(a_, null, A_2, A_3);
										}
										finally
										{
											A_2.Pop();
										}
										xmlRpcStruct.Add(value, value2);
									}
									continue;
								}
								throw new XmlRpcInvalidXmlRpcException(A_2.ParseType + " contains member with more than one value element " + method_22(A_2));
							}
							throw new XmlRpcInvalidXmlRpcException(A_2.ParseType + " contains struct member " + value + " with missing value  " + method_22(A_2));
						}
						throw new XmlRpcInvalidXmlRpcException(A_2.ParseType + " contains member with more than one name element " + method_22(A_2));
					}
					throw new XmlRpcInvalidXmlRpcException(A_2.ParseType + " contains a member with missing name " + method_22(A_2));
				}
				return xmlRpcStruct;
			}
			finally
			{
				A_2.Pop();
			}
		}

		private object method_14(XmlNode A_0, Type A_1, ParseStack A_2, MappingAction A_3)
		{
			if ((object)A_1 != null && (object)A_1 != typeof(object) && (object)A_1 != typeof(int) && (object)A_1 != typeof(int?) && (object)A_1 != typeof(XmlRpcInt))
			{
				throw new XmlRpcTypeMismatchException(A_2.ParseType + " contains int value where " + XmlRpcServiceInfo.GetXmlRpcTypeString(A_1) + " expected " + method_22(A_2));
			}
			A_2.Push("integer");
			int num;
			try
			{
				XmlNode firstChild = A_0.FirstChild;
				if (firstChild == null)
				{
					throw new XmlRpcInvalidXmlRpcException(A_2.ParseType + " contains invalid int element " + method_22(A_2));
				}
				try
				{
					string value = firstChild.Value;
					num = int.Parse(value);
				}
				catch (Exception)
				{
					throw new XmlRpcInvalidXmlRpcException(A_2.ParseType + " contains invalid int value " + method_22(A_2));
				}
			}
			finally
			{
				A_2.Pop();
			}
			if ((object)A_1 == typeof(XmlRpcInt))
			{
				return new XmlRpcInt(num);
			}
			return num;
		}

		private object method_15(XmlNode A_0, Type A_1, ParseStack A_2, MappingAction A_3)
		{
			if ((object)A_1 != null && (object)A_1 != typeof(string) && (object)A_1 != typeof(object))
			{
				throw new XmlRpcTypeMismatchException(A_2.ParseType + " contains string value where " + XmlRpcServiceInfo.GetXmlRpcTypeString(A_1) + " expected " + method_22(A_2));
			}
			A_2.Push("string");
			try
			{
				if (A_0.FirstChild == null)
				{
					return "";
				}
				return A_0.FirstChild.Value;
			}
			finally
			{
				A_2.Pop();
			}
		}

		private object method_16(XmlNode A_0, Type A_1, ParseStack A_2, MappingAction A_3)
		{
			if ((object)A_1 != null && (object)A_1 != typeof(object) && (object)A_1 != typeof(bool) && (object)A_1 != typeof(bool?) && (object)A_1 != typeof(XmlRpcBoolean))
			{
				throw new XmlRpcTypeMismatchException(A_2.ParseType + " contains boolean value where " + XmlRpcServiceInfo.GetXmlRpcTypeString(A_1) + " expected " + method_22(A_2));
			}
			A_2.Push("boolean");
			bool flag;
			try
			{
				string value = A_0.FirstChild.Value;
				if (value == "1")
				{
					flag = true;
				}
				else
				{
					if (!(value == "0"))
					{
						throw new XmlRpcInvalidXmlRpcException("reponse contains invalid boolean value " + method_22(A_2));
					}
					flag = false;
				}
			}
			finally
			{
				A_2.Pop();
			}
			if ((object)A_1 == typeof(XmlRpcBoolean))
			{
				return new XmlRpcBoolean(flag);
			}
			return flag;
		}

		private object method_17(XmlNode A_0, Type A_1, ParseStack A_2, MappingAction A_3)
		{
			if ((object)A_1 != null && (object)A_1 != typeof(object) && (object)A_1 != typeof(double) && (object)A_1 != typeof(double?) && (object)A_1 != typeof(XmlRpcDouble))
			{
				throw new XmlRpcTypeMismatchException(A_2.ParseType + " contains double value where " + XmlRpcServiceInfo.GetXmlRpcTypeString(A_1) + " expected " + method_22(A_2));
			}
			A_2.Push("double");
			double num;
			try
			{
				num = double.Parse(A_0.FirstChild.Value, CultureInfo.InvariantCulture.NumberFormat);
			}
			catch (Exception)
			{
				throw new XmlRpcInvalidXmlRpcException(A_2.ParseType + " contains invalid double value " + method_22(A_2));
			}
			finally
			{
				A_2.Pop();
			}
			if ((object)A_1 == typeof(XmlRpcDouble))
			{
				return new XmlRpcDouble(num);
			}
			return num;
		}

		private object method_18(XmlNode A_0, Type A_1, ParseStack A_2, MappingAction A_3)
		{
			if ((object)A_1 != null && (object)A_1 != typeof(object) && (object)A_1 != typeof(DateTime) && (object)A_1 != typeof(DateTime?) && (object)A_1 != typeof(XmlRpcDateTime))
			{
				throw new XmlRpcTypeMismatchException(A_2.ParseType + " contains dateTime.iso8601 value where " + XmlRpcServiceInfo.GetXmlRpcTypeString(A_1) + " expected " + method_22(A_2));
			}
			A_2.Push("dateTime");
			DateTime dateTime;
			try
			{
				XmlNode firstChild = A_0.FirstChild;
				if (firstChild == null)
				{
					if (MapEmptyDateTimeToMinValue)
					{
						return DateTime.MinValue;
					}
					throw new XmlRpcInvalidXmlRpcException(A_2.ParseType + " contains empty dateTime value " + method_22(A_2));
				}
				string text = firstChild.Value;
				try
				{
					string format = "yyyyMMdd'T'HH':'mm':'ss";
					if (AllowNonStandardDateTime)
					{
						if (text.IndexOf("T") != 8)
						{
							format = ((!text.EndsWith("Z")) ? "yyyy'-'MM'-'dd'T'HH':'mm':'ss" : "yyyy'-'MM'-'dd'T'HH':'mm':'ss'Z'");
						}
						else if (text.EndsWith("Z"))
						{
							format = "yyyyMMdd'T'HH':'mm':'ss'Z'";
						}
						else if (text.EndsWith("-00") || text.EndsWith("-0000") || text.EndsWith("+00") || text.EndsWith("+0000"))
						{
							text = text.Substring(0, 17);
						}
					}
					if (MapZerosDateTimeToMinValue && text.StartsWith("0000"))
					{
						switch (text)
						{
						case "00000000T00:00:00":
						case "0000-00-00T00:00:00Z":
						case "00000000T00:00:00Z":
						case "0000-00-00T00:00:00":
							dateTime = DateTime.MinValue;
							goto end_IL_00cf;
						}
					}
					dateTime = DateTime.ParseExact(text, format, DateTimeFormatInfo.InvariantInfo);
					end_IL_00cf:;
				}
				catch (Exception)
				{
					throw new XmlRpcInvalidXmlRpcException(A_2.ParseType + " contains invalid dateTime value " + method_22(A_2));
				}
			}
			finally
			{
				A_2.Pop();
			}
			if ((object)A_1 == typeof(XmlRpcDateTime))
			{
				return new XmlRpcDateTime(dateTime);
			}
			return dateTime;
		}

		private object method_19(XmlNode A_0, Type A_1, ParseStack A_2, MappingAction A_3)
		{
			if ((object)A_1 != null && (object)A_1 != typeof(byte[]) && (object)A_1 != typeof(object))
			{
				throw new XmlRpcTypeMismatchException(A_2.ParseType + " contains base64 value where " + XmlRpcServiceInfo.GetXmlRpcTypeString(A_1) + " expected " + method_22(A_2));
			}
			A_2.Push("base64");
			try
			{
				if (A_0.FirstChild == null)
				{
					return new byte[0];
				}
				string value = A_0.FirstChild.Value;
				try
				{
					return Convert.FromBase64String(value);
				}
				catch (Exception)
				{
					throw new XmlRpcInvalidXmlRpcException(A_2.ParseType + " contains invalid base64 value " + method_22(A_2));
				}
			}
			finally
			{
				A_2.Pop();
			}
		}

		private XmlRpcFaultException method_20(XmlNode A_0, ParseStack A_1, MappingAction A_2)
		{
			XmlNode a_ = method_23(A_0, "value");
			XmlNode xmlNode = method_23(a_, "struct");
			if (xmlNode == null)
			{
				throw new XmlRpcInvalidXmlRpcException("struct element missing from fault response.");
			}
			Struct0 @struct = default(Struct0);
			try
			{
				@struct = (Struct0)method_4(xmlNode, typeof(Struct0), A_1, A_2);
			}
			catch (Exception ex)
			{
				if (AllowStringFaultCode)
				{
					throw;
				}
				try
				{
					Struct2 struct2 = (Struct2)method_4(xmlNode, typeof(Struct2), A_1, A_2);
					@struct.int_0 = Convert.ToInt32(struct2.string_0);
					@struct.string_0 = struct2.string_1;
				}
				catch (Exception)
				{
					throw ex;
				}
			}
			return new XmlRpcFaultException(@struct.int_0, @struct.string_0);
		}

		public void SerializeFaultResponse(Stream stm, XmlRpcFaultException faultEx)
		{
			Struct1 @struct = default(Struct1);
			@struct.int_0 = faultEx.FaultCode;
			@struct.string_0 = faultEx.FaultString;
			XmlTextWriter xmlTextWriter = new XmlTextWriter(stm, encoding_0);
			method_21(xmlTextWriter);
			xmlTextWriter.WriteStartDocument();
			xmlTextWriter.WriteStartElement("", "methodResponse", "");
			xmlTextWriter.WriteStartElement("", "fault", "");
			Serialize(xmlTextWriter, @struct, MappingAction.Error);
			xmlTextWriter.WriteEndElement();
			xmlTextWriter.WriteEndElement();
			xmlTextWriter.Flush();
		}

		private void method_21(XmlTextWriter A_0)
		{
			if (bool_1)
			{
				A_0.Formatting = Formatting.Indented;
				A_0.Indentation = int_0;
			}
			else
			{
				A_0.Formatting = Formatting.None;
			}
		}

		private string method_22(ParseStack A_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (string item in A_0)
			{
				stringBuilder.Insert(0, item);
				stringBuilder.Insert(0, " : ");
			}
			stringBuilder.Insert(0, A_0.ParseType);
			stringBuilder.Insert(0, "[");
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		private XmlNode method_23(XmlNode A_0, string A_1)
		{
			return A_0.SelectSingleNode(A_1);
		}

		private XmlNode[] method_24(XmlNode A_0, string A_1)
		{
			ArrayList arrayList = new ArrayList();
			foreach (XmlNode childNode in A_0.ChildNodes)
			{
				if (childNode.Name == A_1)
				{
					arrayList.Add(childNode);
				}
			}
			return (XmlNode[])arrayList.ToArray(typeof(XmlNode));
		}

		private XmlNode method_25(XmlNode A_0)
		{
			XmlNode xmlNode = method_23(A_0, "*");
			if (xmlNode == null)
			{
				xmlNode = A_0.FirstChild;
			}
			return xmlNode;
		}

		private void method_26(XmlNode A_0, string A_1, out XmlNode A_2, out bool A_3, string A_4, out XmlNode A_5, out bool A_6)
		{
			A_2 = (A_5 = null);
			A_6 = false;
			A_3 = false;
			foreach (XmlNode childNode in A_0.ChildNodes)
			{
				if (childNode.Name == A_1)
				{
					if (A_2 == null)
					{
						A_2 = childNode;
					}
					else
					{
						A_3 = true;
					}
				}
				else if (childNode.Name == A_4)
				{
					if (A_5 == null)
					{
						A_5 = childNode;
					}
					else
					{
						A_6 = true;
					}
				}
			}
		}

		private object method_27(Type A_0, object[] A_1)
		{
			return Activator.CreateInstance(A_0, A_1);
		}

		private bool method_28(MethodInfo A_0)
		{
			if ((object)A_0 == null)
			{
				return false;
			}
			bool result = false;
			Attribute customAttribute = Attribute.GetCustomAttribute(A_0, typeof(XmlRpcMethodAttribute));
			if (customAttribute != null)
			{
				XmlRpcMethodAttribute xmlRpcMethodAttribute = (XmlRpcMethodAttribute)customAttribute;
				result = xmlRpcMethodAttribute.StructParams;
			}
			return result;
		}
	}
}
