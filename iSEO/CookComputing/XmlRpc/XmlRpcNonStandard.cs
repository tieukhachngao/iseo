using System;

namespace CookComputing.XmlRpc
{
	[Flags]
	public enum XmlRpcNonStandard
	{
		None = 0x0,
		AllowStringFaultCode = 0x1,
		AllowNonStandardDateTime = 0x2,
		IgnoreDuplicateMembers = 0x4,
		MapZerosDateTimeToMinValue = 0x8,
		MapEmptyDateTimeToMinValue = 0x10,
		AllowInvalidHTTPContent = 0x20,
		All = 0x7FFF
	}
}
