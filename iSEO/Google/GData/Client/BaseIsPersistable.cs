using System;

namespace Google.GData.Client
{
	public class BaseIsPersistable : IBaseWalkerAction
	{
		public bool Go(AtomBase atom)
		{
			if (atom == null)
			{
				throw new ArgumentNullException("atom");
			}
			return atom.ShouldBePersisted();
		}
	}
}
