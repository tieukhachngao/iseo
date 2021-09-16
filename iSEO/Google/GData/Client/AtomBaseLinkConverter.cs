using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Google.GData.Client
{
	[ComVisible(false)]
	public class AtomBaseLinkConverter : ExpandableObjectConverter
	{
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			if ((object)destinationType != typeof(AtomBaseLink) && (object)destinationType != typeof(AtomId) && (object)destinationType != typeof(AtomIcon) && (object)destinationType != typeof(AtomLogo))
			{
				return base.CanConvertTo(context, destinationType);
			}
			return true;
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			AtomBaseLink atomBaseLink = value as AtomBaseLink;
			if ((object)destinationType == typeof(string) && atomBaseLink != null)
			{
				return "Uri: " + atomBaseLink.Uri;
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}
	}
}
