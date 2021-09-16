using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Google.GData.Client
{
	public abstract class FeedRequest<T>
	{
		private RequestSettings requestSettings_0;

		private T gparam_0;

		public IWebProxy Proxy
		{
			get
			{
				return (((Service)gparam_0).RequestFactory as GDataRequestFactory)?.Proxy;
			}
			set
			{
				GDataRequestFactory gDataRequestFactory = ((Service)gparam_0).RequestFactory as GDataRequestFactory;
				if (gDataRequestFactory == null)
				{
					throw new ArgumentException("Can not set a proxy on this service");
				}
				gDataRequestFactory.Proxy = value;
				OnSetOtherProxies(value);
			}
		}

		protected Service AtomService => (Service)(object)gparam_0;

		public T Service
		{
			get
			{
				return gparam_0;
			}
			set
			{
				gparam_0 = value;
			}
		}

		public RequestSettings Settings => requestSettings_0;

		public FeedRequest(RequestSettings settings)
		{
			requestSettings_0 = settings;
		}

		protected void PrepareService()
		{
			PrepareService((Service)(object)gparam_0);
		}

		protected void PrepareService(Service s)
		{
			ServicePointManager.Expect100Continue = false;
			if (requestSettings_0.Credentials != null)
			{
				s.Credentials = requestSettings_0.Credentials;
			}
			if (requestSettings_0.AuthSubToken != null)
			{
				GAuthSubRequestFactory gAuthSubRequestFactory = new GAuthSubRequestFactory(s.ServiceIdentifier, requestSettings_0.Application);
				gAuthSubRequestFactory.UserAgent += "--IEnumerable";
				gAuthSubRequestFactory.Token = requestSettings_0.AuthSubToken;
				gAuthSubRequestFactory.PrivateKey = requestSettings_0.PrivateKey;
				s.RequestFactory = gAuthSubRequestFactory;
			}
			else if (requestSettings_0.ConsumerKey != null)
			{
				GOAuthRequestFactory gOAuthRequestFactory = new GOAuthRequestFactory(s.ServiceIdentifier, requestSettings_0.Application);
				gOAuthRequestFactory.ConsumerKey = requestSettings_0.ConsumerKey;
				gOAuthRequestFactory.ConsumerSecret = requestSettings_0.ConsumerSecret;
				gOAuthRequestFactory.Token = requestSettings_0.Token;
				gOAuthRequestFactory.TokenSecret = requestSettings_0.TokenSecret;
				s.RequestFactory = gOAuthRequestFactory;
			}
			else if (requestSettings_0.OAuth2Parameters != null)
			{
				s.RequestFactory = new GOAuth2RequestFactory(s.ServiceIdentifier, requestSettings_0.Application, requestSettings_0.OAuth2Parameters);
			}
			else
			{
				GDataGAuthRequestFactory gDataGAuthRequestFactory = s.RequestFactory as GDataGAuthRequestFactory;
				if (gDataGAuthRequestFactory != null)
				{
					gDataGAuthRequestFactory.UserAgent += "--IEnumerable";
				}
			}
			if (requestSettings_0.Timeout != -1)
			{
				GDataRequestFactory gDataRequestFactory = s.RequestFactory as GDataRequestFactory;
				if (gDataRequestFactory != null)
				{
					gDataRequestFactory.Timeout = requestSettings_0.Timeout;
				}
			}
			s.RequestFactory.UseSSL = requestSettings_0.UseSSL;
		}

		protected Y PrepareQuery<Y>(string uri) where Y : new()
		{
			Y val = new Y
			{
				BaseAddress = uri
			};
			PrepareQuery((FeedQuery)(object)val);
			return val;
		}

		protected void PrepareQuery(FeedQuery q)
		{
			FeedQuery.smethod_0(q, requestSettings_0);
		}

		protected Uri CreateUri(string location)
		{
			Uri uri = null;
			if (requestSettings_0.OAuthUser != null && location.IndexOf(OAuthUri.OAuthParameter) != 0)
			{
				return new OAuthUri(location, requestSettings_0.OAuthUser, requestSettings_0.OAuthDomain);
			}
			return new Uri(location);
		}

		protected virtual Feed<Y> PrepareFeed<Y>(FeedQuery q) where Y : new()
		{
			PrepareQuery(q);
			Feed<Y> feed = CreateFeed<Y>(q);
			feed.Settings = requestSettings_0;
			feed.AutoPaging = requestSettings_0.AutoPaging;
			feed.Maximum = requestSettings_0.Maximum;
			return feed;
		}

		protected virtual Feed<Y> CreateFeed<Y>(FeedQuery q) where Y : new()
		{
			return new Feed<Y>((Service)(object)gparam_0, q);
		}

		public Feed<Y> Get<Y>(FeedQuery q) where Y : new()
		{
			return PrepareFeed<Y>(q);
		}

		public Feed<Y> Get<Y>(Uri uri) where Y : new()
		{
			FeedQuery q = new FeedQuery(uri.AbsoluteUri);
			return PrepareFeed<Y>(q);
		}

		protected virtual void OnSetOtherProxies(IWebProxy proxy)
		{
		}

		public Feed<Y> Get<Y>(Feed<Y> feed, FeedRequestType operation) where Y : new()
		{
			Feed<Y> result = null;
			string text = null;
			if (feed == null)
			{
				throw new ArgumentNullException("feed was 7a242eee02ac9392");
			}
			if (feed.AtomFeed == null)
			{
				throw new ArgumentNullException("feed.AtomFeed was 7a242eee02ac9392");
			}
			switch (operation)
			{
			case FeedRequestType.Next:
				text = feed.AtomFeed.NextChunk;
				break;
			case FeedRequestType.Prev:
				text = feed.AtomFeed.PrevChunk;
				break;
			case FeedRequestType.Refresh:
				text = feed.AtomFeed.Self;
				break;
			}
			if (!string.IsNullOrEmpty(text))
			{
				FeedQuery feedQuery = new FeedQuery(text);
				if (operation == FeedRequestType.Refresh)
				{
					ISupportsEtag supportsEtag = feed.AtomFeed as ISupportsEtag;
					if (supportsEtag != null && supportsEtag.Etag != null)
					{
						feedQuery.Etag = supportsEtag.Etag;
					}
				}
				result = PrepareFeed<Y>(feedQuery);
			}
			return result;
		}

		public Feed<Y> Parse<Y>(Stream inputStream, Uri targetUri) where Y : new()
		{
			if (targetUri == null)
			{
				throw new ArgumentNullException("targetUri can not be 7a242eee02ac9392");
			}
			if (inputStream == null)
			{
				throw new ArgumentNullException("inputStream can not be 7a242eee02ac9392");
			}
			AtomFeed af = ((Service)Service).method_19(inputStream, targetUri);
			return new Feed<Y>(af);
		}

		public Y ParseEntry<Y>(Stream inputStream, Uri targetUri) where Y : new()
		{
			Feed<Y> feed = Parse<Y>(inputStream, targetUri);
			using (IEnumerator<Y> enumerator = feed.Entries.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					return enumerator.Current;
				}
			}
			return default(Y);
		}

		public Feed<Y> Batch<Y>(List<Y> entries, Feed<Y> feed) where Y : Entry, new()
		{
			return Batch(entries, feed, GDataBatchOperationType.Default);
		}

		public Feed<Y> Batch<Y>(List<Y> entries, Feed<Y> feed, GDataBatchOperationType defaultOperation) where Y : new()
		{
			if (feed != null && feed.AtomFeed != null)
			{
				if (feed.AtomFeed.Batch == null)
				{
					throw new ArgumentException("Feed has no valid batch endpoint");
				}
				return Batch(entries, new Uri(feed.AtomFeed.Batch), defaultOperation);
			}
			throw new ArgumentNullException("Invalid feed passed in");
		}

		public Feed<Y> Batch<Y>(List<Y> entries, Uri batchUri, GDataBatchOperationType defaultOperation) where Y : new()
		{
			if (entries.Count > 0)
			{
				AtomFeed atomFeed = new AtomFeed(batchUri, null);
				atomFeed.BatchData = new GDataBatchFeedData();
				atomFeed.BatchData.Type = defaultOperation;
				foreach (Y entry in entries)
				{
					atomFeed.Entries.Add(((Entry)entry).AtomEntry);
				}
				FeedQuery feedQuery = PrepareQuery<FeedQuery>(batchUri.AbsoluteUri);
				AtomFeed af = ((Service)Service).Batch(atomFeed, feedQuery.Uri);
				return new Feed<Y>(af);
			}
			return null;
		}

		public Y Retrieve<Y>(Y entry) where Y : Entry, new()
		{
			if (entry == null)
			{
				throw new ArgumentNullException("entry was 7a242eee02ac9392");
			}
			if (entry.AtomEntry == null)
			{
				throw new ArgumentNullException("entry.AtomEntry was 7a242eee02ac9392");
			}
			string text = entry.AtomEntry.SelfUri.ToString();
			if (!string.IsNullOrEmpty(text))
			{
				FeedQuery feedQuery = new FeedQuery(text);
				ISupportsEtag supportsEtag = entry.AtomEntry as ISupportsEtag;
				if (supportsEtag != null && supportsEtag.Etag != null)
				{
					feedQuery.Etag = supportsEtag.Etag;
				}
				return Retrieve<Y>(feedQuery);
			}
			return null;
		}

		public Y Retrieve<Y>(Uri entryUri) where Y : new()
		{
			string absoluteUri = entryUri.AbsoluteUri;
			if (!string.IsNullOrEmpty(absoluteUri))
			{
				FeedQuery query = new FeedQuery(absoluteUri);
				return Retrieve<Y>(query);
			}
			return default(Y);
		}

		public Y Retrieve<Y>(FeedQuery query) where Y : new()
		{
			Feed<Y> feed = null;
			Y result = default(Y);
			feed = PrepareFeed<Y>(query);
			foreach (Y entry in feed.Entries)
			{
				result = entry;
			}
			return result;
		}

		public Y Update<Y>(Y entry) where Y : new()
		{
			if (entry == null)
			{
				throw new ArgumentNullException("Entry was 7a242eee02ac9392");
			}
			if (((Entry)entry).AtomEntry == null)
			{
				throw new ArgumentNullException("Entry.AtomEntry was 7a242eee02ac9392");
			}
			Y result = default(Y);
			FeedQuery feedQuery = PrepareQuery<FeedQuery>(((Entry)entry).AtomEntry.EditUri.ToString());
			Stream a_ = ((Service)Service).EntrySend(feedQuery.Uri, (AtomBase)((Entry)entry).AtomEntry, GDataRequestType.Update, (AsyncSendData)null);
			AtomEntry atomEntry = ((Service)Service).method_20(a_, new Uri(((Entry)entry).AtomEntry.EditUri.ToString()));
			if (atomEntry != null)
			{
				result = new Y
				{
					AtomEntry = atomEntry
				};
			}
			return result;
		}

		public void Delete<Y>(Y entry) where Y : new()
		{
			if (entry == null)
			{
				throw new ArgumentNullException("Entry was 7a242eee02ac9392");
			}
			if (((Entry)entry).AtomEntry == null)
			{
				throw new ArgumentNullException("Entry.AtomEntry was 7a242eee02ac9392");
			}
			if (((Entry)entry).AtomEntry.EditUri == null)
			{
				throw new ArgumentNullException("The AtomEntry has no EditUri");
			}
			FeedQuery feedQuery = PrepareQuery<FeedQuery>(((Entry)entry).AtomEntry.EditUri.ToString());
			((Service)Service).Delete(feedQuery.Uri, ((Entry)entry).ETag);
		}

		public void Delete(Uri targetUrl, string eTag)
		{
			FeedQuery feedQuery = PrepareQuery<FeedQuery>(targetUrl.AbsoluteUri);
			((Service)Service).Delete(feedQuery.Uri, eTag);
		}

		public Y Insert<Y>(Uri address, Y entry) where Y : new()
		{
			if (entry == null)
			{
				throw new ArgumentNullException("Entry was 7a242eee02ac9392");
			}
			if (((Entry)entry).AtomEntry == null)
			{
				throw new ArgumentNullException("Entry.AtomEntry was 7a242eee02ac9392");
			}
			if (address == null)
			{
				throw new ArgumentNullException("Address was 7a242eee02ac9392");
			}
			Y result = default(Y);
			FeedQuery feedQuery = PrepareQuery<FeedQuery>(address.AbsoluteUri);
			AtomEntry atomEntry = ((Service)Service).Insert(feedQuery.Uri, ((Entry)entry).AtomEntry);
			if (atomEntry != null)
			{
				result = new Y
				{
					AtomEntry = atomEntry
				};
			}
			return result;
		}

		public Y Insert<Y>(Feed<Y> feed, Y entry) where Y : new()
		{
			return Insert(new Uri(feed.AtomFeed.Post), entry);
		}
	}
}
