using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Google.GData.Client
{
	[ComVisible(false)]
	public class AtomEntryConverter : ExpandableObjectConverter
	{
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			if ((object)destinationType == typeof(AtomEntry))
			{
				return true;
			}
			return base.CanConvertTo(context, destinationType);
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			AtomEntry atomEntry = value as AtomEntry;
			if ((object)destinationType == typeof(string) && atomEntry != null)
			{
				return "Entry: " + atomEntry.Title;
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}
	}
}
