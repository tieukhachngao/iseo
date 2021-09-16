using System.Collections;
using System.Collections.Generic;

namespace Google.GData.Client
{
	public class AtomCollectionBase<T> : IList<T>
	{
		protected List<T> List = new List<T>();

		public virtual T this[int index]
		{
			get
			{
				return List[index];
			}
			set
			{
				List[index] = value;
			}
		}

		public virtual int Count => List.Count;

		public virtual bool IsReadOnly => false;

		public virtual void Add(T value)
		{
			List.Add(value);
		}

		public virtual void RemoveAt(int index)
		{
			List.RemoveAt(index);
		}

		public virtual void Clear()
		{
			List.Clear();
		}

		public virtual void CopyTo(T[] arr, int index)
		{
			List.CopyTo(arr, index);
		}

		public virtual int IndexOf(T value)
		{
			return List.IndexOf(value);
		}

		public virtual void Insert(int index, T value)
		{
			List.Insert(index, value);
		}

		public virtual bool Remove(T value)
		{
			return List.Remove(value);
		}

		public virtual bool Contains(T value)
		{
			return List.Contains(value);
		}

		public IEnumerator<T> GetEnumerator()
		{
			return List.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return List.GetEnumerator();
		}
	}
}
