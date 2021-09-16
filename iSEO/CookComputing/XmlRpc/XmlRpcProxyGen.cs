using System;
using System.Collections;
using System.Reflection;
using System.Reflection.Emit;

namespace CookComputing.XmlRpc
{
	public class XmlRpcProxyGen
	{
		private class Class65
		{
			public MethodInfo methodInfo_0;

			public string string_0;

			public Type type_0;

			public bool bool_0;

			public Class65(MethodInfo A_0, string A_1, bool A_2)
			{
				methodInfo_0 = A_0;
				string_0 = A_1;
				bool_0 = A_2;
				type_0 = null;
			}

			public Class65(MethodInfo A_0, string A_1, bool A_2, Type A_3)
			{
				methodInfo_0 = A_0;
				string_0 = A_1;
				bool_0 = A_2;
				type_0 = A_3;
			}
		}

		private static Hashtable hashtable_0 = new Hashtable();

		public static T Create<T>()
		{
			return (T)Create(typeof(T));
		}

		public static object Create(Type itf)
		{
			Type type;
			lock (typeof(XmlRpcProxyGen))
			{
				type = (Type)hashtable_0[itf];
				if ((object)type == null)
				{
					Guid guid = Guid.NewGuid();
					string a_ = "XmlRpcProxy" + guid.ToString();
					string a_2 = "XmlRpcProxy" + guid.ToString() + ".dll";
					string text = "XmlRpcProxy" + guid.ToString();
					AssemblyBuilder assemblyBuilder = smethod_0(itf, a_, a_2, text);
					type = assemblyBuilder.GetType(text);
					hashtable_0.Add(itf, type);
				}
			}
			return Activator.CreateInstance(type);
		}

		public static object CreateAssembly(Type itf, string typeName, string assemblyName)
		{
			if (assemblyName.IndexOf(".dll") == assemblyName.Length - 4)
			{
				assemblyName = assemblyName.Substring(0, assemblyName.Length - 4);
			}
			string text = assemblyName + ".dll";
			AssemblyBuilder assemblyBuilder = smethod_0(itf, assemblyName, text, typeName);
			Type type = assemblyBuilder.GetType(typeName);
			object result = Activator.CreateInstance(type);
			assemblyBuilder.Save(text);
			return result;
		}

		private static AssemblyBuilder smethod_0(Type A_0, string A_1, string A_2, string A_3)
		{
			string a_ = smethod_6(A_0);
			ArrayList a_2 = smethod_8(A_0);
			ArrayList a_3 = smethod_10(A_0);
			ArrayList a_4 = smethod_11(A_0);
			AssemblyName assemblyName = new AssemblyName();
			assemblyName.Name = A_1;
			assemblyName.Version = A_0.Assembly.GetName().Version;
			AssemblyBuilder assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.RunAndSave);
			ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule(assemblyName.Name, A_2);
			TypeBuilder typeBuilder = moduleBuilder.DefineType(A_3, TypeAttributes.Public | TypeAttributes.Sealed, typeof(XmlRpcClientProtocol), new Type[1] { A_0 });
			smethod_5(typeBuilder, typeof(XmlRpcClientProtocol), a_);
			smethod_1(typeBuilder, a_2);
			smethod_3(typeBuilder, a_3);
			smethod_4(typeBuilder, a_4);
			typeBuilder.CreateType();
			return assemblyBuilder;
		}

		private static void smethod_1(TypeBuilder A_0, ArrayList A_1)
		{
			foreach (Class65 item in A_1)
			{
				MethodInfo methodInfo_ = item.methodInfo_0;
				Type[] array = new Type[methodInfo_.GetParameters().Length];
				string[] array2 = new string[methodInfo_.GetParameters().Length];
				for (int i = 0; i < methodInfo_.GetParameters().Length; i++)
				{
					array[i] = methodInfo_.GetParameters()[i].ParameterType;
					array2[i] = methodInfo_.GetParameters()[i].Name;
				}
				XmlRpcMethodAttribute xmlRpcMethodAttribute = (XmlRpcMethodAttribute)Attribute.GetCustomAttribute(methodInfo_, typeof(XmlRpcMethodAttribute));
				smethod_2(A_0, methodInfo_.Name, item.string_0, array2, array, item.bool_0, methodInfo_.ReturnType, xmlRpcMethodAttribute.StructParams);
			}
		}

		private static void smethod_2(TypeBuilder A_0, string A_1, string A_2, string[] A_3, Type[] A_4, bool A_5, Type A_6, bool A_7)
		{
			MethodBuilder methodBuilder = A_0.DefineMethod(A_1, MethodAttributes.Public | MethodAttributes.Virtual, A_6, A_4);
			Type[] types = new Type[1] { typeof(string) };
			Type typeFromHandle = typeof(XmlRpcMethodAttribute);
			ConstructorInfo constructor = typeFromHandle.GetConstructor(types);
			PropertyInfo[] namedProperties = new PropertyInfo[1] { typeFromHandle.GetProperty("StructParams") };
			object[] propertyValues = new object[1] { A_7 };
			CustomAttributeBuilder customAttribute = new CustomAttributeBuilder(constructor, new object[1] { A_2 }, namedProperties, propertyValues);
			methodBuilder.SetCustomAttribute(customAttribute);
			for (int i = 0; i < A_3.Length; i++)
			{
				ParameterBuilder parameterBuilder = methodBuilder.DefineParameter(i + 1, ParameterAttributes.In, A_3[i]);
				if (i == A_3.Length - 1 && A_5)
				{
					ConstructorInfo constructor2 = typeof(ParamArrayAttribute).GetConstructor(new Type[0]);
					CustomAttributeBuilder customAttribute2 = new CustomAttributeBuilder(constructor2, new object[0]);
					parameterBuilder.SetCustomAttribute(customAttribute2);
				}
			}
			ILGenerator iLGenerator = methodBuilder.GetILGenerator();
			LocalBuilder local = null;
			LocalBuilder local2 = null;
			if ((object)typeof(void) != A_6)
			{
				local2 = iLGenerator.DeclareLocal(typeof(object));
				local = iLGenerator.DeclareLocal(A_6);
			}
			LocalBuilder local3 = iLGenerator.DeclareLocal(typeof(object[]));
			iLGenerator.Emit(OpCodes.Ldc_I4, A_4.Length);
			iLGenerator.Emit(OpCodes.Newarr, typeof(object));
			iLGenerator.Emit(OpCodes.Stloc, local3);
			for (int j = 0; j < A_4.Length; j++)
			{
				iLGenerator.Emit(OpCodes.Ldloc, local3);
				iLGenerator.Emit(OpCodes.Ldc_I4, j);
				iLGenerator.Emit(OpCodes.Ldarg, j + 1);
				if (A_4[j].IsValueType)
				{
					iLGenerator.Emit(OpCodes.Box, A_4[j]);
				}
				iLGenerator.Emit(OpCodes.Stelem_Ref);
			}
			Type[] types2 = new Type[2]
			{
				typeof(MethodInfo),
				typeof(object[])
			};
			MethodInfo method = typeof(XmlRpcClientProtocol).GetMethod("Invoke", types2);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Call, typeof(MethodBase).GetMethod("GetCurrentMethod"));
			iLGenerator.Emit(OpCodes.Castclass, typeof(MethodInfo));
			iLGenerator.Emit(OpCodes.Ldloc, local3);
			iLGenerator.Emit(OpCodes.Call, method);
			if ((object)typeof(void) != A_6)
			{
				Label label = iLGenerator.DefineLabel();
				iLGenerator.Emit(OpCodes.Stloc, local2);
				iLGenerator.Emit(OpCodes.Ldloc, local2);
				iLGenerator.Emit(OpCodes.Brfalse, label);
				iLGenerator.Emit(OpCodes.Ldloc, local2);
				if (A_6.IsValueType)
				{
					iLGenerator.Emit(OpCodes.Unbox, A_6);
					iLGenerator.Emit(OpCodes.Ldobj, A_6);
				}
				else
				{
					iLGenerator.Emit(OpCodes.Castclass, A_6);
				}
				iLGenerator.Emit(OpCodes.Stloc, local);
				iLGenerator.MarkLabel(label);
				iLGenerator.Emit(OpCodes.Ldloc, local);
			}
			else
			{
				iLGenerator.Emit(OpCodes.Pop);
			}
			iLGenerator.Emit(OpCodes.Ret);
		}

		private static void smethod_3(TypeBuilder A_0, ArrayList A_1)
		{
			foreach (Class65 item in A_1)
			{
				MethodInfo methodInfo_ = item.methodInfo_0;
				int num = methodInfo_.GetParameters().Length;
				int num2 = num;
				Type[] array = new Type[num];
				for (int i = 0; i < methodInfo_.GetParameters().Length; i++)
				{
					array[i] = methodInfo_.GetParameters()[i].ParameterType;
					if ((object)array[i] == typeof(AsyncCallback))
					{
						num2 = i;
					}
				}
				MethodBuilder methodBuilder = A_0.DefineMethod(methodInfo_.Name, MethodAttributes.Public | MethodAttributes.Virtual, methodInfo_.ReturnType, array);
				Type[] types = new Type[1] { typeof(string) };
				Type typeFromHandle = typeof(XmlRpcBeginAttribute);
				ConstructorInfo constructor = typeFromHandle.GetConstructor(types);
				CustomAttributeBuilder customAttribute = new CustomAttributeBuilder(constructor, new object[1] { item.string_0 });
				methodBuilder.SetCustomAttribute(customAttribute);
				ILGenerator iLGenerator = methodBuilder.GetILGenerator();
				LocalBuilder local = iLGenerator.DeclareLocal(typeof(object[]));
				iLGenerator.Emit(OpCodes.Ldc_I4, num2);
				iLGenerator.Emit(OpCodes.Newarr, typeof(object));
				iLGenerator.Emit(OpCodes.Stloc, local);
				for (int j = 0; j < num2; j++)
				{
					iLGenerator.Emit(OpCodes.Ldloc, local);
					iLGenerator.Emit(OpCodes.Ldc_I4, j);
					iLGenerator.Emit(OpCodes.Ldarg, j + 1);
					ParameterInfo parameterInfo = methodInfo_.GetParameters()[j];
					string assemblyQualifiedName = parameterInfo.ParameterType.AssemblyQualifiedName;
					assemblyQualifiedName = assemblyQualifiedName.Replace("&", "");
					Type type = Type.GetType(assemblyQualifiedName);
					if (type.IsValueType)
					{
						iLGenerator.Emit(OpCodes.Box, type);
					}
					iLGenerator.Emit(OpCodes.Stelem_Ref);
				}
				LocalBuilder local2 = iLGenerator.DeclareLocal(typeof(AsyncCallback));
				if (num2 < num)
				{
					iLGenerator.Emit(OpCodes.Ldarg, num2 + 1);
					iLGenerator.Emit(OpCodes.Stloc, local2);
				}
				LocalBuilder local3 = iLGenerator.DeclareLocal(typeof(object));
				if (num2 < num - 1)
				{
					iLGenerator.Emit(OpCodes.Ldarg, num2 + 2);
					iLGenerator.Emit(OpCodes.Stloc, local3);
				}
				Type[] types2 = new Type[5]
				{
					typeof(MethodInfo),
					typeof(object[]),
					typeof(object),
					typeof(AsyncCallback),
					typeof(object)
				};
				MethodInfo method = typeof(XmlRpcClientProtocol).GetMethod("BeginInvoke", types2);
				iLGenerator.Emit(OpCodes.Ldarg_0);
				iLGenerator.Emit(OpCodes.Call, typeof(MethodBase).GetMethod("GetCurrentMethod"));
				iLGenerator.Emit(OpCodes.Castclass, typeof(MethodInfo));
				iLGenerator.Emit(OpCodes.Ldloc, local);
				iLGenerator.Emit(OpCodes.Ldarg_0);
				iLGenerator.Emit(OpCodes.Ldloc, local2);
				iLGenerator.Emit(OpCodes.Ldloc, local3);
				iLGenerator.Emit(OpCodes.Call, method);
				iLGenerator.Emit(OpCodes.Ret);
			}
		}

		private static void smethod_4(TypeBuilder A_0, ArrayList A_1)
		{
			LocalBuilder local = null;
			LocalBuilder local2 = null;
			foreach (Class65 item in A_1)
			{
				MethodInfo methodInfo_ = item.methodInfo_0;
				Type[] parameterTypes = new Type[1] { typeof(IAsyncResult) };
				MethodBuilder methodBuilder = A_0.DefineMethod(methodInfo_.Name, MethodAttributes.Public | MethodAttributes.Virtual, methodInfo_.ReturnType, parameterTypes);
				ILGenerator iLGenerator = methodBuilder.GetILGenerator();
				if ((object)typeof(void) != methodInfo_.ReturnType)
				{
					local2 = iLGenerator.DeclareLocal(typeof(object));
					local = iLGenerator.DeclareLocal(methodInfo_.ReturnType);
				}
				Type[] types = new Type[2]
				{
					typeof(IAsyncResult),
					typeof(Type)
				};
				MethodInfo method = typeof(XmlRpcClientProtocol).GetMethod("EndInvoke", types);
				Type[] types2 = new Type[1] { typeof(string) };
				MethodInfo method2 = typeof(Type).GetMethod("GetType", types2);
				iLGenerator.Emit(OpCodes.Ldarg_0);
				iLGenerator.Emit(OpCodes.Ldarg_1);
				iLGenerator.Emit(OpCodes.Ldstr, methodInfo_.ReturnType.AssemblyQualifiedName);
				iLGenerator.Emit(OpCodes.Call, method2);
				iLGenerator.Emit(OpCodes.Call, method);
				if ((object)typeof(void) != methodInfo_.ReturnType)
				{
					Label label = iLGenerator.DefineLabel();
					iLGenerator.Emit(OpCodes.Stloc, local2);
					iLGenerator.Emit(OpCodes.Ldloc, local2);
					iLGenerator.Emit(OpCodes.Brfalse, label);
					iLGenerator.Emit(OpCodes.Ldloc, local2);
					if (methodInfo_.ReturnType.IsValueType)
					{
						iLGenerator.Emit(OpCodes.Unbox, methodInfo_.ReturnType);
						iLGenerator.Emit(OpCodes.Ldobj, methodInfo_.ReturnType);
					}
					else
					{
						iLGenerator.Emit(OpCodes.Castclass, methodInfo_.ReturnType);
					}
					iLGenerator.Emit(OpCodes.Stloc, local);
					iLGenerator.MarkLabel(label);
					iLGenerator.Emit(OpCodes.Ldloc, local);
				}
				else
				{
					iLGenerator.Emit(OpCodes.Pop);
				}
				iLGenerator.Emit(OpCodes.Ret);
			}
		}

		private static void smethod_5(TypeBuilder A_0, Type A_1, string A_2)
		{
			ConstructorBuilder constructorBuilder = A_0.DefineConstructor(MethodAttributes.Public | MethodAttributes.HideBySig | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName, CallingConventions.Standard, Type.EmptyTypes);
			if (A_2 != null && A_2.Length > 0)
			{
				Type typeFromHandle = typeof(XmlRpcUrlAttribute);
				Type[] types = new Type[1] { typeof(string) };
				ConstructorInfo constructor = typeFromHandle.GetConstructor(types);
				CustomAttributeBuilder customAttribute = new CustomAttributeBuilder(constructor, new object[1] { A_2 });
				A_0.SetCustomAttribute(customAttribute);
			}
			ILGenerator iLGenerator = constructorBuilder.GetILGenerator();
			iLGenerator.Emit(OpCodes.Ldarg_0);
			ConstructorInfo constructor2 = A_1.GetConstructor(Type.EmptyTypes);
			iLGenerator.Emit(OpCodes.Call, constructor2);
			iLGenerator.Emit(OpCodes.Ret);
		}

		private static string smethod_6(Type A_0)
		{
			Attribute customAttribute = Attribute.GetCustomAttribute(A_0, typeof(XmlRpcUrlAttribute));
			if (customAttribute == null)
			{
				return null;
			}
			XmlRpcUrlAttribute xmlRpcUrlAttribute = customAttribute as XmlRpcUrlAttribute;
			return xmlRpcUrlAttribute.Uri;
		}

		private static MethodInfo[] smethod_7(Type A_0)
		{
			MethodInfo[] methods = A_0.GetMethods();
			if (!A_0.IsInterface)
			{
				return methods;
			}
			Type[] interfaces = A_0.GetInterfaces();
			if (interfaces.Length == 0)
			{
				return methods;
			}
			ArrayList arrayList = new ArrayList(methods);
			Type[] interfaces2 = A_0.GetInterfaces();
			foreach (Type type in interfaces2)
			{
				arrayList.AddRange(type.GetMethods());
			}
			return (MethodInfo[])arrayList.ToArray(typeof(MethodInfo));
		}

		private static ArrayList smethod_8(Type A_0)
		{
			ArrayList arrayList = new ArrayList();
			if (!A_0.IsInterface)
			{
				throw new Exception("type not interface");
			}
			MethodInfo[] array = smethod_7(A_0);
			foreach (MethodInfo methodInfo in array)
			{
				string text = smethod_9(methodInfo);
				if (text != null)
				{
					ParameterInfo[] parameters = methodInfo.GetParameters();
					bool a_ = parameters.Length > 0 && Attribute.IsDefined(parameters[parameters.Length - 1], typeof(ParamArrayAttribute));
					arrayList.Add(new Class65(methodInfo, text, a_));
				}
			}
			return arrayList;
		}

		private static string smethod_9(MethodInfo A_0)
		{
			Attribute customAttribute = Attribute.GetCustomAttribute(A_0, typeof(XmlRpcMethodAttribute));
			if (customAttribute == null)
			{
				return null;
			}
			XmlRpcMethodAttribute xmlRpcMethodAttribute = customAttribute as XmlRpcMethodAttribute;
			string text = xmlRpcMethodAttribute.Method;
			if (text == "")
			{
				text = A_0.Name;
			}
			return text;
		}

		private static ArrayList smethod_10(Type A_0)
		{
			ArrayList arrayList = new ArrayList();
			if (!A_0.IsInterface)
			{
				throw new Exception("type not interface");
			}
			MethodInfo[] methods = A_0.GetMethods();
			foreach (MethodInfo methodInfo in methods)
			{
				Attribute customAttribute = Attribute.GetCustomAttribute(methodInfo, typeof(XmlRpcBeginAttribute));
				if (customAttribute == null)
				{
					continue;
				}
				string text = ((XmlRpcBeginAttribute)customAttribute).Method;
				if (text == "")
				{
					if (!methodInfo.Name.StartsWith("Begin") || methodInfo.Name.Length <= 5)
					{
						throw new Exception($"method {methodInfo.Name} has invalid signature for begin method");
					}
					text = methodInfo.Name.Substring(5);
				}
				int num = methodInfo.GetParameters().Length;
				int j;
				for (j = 0; j < num; j++)
				{
					Type parameterType = methodInfo.GetParameters()[0].ParameterType;
					if ((object)parameterType == typeof(AsyncCallback))
					{
						break;
					}
				}
				if (num > 1)
				{
					if (j < num - 2)
					{
						throw new Exception($"method {methodInfo.Name} has invalid signature for begin method");
					}
					if (j == num - 2)
					{
						Type parameterType2 = methodInfo.GetParameters()[j + 1].ParameterType;
						if ((object)parameterType2 != typeof(object))
						{
							throw new Exception($"method {methodInfo.Name} has invalid signature for begin method");
						}
					}
				}
				arrayList.Add(new Class65(methodInfo, text, A_2: false, null));
			}
			return arrayList;
		}

		private static ArrayList smethod_11(Type A_0)
		{
			ArrayList arrayList = new ArrayList();
			if (!A_0.IsInterface)
			{
				throw new Exception("type not interface");
			}
			MethodInfo[] methods = A_0.GetMethods();
			foreach (MethodInfo methodInfo in methods)
			{
				Attribute customAttribute = Attribute.GetCustomAttribute(methodInfo, typeof(XmlRpcEndAttribute));
				if (customAttribute != null)
				{
					ParameterInfo[] parameters = methodInfo.GetParameters();
					if (parameters.Length != 1)
					{
						throw new Exception($"method {methodInfo.Name} has invalid signature for end method");
					}
					Type parameterType = parameters[0].ParameterType;
					if ((object)parameterType != typeof(IAsyncResult))
					{
						throw new Exception($"method {methodInfo.Name} has invalid signature for end method");
					}
					arrayList.Add(new Class65(methodInfo, "", A_2: false));
				}
			}
			return arrayList;
		}
	}
}
