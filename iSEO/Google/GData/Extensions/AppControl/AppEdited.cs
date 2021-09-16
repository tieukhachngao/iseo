using System;
using System.Globalization;
using Google.GData.Client;

namespace Google.GData.Extensions.AppControl
{
	public class AppEdited : SimpleElement
	{
		public DateTime DateValue
		{
			get
			{
				return DateTime.Parse(Value, CultureInfo.InvariantCulture);
			}
			set
			{
				Value = Utilities.LocalDateTimeInUTC(value);
			}
		}

		public AppEdited()
			: base("edited", "app", "http://www.w3.org/2007/app")
		{
		}

		public AppEdited(DateTime dateValue)
			: base("edited", "app", "http://www.w3.org/2007/app")
		{
			Value = Utilities.LocalDateTimeInUTC(dateValue);
		}

		public AppEdited(string dateInUtc)
			: base("edited", "app", "http://www.w3.org/2007/app", dateInUtc)
		{
		}
	}
}
