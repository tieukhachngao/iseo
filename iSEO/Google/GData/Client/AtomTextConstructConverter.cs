using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Google.GData.Client
{
	[ComVisible(false)]
	public class AtomTextConstructConverter : ExpandableObjectConverter
	{
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			if ((object)destinationType == typeof(AtomTextConstruct))
			{
				return true;
			}
			return base.CanConvertTo(context, destinationType);
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			AtomTextConstruct atomTextConstruct = value as AtomTextConstruct;
			if ((object)destinationType == typeof(string) && atomTextConstruct != null)
			{
				return string.Concat(atomTextConstruct.Type, ": ", atomTextConstruct.Text);
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}
	}
}
