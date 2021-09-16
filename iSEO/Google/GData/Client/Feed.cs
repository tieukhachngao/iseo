using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Google.GData.Client
{
	public class Feed<T> where T : new()
	{
		[CompilerGenerated]
		private sealed class Class1 : IEnumerable<T>, IEnumerator<T>
		{
			private T gparam_0;

			private int int_0;

			private int int_1;

			public Feed<T> feed_0;

			public bool bool_0;

			public AtomFeed atomFeed_0;

			public AtomEntry atomEntry_0;

			public T gparam_1;

			public IEnumerator<AtomEntry> ienumerator_0;

			T IEnumerator<T>.Current
			{
				[DebuggerHidden]
				get
				{
					return gparam_0;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return gparam_0;
				}
			}

			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				Class1 result;
				if (Thread.CurrentThread.ManagedThreadId == int_1 && int_0 == -2)
				{
					int_0 = 0;
					result = this;
				}
				else
				{
					result = new Class1(0)
					{
						feed_0 = feed_0
					};
				}
				return result;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return ((IEnumerable<T>)this).GetEnumerator();
			}

			bool IEnumerator.MoveNext()
			{
				try
				{
					switch (int_0)
					{
					case 0:
						int_0 = -1;
						if (feed_0.AtomFeed != null)
						{
							atomFeed_0 = feed_0.AtomFeed;
							feed_0.int_1 = 0;
							goto IL_00c1;
						}
						goto default;
					case 2:
						int_0 = 1;
						goto IL_015e;
					default:
						{
							return false;
						}
						IL_0109:
						if (!ienumerator_0.MoveNext())
						{
							method_0();
							if (bool_0)
							{
								FeedQuery feedQuery = new FeedQuery(feed_0.AtomFeed.NextChunk);
								FeedQuery.smethod_0(feedQuery, feed_0.requestSettings_0);
								feed_0.atomFeed_0 = feed_0.AtomFeed.Service.Query(feedQuery);
							}
							if (bool_0)
							{
								goto IL_00c1;
							}
							feed_0.atomFeed_0 = atomFeed_0;
							goto default;
						}
						atomEntry_0 = ienumerator_0.Current;
						gparam_1 = new T();
						if (gparam_1 != null)
						{
							((Entry)gparam_1).AtomEntry = atomEntry_0;
							feed_0.int_1++;
							gparam_0 = gparam_1;
							int_0 = 2;
							return true;
						}
						goto IL_015e;
						IL_00c1:
						bool_0 = feed_0.atomFeed_0.NextChunk != null && feed_0.bool_0;
						ienumerator_0 = feed_0.atomFeed_0.Entries.GetEnumerator();
						int_0 = 1;
						goto IL_0109;
						IL_015e:
						if (feed_0.Maximum <= 0 || feed_0.int_1 < feed_0.Maximum)
						{
							goto IL_0109;
						}
						((IDisposable)this).Dispose();
						goto default;
					}
				}
				catch
				{
					//try-fault
					((IDisposable)this).Dispose();
					throw;
				}
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new NotSupportedException();
			}

			void IDisposable.Dispose()
			{
				switch (int_0)
				{
				case 1:
				case 2:
					try
					{
					}
					finally
					{
						method_0();
					}
					break;
				}
			}

			[DebuggerHidden]
			public Class1(int A_0)
			{
				int_0 = A_0;
				int_1 = Thread.CurrentThread.ManagedThreadId;
			}

			private void method_0()
			{
				int_0 = -1;
				if (ienumerator_0 != null)
				{
					ienumerator_0.Dispose();
				}
			}
		}

		private AtomFeed atomFeed_0;

		private bool bool_0;

		private int int_0 = -1;

		private int int_1;

		private Service service_0;

		private FeedQuery feedQuery_0;

		private RequestSettings requestSettings_0;

		public AtomFeed AtomFeed
		{
			get
			{
				if (atomFeed_0 == null && service_0 != null && feedQuery_0 != null)
				{
					atomFeed_0 = service_0.Query(feedQuery_0);
				}
				return atomFeed_0;
			}
		}

		public bool AutoPaging
		{
			get
			{
				return bool_0;
			}
			set
			{
				bool_0 = value;
			}
		}

		public int StartIndex
		{
			get
			{
				if (AtomFeed != null)
				{
					return AtomFeed.StartIndex;
				}
				return -1;
			}
		}

		public int PageSize
		{
			get
			{
				if (AtomFeed != null)
				{
					return AtomFeed.ItemsPerPage;
				}
				return -1;
			}
		}

		public int TotalResults
		{
			get
			{
				if (AtomFeed != null)
				{
					return AtomFeed.TotalResults;
				}
				return -1;
			}
		}

		public int Maximum
		{
			get
			{
				return int_0;
			}
			set
			{
				int_0 = value;
			}
		}

		internal RequestSettings Settings
		{
			get
			{
				return requestSettings_0;
			}
			set
			{
				requestSettings_0 = value;
			}
		}

		public IEnumerable<T> Entries
		{
			get
			{
				Class1 @class = new Class1(-2);
				@class.feed_0 = this;
				return @class;
			}
		}

		public Feed(AtomFeed af)
		{
			atomFeed_0 = af;
		}

		public Feed(Service service, FeedQuery q)
		{
			service_0 = service;
			feedQuery_0 = q;
		}
	}
}
