using System;
using System.IO;

namespace Google.GData.Client
{
	public interface IService
	{
		GDataCredentials Credentials { get; set; }

		IGDataRequestFactory RequestFactory { get; set; }

		string ServiceIdentifier { get; }

		Stream QueryOpenSearchRssDescription(Uri serviceUri);

		AtomFeed Query(FeedQuery feedQuery);

		AtomFeed Query(FeedQuery feedQuery, DateTime ifModifiedSince);

		AtomEntry Update(AtomEntry entry);

		AtomEntry Insert(AtomFeed feed, AtomEntry entry);

		void Delete(AtomEntry entry);

		void Delete(Uri uriTarget);

		AtomFeed Batch(AtomFeed feed, Uri batchUri);

		AtomEntry Update(Uri uriTarget, Stream input, string contentType, string slugHeader);

		AtomEntry Insert(Uri uriTarget, Stream input, string contentType, string slugHeader);
	}
}
