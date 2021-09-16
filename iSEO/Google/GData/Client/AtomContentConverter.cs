using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Google.GData.Client
{
	[ComVisible(false)]
	public class AtomContentConverter : ExpandableObjectConverter
	{
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			if ((object)destinationType == typeof(AtomContent))
			{
				return true;
			}
			return base.CanConvertTo(context, destinationType);
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			AtomContent atomContent = value as AtomContent;
			if ((object)destinationType == typeof(string) && atomContent != null)
			{
				return "Content-type: " + atomContent.Type;
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}
	}
}
