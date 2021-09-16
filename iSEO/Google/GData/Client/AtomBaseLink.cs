using System.Xml;

namespace Google.GData.Client
{
	public abstract class AtomBaseLink : AtomBase
	{
		private AtomUri atomUri_2;

		public AtomUri Uri
		{
			get
			{
				return atomUri_2;
			}
			set
			{
				base.Dirty = true;
				atomUri_2 = value;
			}
		}

		public string AbsoluteUri
		{
			get
			{
				if (Uri == null)
				{
					return null;
				}
				return GetAbsoluteUri(Uri.ToString());
			}
		}

		protected override void SaveInnerXml(XmlWriter writer)
		{
			base.SaveInnerXml(writer);
			AtomBase.WriteEncodedString(writer, Uri);
		}

		public override bool ShouldBePersisted()
		{
			if (!base.ShouldBePersisted())
			{
				return Utilities.IsPersistable(atomUri_2);
			}
			return true;
		}
	}
}
