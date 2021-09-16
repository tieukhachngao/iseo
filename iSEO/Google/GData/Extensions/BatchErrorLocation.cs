using System;

namespace Google.GData.Extensions
{
	public class BatchErrorLocation : SimpleElement
	{
		public string Type
		{
			get
			{
				return Convert.ToString(base.Attributes["type"]);
			}
			set
			{
				base.Attributes["type"] = value;
			}
		}

		public BatchErrorLocation()
			: base("location", "gd", "http://schemas.google.com/g/2005")
		{
		}
	}
}
