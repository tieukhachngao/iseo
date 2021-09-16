namespace Google.GData.Extensions
{
	public abstract class SimpleNameValueAttribute : SimpleAttribute
	{
		public string Name
		{
			get
			{
				return base.Attributes["name"] as string;
			}
			set
			{
				base.Attributes["name"] = value;
			}
		}

		protected SimpleNameValueAttribute(string localName, string prefix, string ns)
			: base(localName, prefix, ns)
		{
			base.Attributes.Add("name", null);
		}
	}
}
