using System;

namespace Google.GData.Client
{
	public class BaseMarkDirty : IBaseWalkerAction
	{
		private bool bool_0;

		internal BaseMarkDirty(bool A_0)
		{
			bool_0 = A_0;
		}

		public bool Go(AtomBase atom)
		{
			if (atom == null)
			{
				throw new ArgumentNullException("atom");
			}
			atom.Dirty = bool_0;
			return false;
		}
	}
}
