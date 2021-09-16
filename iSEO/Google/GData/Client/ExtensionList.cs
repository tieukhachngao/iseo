using System.Collections;
using System.Collections.Generic;

namespace Google.GData.Client
{
	public class ExtensionList : IList<IExtensionElementFactory>
	{
		private IVersionAware iversionAware_0;

		private List<IExtensionElementFactory> list_0 = new List<IExtensionElementFactory>();

		public IExtensionElementFactory this[int index]
		{
			get
			{
				return list_0[index];
			}
			set
			{
				list_0[index] = value;
			}
		}

		public int Count => list_0.Count;

		public bool IsReadOnly => false;

		public static ExtensionList NotVersionAware()
		{
			return new ExtensionList(NullVersionAware.Instance);
		}

		public ExtensionList(IVersionAware container)
		{
			iversionAware_0 = container;
		}

		public int Add(IExtensionElementFactory value)
		{
			IVersionAware versionAware = value as IVersionAware;
			if (versionAware != null)
			{
				versionAware.ProtocolMajor = iversionAware_0.ProtocolMajor;
				versionAware.ProtocolMinor = iversionAware_0.ProtocolMinor;
			}
			if (value != null)
			{
				list_0.Add(value);
			}
			return list_0.Count - 1;
		}

		public int IndexOf(IExtensionElementFactory item)
		{
			return list_0.IndexOf(item);
		}

		public void Insert(int index, IExtensionElementFactory item)
		{
			list_0.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list_0.RemoveAt(index);
		}

		void ICollection<IExtensionElementFactory>.Add(IExtensionElementFactory item)
		{
			Add(item);
		}

		public void Clear()
		{
			list_0.Clear();
		}

		public bool Contains(IExtensionElementFactory item)
		{
			return list_0.Contains(item);
		}

		public void CopyTo(IExtensionElementFactory[] array, int arrayIndex)
		{
			list_0.CopyTo(array, arrayIndex);
		}

		public bool Remove(IExtensionElementFactory item)
		{
			return list_0.Remove(item);
		}

		public bool Remove(string ns, string name)
		{
			int num = 0;
			while (true)
			{
				if (num < list_0.Count)
				{
					if (list_0[num].XmlNameSpace == ns && list_0[num].XmlName == name)
					{
						break;
					}
					num++;
					continue;
				}
				return false;
			}
			list_0.RemoveAt(num);
			return true;
		}

		public IEnumerator<IExtensionElementFactory> GetEnumerator()
		{
			return list_0.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return list_0.GetEnumerator();
		}
	}
}
