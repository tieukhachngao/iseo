using System;

namespace Google.GData.Client
{
	public class AtomEntryCollection : AtomCollectionBase<AtomEntry>
	{
		private AtomFeed atomFeed_0;

		public override AtomEntry this[int index]
		{
			get
			{
				return List[index];
			}
			set
			{
				if (value != null && (value.Feed == null || value.Feed != atomFeed_0))
				{
					value.method_3(atomFeed_0);
				}
				List[index] = value;
			}
		}

		private AtomEntryCollection()
		{
		}

		public AtomEntryCollection(AtomFeed feed)
		{
			atomFeed_0 = feed;
		}

		public AtomEntry FindById(AtomId value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			foreach (AtomEntry item in List)
			{
				if (item.Id.AbsoluteUri == value.AbsoluteUri)
				{
					return item;
				}
			}
			return null;
		}

		public override void Add(AtomEntry value)
		{
			if (value != null)
			{
				if (atomFeed_0 != null && value.Feed == atomFeed_0)
				{
					throw new ArgumentException("The entry is already part of this collection");
				}
				value.method_3(atomFeed_0);
				value.ProtocolMajor = atomFeed_0.ProtocolMajor;
				value.ProtocolMinor = atomFeed_0.ProtocolMinor;
			}
			base.Add(value);
		}

		public AtomEntry CopyOrMove(AtomEntry value)
		{
			if (value != null)
			{
				if (value.Feed == null)
				{
					value.method_3(atomFeed_0);
				}
				else
				{
					if (atomFeed_0 != null && value.Feed == atomFeed_0)
					{
						throw new ArgumentException("The entry is already part of this collection");
					}
					if (!AtomFeed.IsFeedIdentical(value.Feed, atomFeed_0))
					{
						AtomEntry atomEntry = AtomEntry.ImportFromFeed(value);
						atomEntry.method_3(atomFeed_0);
						value = atomEntry;
					}
				}
				value.ProtocolMajor = atomFeed_0.ProtocolMajor;
				value.ProtocolMinor = atomFeed_0.ProtocolMinor;
			}
			base.Add(value);
			return value;
		}
	}
}
