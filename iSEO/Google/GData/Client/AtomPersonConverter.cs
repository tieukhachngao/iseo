using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Google.GData.Client
{
	[ComVisible(false)]
	public class AtomPersonConverter : ExpandableObjectConverter
	{
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			if ((object)destinationType == typeof(AtomPerson))
			{
				return true;
			}
			return base.CanConvertTo(context, destinationType);
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			AtomPerson atomPerson = value as AtomPerson;
			if ((object)destinationType == typeof(string) && atomPerson != null)
			{
				return "Person: " + atomPerson.Name;
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}
	}
}
