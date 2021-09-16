using System;
using System.Net;

namespace Google.GData.Client
{
	public interface ICreateHttpRequest
	{
		HttpWebRequest Create(Uri target);
	}
}
