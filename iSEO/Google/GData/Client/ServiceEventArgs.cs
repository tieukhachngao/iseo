using System;

namespace Google.GData.Client
{
	public class ServiceEventArgs : EventArgs
	{
		private AtomFeed atomFeed_0;

		private IService iservice_0;

		private Uri uri_0;

		public AtomFeed Feed
		{
			get
			{
				return atomFeed_0;
			}
			set
			{
				atomFeed_0 = value;
			}
		}

		public IService Service => iservice_0;

		public Uri Uri => uri_0;

		public ServiceEventArgs(Uri uri, IService service)
		{
			iservice_0 = service;
			uri_0 = uri;
		}
	}
}
