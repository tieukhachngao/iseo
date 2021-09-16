using System.Threading;

namespace Google.GData.Client
{
	public class AsyncDeleteData : AsyncData, IAsyncEntryData
	{
		private AtomEntry atomEntry_0;

		private readonly bool bool_1;

		public bool PermanentDelete => bool_1;

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

		public AsyncDeleteData(AtomEntry entry, bool permanentDelete, object userData, SendOrPostCallback callback)
			: base(null, userData, callback)
		{
			atomEntry_0 = entry;
			bool_1 = permanentDelete;
		}
	}
}
