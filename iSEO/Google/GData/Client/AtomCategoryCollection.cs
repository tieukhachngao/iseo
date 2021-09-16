using System;

namespace Google.GData.Client
{
	public class AtomCategoryCollection : AtomCollectionBase<AtomCategory>
	{
		public override void Add(AtomCategory value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			AtomCategory atomCategory = Find(value.Term, value.Scheme);
			if (atomCategory != null)
			{
				Remove(atomCategory);
			}
			base.Add(value);
		}

		public AtomCategory Find(string term)
		{
			return Find(term, null);
		}

		public AtomCategory Find(string term, AtomUri scheme)
		{
			foreach (AtomCategory item in List)
			{
				if ((scheme == null || scheme == item.Scheme) && term == item.Term)
				{
					return item;
				}
			}
			return null;
		}

		public override bool Contains(AtomCategory value)
		{
			if (value == null)
			{
				return List.Contains(value);
			}
			if (Find(value.Term, value.Scheme) != null)
			{
				return true;
			}
			return false;
		}
	}
}
