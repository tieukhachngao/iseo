namespace Google.GData.Client
{
	public class NullVersionAware : IVersionAware
	{
		private static object object_0 = new object();

		private static IVersionAware iversionAware_0;

		public static IVersionAware Instance
		{
			get
			{
				if (iversionAware_0 == null)
				{
					lock (object_0)
					{
						if (iversionAware_0 == null)
						{
							iversionAware_0 = new NullVersionAware();
						}
					}
				}
				return iversionAware_0;
			}
		}

		public int ProtocolMajor
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int ProtocolMinor
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}
	}
}
