namespace Google.GData.Extensions
{
	public abstract class SimpleAttribute : SimpleElement
	{
		public override string Value
		{
			get
			{
				return base.Attributes["value"] as string;
			}
			set
			{
				base.Attributes["value"] = value;
			}
		}

		protected SimpleAttribute(string name, string prefix, string ns)
			: base(name, prefix, ns)
		{
			base.Attributes.Add("value", null);
		}

		protected SimpleAttribute(string name, string prefix, string ns, string value)
			: base(name, prefix, ns)
		{
			base.Attributes.Add("value", value);
		}
	}
}
