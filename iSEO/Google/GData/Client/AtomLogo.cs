using System.ComponentModel;

namespace Google.GData.Client
{
	[Description("Expand to see the link attributes for the Logo.")]
	[TypeConverter(typeof(AtomBaseLinkConverter))]
	public class AtomLogo : AtomBaseLink
	{
		public override string XmlName => "logo";
	}
}
