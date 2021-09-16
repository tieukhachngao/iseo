using System;

namespace Google.GData.Client
{
	public class FeedParserEventArgs : EventArgs
	{
		private bool bool_0;

		private bool bool_1;

		private AtomEntry atomEntry_0;

		private AtomFeed atomFeed_0;

		private bool bool_2;

		public bool DiscardEntry
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

		public bool DoneParsing => bool_2;

		public bool CreatingEntry => bool_1;

		public AtomEntry Entry
		{
			get
			{
				return atomEntry_0;
			}
			set
			{
				atomEntry_0 = value;
			}
		}

		public AtomFeed Feed => atomFeed_0;

		public FeedParserEventArgs()
		{
			bool_1 = true;
		}

		public FeedParserEventArgs(AtomFeed feed, AtomEntry entry)
		{
			atomEntry_0 = entry;
			atomFeed_0 = feed;
			if (feed == null && entry == null)
			{
				bool_2 = true;
			}
		}
	}
}
