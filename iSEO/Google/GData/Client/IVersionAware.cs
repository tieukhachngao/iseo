namespace Google.GData.Client
{
	public interface IVersionAware
	{
		int ProtocolMajor { get; set; }

		int ProtocolMinor { get; set; }
	}
}
