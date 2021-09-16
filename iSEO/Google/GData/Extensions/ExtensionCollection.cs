using System;
using System.Collections;
using System.Collections.Generic;
using Google.GData.Client;

namespace Google.GData.Extensions
{
	public class ExtensionCollection<T> : IList<T> where T : class, new()
	{
		private IExtensionContainer iextensionContainer_0;

		private List<T> list_0 = new List<T>();

		private static Dictionary<Type, IExtensionElementFactory> dictionary_0 = new Dictionary<Type, IExtensionElementFactory>();

		public T this[int index]
		{
			get
			{
				return list_0[index];
			}
			set
			{
				setItem(index, value);
			}
		}

		public int Count => list_0.Count;

		public bool IsReadOnly => false;

		private static string smethod_0()
		{
			Type typeFromHandle = typeof(T);
			IExtensionElementFactory value;
			lock (dictionary_0)
			{
				if (!dictionary_0.TryGetValue(typeFromHandle, out value))
				{
					value = (IExtensionElementFactory)new T();
					dictionary_0[typeFromHandle] = value;
				}
			}
			return value.XmlName;
		}

		private static string smethod_1()
		{
			Type typeFromHandle = typeof(T);
			IExtensionElementFactory value;
			lock (dictionary_0)
			{
				if (!dictionary_0.TryGetValue(typeFromHandle, out value))
				{
					value = (IExtensionElementFactory)new T();
					dictionary_0[typeFromHandle] = value;
				}
			}
			return value.XmlNameSpace;
		}

		public ExtensionCollection()
		{
		}

		public ExtensionCollection(IExtensionContainer containerElement)
			: this(containerElement, smethod_0(), smethod_1())
		{
		}

		public ExtensionCollection(IExtensionContainer containerElement, string localName, string ns)
		{
			iextensionContainer_0 = containerElement;
			if (iextensionContainer_0 == null)
			{
				return;
			}
			ExtensionList extensionList = iextensionContainer_0.FindExtensions(localName, ns);
			foreach (T item in extensionList)
			{
				list_0.Add(item);
			}
		}

		protected void setItem(int index, T item)
		{
			if (list_0[index] != null && iextensionContainer_0 != null)
			{
				iextensionContainer_0.ExtensionElements.Remove((IExtensionElementFactory)list_0[index]);
			}
			list_0[index] = item;
			if (item != null && iextensionContainer_0 != null)
			{
				iextensionContainer_0.ExtensionElements.Add((IExtensionElementFactory)item);
			}
		}

		public int Add(T value)
		{
			if (iextensionContainer_0 != null)
			{
				iextensionContainer_0.ExtensionElements.Add((IExtensionElementFactory)value);
			}
			list_0.Add(value);
			return list_0.Count - 1;
		}

		public void Insert(int index, T value)
		{
			if (iextensionContainer_0 != null && iextensionContainer_0.ExtensionElements.Contains((IExtensionElementFactory)value))
			{
				iextensionContainer_0.ExtensionElements.Remove((IExtensionElementFactory)value);
			}
			iextensionContainer_0.ExtensionElements.Add((IExtensionElementFactory)value);
			list_0.Insert(index, value);
		}

		public bool Remove(T value)
		{
			bool flag;
			if ((flag = list_0.Remove(value)) && iextensionContainer_0 != null)
			{
				flag &= iextensionContainer_0.ExtensionElements.Remove((IExtensionElementFactory)value);
			}
			return flag;
		}

		public int IndexOf(T value)
		{
			return list_0.IndexOf(value);
		}

		public bool Contains(T value)
		{
			return list_0.Contains(value);
		}

		protected void OnClear()
		{
			if (iextensionContainer_0 != null)
			{
				for (int i = 0; i < Count; i++)
				{
					iextensionContainer_0.ExtensionElements.Remove((IExtensionElementFactory)list_0[i]);
				}
			}
		}

		public void RemoveAt(int index)
		{
			T value = list_0[index];
			Remove(value);
		}

		void ICollection<T>.Add(T item)
		{
			Add(item);
		}

		public void Clear()
		{
			OnClear();
			list_0.Clear();
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
			list_0.ToArray().CopyTo(array, arrayIndex);
		}

		bool ICollection<T>.Remove(T item)
		{
			return Remove(item);
		}

		public IEnumerator<T> GetEnumerator()
		{
			return list_0.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return list_0.GetEnumerator();
		}
	}
}
