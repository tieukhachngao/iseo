using System.ComponentModel;

namespace Google.GData.Client
{
	[Description("Expand to see the link attributes for the Icon.")]
	[TypeConverter(typeof(AtomBaseLinkConverter))]
	public class AtomIcon : AtomBaseLink
	{
		public override string XmlName => "icon";
	}
}
