using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Google.GData.Client
{
	[ComVisible(false)]
	public class AtomSourceConverter : ExpandableObjectConverter
	{
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			if ((object)destinationType != typeof(AtomSource) && (object)destinationType != typeof(AtomFeed))
			{
				return base.CanConvertTo(context, destinationType);
			}
			return true;
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			AtomSource atomSource = value as AtomSource;
			if ((object)destinationType == typeof(string) && atomSource != null)
			{
				return "Feed: " + atomSource.Title;
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}
	}
}
