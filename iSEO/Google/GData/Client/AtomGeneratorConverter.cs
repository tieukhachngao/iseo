using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Google.GData.Client
{
	[ComVisible(false)]
	public class AtomGeneratorConverter : ExpandableObjectConverter
	{
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			if ((object)destinationType == typeof(AtomGenerator))
			{
				return true;
			}
			return base.CanConvertTo(context, destinationType);
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			AtomGenerator atomGenerator = value as AtomGenerator;
			if ((object)destinationType == typeof(string) && atomGenerator != null)
			{
				return atomGenerator.Text;
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}
	}
}
