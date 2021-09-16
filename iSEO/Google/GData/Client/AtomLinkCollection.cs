using System.Collections.Generic;

namespace Google.GData.Client
{
	public class AtomLinkCollection : AtomCollectionBase<AtomLink>
	{
		public AtomLink FindService(string service, string type)
		{
			foreach (AtomLink item in List)
			{
				string rel = item.Rel;
				string type2 = item.Type;
				if ((service == null || (rel != null && rel == service)) && (type == null || (type2 != null && type2.StartsWith(type))))
				{
					return item;
				}
			}
			return null;
		}

		public List<AtomLink> FindServiceList(string service, string type)
		{
			List<AtomLink> list = new List<AtomLink>();
			foreach (AtomLink item in List)
			{
				string rel = item.Rel;
				string type2 = item.Type;
				if ((service == null || (rel != null && rel == service)) && (type == null || (type2 != null && type2 == type)))
				{
					list.Add(item);
				}
			}
			return list;
		}
	}
}
