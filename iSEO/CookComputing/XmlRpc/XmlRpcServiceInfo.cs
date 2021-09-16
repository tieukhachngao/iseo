using System;
using System.Collections;
using System.Reflection;

namespace CookComputing.XmlRpc
{
	public class XmlRpcServiceInfo
	{
		private XmlRpcMethodInfo[] xmlRpcMethodInfo_0;

		private string string_0;

		private string string_1;

		public string Doc
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

		public string Name
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

		public XmlRpcMethodInfo[] Methods => xmlRpcMethodInfo_0;

		public static XmlRpcServiceInfo CreateServiceInfo(Type type)
		{
			XmlRpcServiceInfo xmlRpcServiceInfo = new XmlRpcServiceInfo();
			XmlRpcServiceAttribute xmlRpcServiceAttribute = (XmlRpcServiceAttribute)Attribute.GetCustomAttribute(type, typeof(XmlRpcServiceAttribute));
			if (xmlRpcServiceAttribute != null && xmlRpcServiceAttribute.Description != "")
			{
				xmlRpcServiceInfo.string_0 = xmlRpcServiceAttribute.Description;
			}
			if (xmlRpcServiceAttribute != null && xmlRpcServiceAttribute.Name != "")
			{
				xmlRpcServiceInfo.Name = xmlRpcServiceAttribute.Name;
			}
			else
			{
				xmlRpcServiceInfo.Name = type.Name;
			}
			Hashtable hashtable = new Hashtable();
			Type[] interfaces = type.GetInterfaces();
			foreach (Type type2 in interfaces)
			{
				XmlRpcServiceAttribute xmlRpcServiceAttribute2 = (XmlRpcServiceAttribute)Attribute.GetCustomAttribute(type2, typeof(XmlRpcServiceAttribute));
				if (xmlRpcServiceAttribute2 != null)
				{
					xmlRpcServiceInfo.string_0 = xmlRpcServiceAttribute2.Description;
				}
				MethodInfo[] interfaceMethods = type.GetInterfaceMap(type2).InterfaceMethods;
				foreach (MethodInfo a_ in interfaceMethods)
				{
					smethod_0(hashtable, a_, type2);
				}
			}
			MethodInfo[] methods = type.GetMethods();
			foreach (MethodInfo methodInfo in methods)
			{
				ArrayList arrayList = new ArrayList();
				arrayList.Add(methodInfo);
				MethodInfo methodInfo2 = methodInfo;
				while (true)
				{
					MethodInfo baseDefinition = methodInfo2.GetBaseDefinition();
					if ((object)baseDefinition.DeclaringType == methodInfo2.DeclaringType)
					{
						break;
					}
					arrayList.Insert(0, baseDefinition);
					methodInfo2 = baseDefinition;
				}
				foreach (MethodInfo item in arrayList)
				{
					smethod_0(hashtable, item, type);
				}
			}
			xmlRpcServiceInfo.xmlRpcMethodInfo_0 = new XmlRpcMethodInfo[hashtable.Count];
			hashtable.Values.CopyTo(xmlRpcServiceInfo.xmlRpcMethodInfo_0, 0);
			Array.Sort(xmlRpcServiceInfo.xmlRpcMethodInfo_0);
			return xmlRpcServiceInfo;
		}

		private static void smethod_0(Hashtable A_0, MethodInfo A_1, Type A_2)
		{
			XmlRpcMethodAttribute xmlRpcMethodAttribute = (XmlRpcMethodAttribute)Attribute.GetCustomAttribute(A_1, typeof(XmlRpcMethodAttribute));
			if (xmlRpcMethodAttribute == null)
			{
				return;
			}
			XmlRpcMethodInfo xmlRpcMethodInfo = new XmlRpcMethodInfo();
			xmlRpcMethodInfo.MethodInfo = A_1;
			xmlRpcMethodInfo.XmlRpcName = GetXmlRpcMethodName(A_1);
			xmlRpcMethodInfo.MiName = A_1.Name;
			xmlRpcMethodInfo.Doc = xmlRpcMethodAttribute.Description;
			xmlRpcMethodInfo.IsHidden = xmlRpcMethodAttribute.IntrospectionMethod | xmlRpcMethodAttribute.Hidden;
			ArrayList arrayList = new ArrayList();
			ParameterInfo[] parameters = A_1.GetParameters();
			ParameterInfo[] array = parameters;
			foreach (ParameterInfo parameterInfo in array)
			{
				XmlRpcParameterInfo xmlRpcParameterInfo = new XmlRpcParameterInfo();
				xmlRpcParameterInfo.Name = parameterInfo.Name;
				xmlRpcParameterInfo.Type = parameterInfo.ParameterType;
				xmlRpcParameterInfo.XmlRpcType = GetXmlRpcTypeString(parameterInfo.ParameterType);
				xmlRpcParameterInfo.Doc = "";
				XmlRpcParameterAttribute xmlRpcParameterAttribute = (XmlRpcParameterAttribute)Attribute.GetCustomAttribute(parameterInfo, typeof(XmlRpcParameterAttribute));
				if (xmlRpcParameterAttribute != null)
				{
					xmlRpcParameterInfo.Doc = xmlRpcParameterAttribute.Description;
					xmlRpcParameterInfo.XmlRpcName = xmlRpcParameterAttribute.Name;
				}
				xmlRpcParameterInfo.IsParams = Attribute.IsDefined(parameterInfo, typeof(ParamArrayAttribute));
				arrayList.Add(xmlRpcParameterInfo);
			}
			xmlRpcMethodInfo.Parameters = (XmlRpcParameterInfo[])arrayList.ToArray(typeof(XmlRpcParameterInfo));
			xmlRpcMethodInfo.ReturnType = A_1.ReturnType;
			xmlRpcMethodInfo.ReturnXmlRpcType = GetXmlRpcTypeString(A_1.ReturnType);
			object[] customAttributes = A_1.ReturnTypeCustomAttributes.GetCustomAttributes(typeof(XmlRpcReturnValueAttribute), inherit: false);
			if (customAttributes.Length > 0)
			{
				xmlRpcMethodInfo.ReturnDoc = ((XmlRpcReturnValueAttribute)customAttributes[0]).Description;
			}
			if (A_0[xmlRpcMethodInfo.XmlRpcName] != null)
			{
				throw new XmlRpcDupXmlRpcMethodNames($"Method {A_1.Name} in type {A_2.Name} has duplicate XmlRpc method name {xmlRpcMethodInfo.XmlRpcName}");
			}
			A_0.Add(xmlRpcMethodInfo.XmlRpcName, xmlRpcMethodInfo);
		}

		public MethodInfo GetMethodInfo(string xmlRpcMethodName)
		{
			XmlRpcMethodInfo[] array = xmlRpcMethodInfo_0;
			int num = 0;
			XmlRpcMethodInfo xmlRpcMethodInfo;
			while (true)
			{
				if (num < array.Length)
				{
					xmlRpcMethodInfo = array[num];
					if (xmlRpcMethodName == xmlRpcMethodInfo.XmlRpcName)
					{
						break;
					}
					num++;
					continue;
				}
				return null;
			}
			return xmlRpcMethodInfo.MethodInfo;
		}

		private static bool smethod_1(MethodInfo A_0)
		{
			bool result = false;
			Attribute customAttribute = Attribute.GetCustomAttribute(A_0, typeof(XmlRpcMethodAttribute));
			if (customAttribute != null)
			{
				XmlRpcMethodAttribute xmlRpcMethodAttribute = (XmlRpcMethodAttribute)customAttribute;
				result = !xmlRpcMethodAttribute.Hidden && !xmlRpcMethodAttribute.IntrospectionMethod;
			}
			return result;
		}

		public static string GetXmlRpcMethodName(MethodInfo mi)
		{
			XmlRpcMethodAttribute xmlRpcMethodAttribute = (XmlRpcMethodAttribute)Attribute.GetCustomAttribute(mi, typeof(XmlRpcMethodAttribute));
			if (xmlRpcMethodAttribute != null && xmlRpcMethodAttribute.Method != null && xmlRpcMethodAttribute.Method != "")
			{
				return xmlRpcMethodAttribute.Method;
			}
			return mi.Name;
		}

		public string GetMethodName(string XmlRpcMethodName)
		{
			XmlRpcMethodInfo[] array = xmlRpcMethodInfo_0;
			int num = 0;
			XmlRpcMethodInfo xmlRpcMethodInfo;
			while (true)
			{
				if (num < array.Length)
				{
					xmlRpcMethodInfo = array[num];
					if (xmlRpcMethodInfo.XmlRpcName == XmlRpcMethodName)
					{
						break;
					}
					num++;
					continue;
				}
				return null;
			}
			return xmlRpcMethodInfo.MiName;
		}

		public XmlRpcMethodInfo GetMethod(string methodName)
		{
			XmlRpcMethodInfo[] array = xmlRpcMethodInfo_0;
			int num = 0;
			XmlRpcMethodInfo xmlRpcMethodInfo;
			while (true)
			{
				if (num < array.Length)
				{
					xmlRpcMethodInfo = array[num];
					if (xmlRpcMethodInfo.XmlRpcName == methodName)
					{
						break;
					}
					num++;
					continue;
				}
				return null;
			}
			return xmlRpcMethodInfo;
		}

		private XmlRpcServiceInfo()
		{
		}

		public static XmlRpcType GetXmlRpcType(Type t)
		{
			if ((object)t == typeof(int))
			{
				return XmlRpcType.tInt32;
			}
			if ((object)t == typeof(XmlRpcInt))
			{
				return XmlRpcType.tInt32;
			}
			if ((object)t == typeof(bool))
			{
				return XmlRpcType.tBoolean;
			}
			if ((object)t == typeof(XmlRpcBoolean))
			{
				return XmlRpcType.tBoolean;
			}
			if ((object)t == typeof(string))
			{
				return XmlRpcType.tString;
			}
			if ((object)t == typeof(double))
			{
				return XmlRpcType.tDouble;
			}
			if ((object)t == typeof(XmlRpcDouble))
			{
				return XmlRpcType.tDouble;
			}
			if ((object)t == typeof(DateTime))
			{
				return XmlRpcType.tDateTime;
			}
			if ((object)t == typeof(XmlRpcDateTime))
			{
				return XmlRpcType.tDateTime;
			}
			if ((object)t == typeof(byte[]))
			{
				return XmlRpcType.tBase64;
			}
			if ((object)t == typeof(XmlRpcStruct))
			{
				return XmlRpcType.tHashtable;
			}
			if ((object)t == typeof(Array))
			{
				return XmlRpcType.tArray;
			}
			if (t.IsArray)
			{
				Type elementType = t.GetElementType();
				if ((object)elementType != typeof(object) && GetXmlRpcType(elementType) == XmlRpcType.tInvalid)
				{
					return XmlRpcType.tInvalid;
				}
				if (t.GetArrayRank() == 1)
				{
					return XmlRpcType.tArray;
				}
				return XmlRpcType.tMultiDimArray;
			}
			if ((object)t == typeof(int?))
			{
				return XmlRpcType.tInt32;
			}
			if ((object)t == typeof(bool?))
			{
				return XmlRpcType.tBoolean;
			}
			if ((object)t == typeof(double?))
			{
				return XmlRpcType.tDouble;
			}
			if ((object)t == typeof(DateTime?))
			{
				return XmlRpcType.tDateTime;
			}
			if ((object)t == typeof(void))
			{
				return XmlRpcType.tVoid;
			}
			if ((t.IsValueType && !t.IsPrimitive && !t.IsEnum) || t.IsClass)
			{
				MemberInfo[] members = t.GetMembers();
				MemberInfo[] array = members;
				int num = 0;
				while (true)
				{
					if (num < array.Length)
					{
						MemberInfo memberInfo = array[num];
						if (memberInfo.MemberType == MemberTypes.Field)
						{
							FieldInfo fieldInfo = (FieldInfo)memberInfo;
							if ((object)fieldInfo.FieldType == t || ((object)fieldInfo.FieldType != typeof(object) && GetXmlRpcType(fieldInfo.FieldType) == XmlRpcType.tInvalid))
							{
								return XmlRpcType.tInvalid;
							}
						}
						else if (memberInfo.MemberType == MemberTypes.Property)
						{
							PropertyInfo propertyInfo = (PropertyInfo)memberInfo;
							if ((object)propertyInfo.PropertyType == t || ((object)propertyInfo.PropertyType != typeof(object) && GetXmlRpcType(propertyInfo.PropertyType) == XmlRpcType.tInvalid))
							{
								break;
							}
						}
						num++;
						continue;
					}
					return XmlRpcType.tStruct;
				}
				return XmlRpcType.tInvalid;
			}
			return XmlRpcType.tInvalid;
		}

		public static string GetXmlRpcTypeString(Type t)
		{
			XmlRpcType xmlRpcType = GetXmlRpcType(t);
			return GetXmlRpcTypeString(xmlRpcType);
		}

		public static string GetXmlRpcTypeString(XmlRpcType t)
		{
			string text = null;
			return t switch
			{
				XmlRpcType.tInt32 => "integer", 
				XmlRpcType.tBoolean => "boolean", 
				XmlRpcType.tString => "string", 
				XmlRpcType.tDouble => "double", 
				XmlRpcType.tDateTime => "dateTime", 
				XmlRpcType.tBase64 => "base64", 
				XmlRpcType.tStruct => "struct", 
				XmlRpcType.tHashtable => "struct", 
				XmlRpcType.tArray => "array", 
				XmlRpcType.tMultiDimArray => "array", 
				XmlRpcType.tVoid => "void", 
				_ => null, 
			};
		}
	}
}
