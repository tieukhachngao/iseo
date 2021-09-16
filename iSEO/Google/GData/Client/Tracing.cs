using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace Google.GData.Client
{
	public sealed class Tracing
	{
		private Tracing()
		{
		}

		[Conditional("TRACE")]
		public static void InitTracing()
		{
		}

		[Conditional("TRACE")]
		public static void ExitTracing()
		{
		}

		[Conditional("TRACE")]
		private static void smethod_0(string A_0, StackFrame A_1, int A_2)
		{
			try
			{
				if (A_1 != null)
				{
					StringBuilder stringBuilder = new StringBuilder();
					MethodBase method = A_1.GetMethod();
					while (A_2-- > 0)
					{
						stringBuilder.Append("    ");
					}
					stringBuilder.Append("--> " + method.DeclaringType.Name + "." + method.Name + "()");
					if (!string.IsNullOrEmpty(A_0))
					{
						stringBuilder.Append(": " + A_0);
					}
				}
			}
			catch
			{
			}
		}

		[Conditional("TRACE")]
		public static void TraceCall(string msg)
		{
			StackTrace stackTrace = new StackTrace();
			if (stackTrace != null && stackTrace.FrameCount > 1)
			{
				stackTrace.GetFrame(1);
			}
		}

		[Conditional("TRACE")]
		public static void TraceCall()
		{
			StackTrace stackTrace = new StackTrace();
			if (stackTrace != null && stackTrace.FrameCount > 1)
			{
				stackTrace.GetFrame(1);
			}
		}

		[Conditional("TRACE")]
		public static void TraceInfo(string msg)
		{
		}

		[Conditional("TRACE")]
		public static void TraceMsg(string msg)
		{
		}

		[Conditional("TRACE")]
		public static void Assert(bool condition, string msg)
		{
		}
	}
}
