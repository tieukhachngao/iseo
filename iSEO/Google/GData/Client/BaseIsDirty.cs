using System;

namespace Google.GData.Client
{
	public class BaseIsDirty : IBaseWalkerAction
	{
		public bool Go(AtomBase atom)
		{
			if (atom == null)
			{
				throw new ArgumentNullException("atom");
			}
			return atom.Dirty;
		}
	}
}
