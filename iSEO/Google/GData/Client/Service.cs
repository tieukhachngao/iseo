using System;
using System.ComponentModel;
using System.IO;
using System.Threading;

namespace Google.GData.Client
{
	public class Service : AsyncDataHandler, IVersionAware, IService
	{
		private delegate void Delegate0(AsyncSendData A_0, AsyncOperation A_1, SendOrPostCallback A_2);

		private delegate void Delegate1(AsyncDeleteData A_0, AsyncOperation A_1, SendOrPostCallback A_2);

		private GDataCredentials gdataCredentials_0;

		private IGDataRequestFactory igdataRequestFactory_0;

		private FeedParserEventHandler feedParserEventHandler_0;

		private ExtensionElementEventHandler extensionElementEventHandler_0;

		private ServiceEventHandler serviceEventHandler_0;

		private string string_0;

		private Class59 class59_0 = new Class59();

		public string ServiceIdentifier => string_0;

		public int ProtocolMajor
		{
			get
			{
				return class59_0.ProtocolMajor;
			}
			set
			{
				class59_0.ProtocolMajor = value;
				method_15();
			}
		}

		public int ProtocolMinor
		{
			get
			{
				return class59_0.ProtocolMinor;
			}
			set
			{
				class59_0.ProtocolMinor = value;
				method_15();
			}
		}

		public IGDataRequestFactory RequestFactory
		{
			get
			{
				return igdataRequestFactory_0;
			}
			set
			{
				igdataRequestFactory_0 = value;
				OnRequestFactoryChanged();
			}
		}

		public GDataCredentials Credentials
		{
			get
			{
				return gdataCredentials_0;
			}
			set
			{
				gdataCredentials_0 = value;
				SetAuthenticationToken(value?.ClientToken);
			}
		}

		public event FeedParserEventHandler NewAtomEntry
		{
			add
			{
				FeedParserEventHandler feedParserEventHandler = feedParserEventHandler_0;
				FeedParserEventHandler feedParserEventHandler2;
				do
				{
					feedParserEventHandler2 = feedParserEventHandler;
					FeedParserEventHandler value2 = (FeedParserEventHandler)Delegate.Combine(feedParserEventHandler2, value);
					feedParserEventHandler = Interlocked.CompareExchange(ref feedParserEventHandler_0, value2, feedParserEventHandler2);
				}
				while ((object)feedParserEventHandler != feedParserEventHandler2);
			}
			remove
			{
				FeedParserEventHandler feedParserEventHandler = feedParserEventHandler_0;
				FeedParserEventHandler feedParserEventHandler2;
				do
				{
					feedParserEventHandler2 = feedParserEventHandler;
					FeedParserEventHandler value2 = (FeedParserEventHandler)Delegate.Remove(feedParserEventHandler2, value);
					feedParserEventHandler = Interlocked.CompareExchange(ref feedParserEventHandler_0, value2, feedParserEventHandler2);
				}
				while ((object)feedParserEventHandler != feedParserEventHandler2);
			}
		}

		public event ExtensionElementEventHandler NewExtensionElement
		{
			add
			{
				ExtensionElementEventHandler extensionElementEventHandler = extensionElementEventHandler_0;
				ExtensionElementEventHandler extensionElementEventHandler2;
				do
				{
					extensionElementEventHandler2 = extensionElementEventHandler;
					ExtensionElementEventHandler value2 = (ExtensionElementEventHandler)Delegate.Combine(extensionElementEventHandler2, value);
					extensionElementEventHandler = Interlocked.CompareExchange(ref extensionElementEventHandler_0, value2, extensionElementEventHandler2);
				}
				while ((object)extensionElementEventHandler != extensionElementEventHandler2);
			}
			remove
			{
				ExtensionElementEventHandler extensionElementEventHandler = extensionElementEventHandler_0;
				ExtensionElementEventHandler extensionElementEventHandler2;
				do
				{
					extensionElementEventHandler2 = extensionElementEventHandler;
					ExtensionElementEventHandler value2 = (ExtensionElementEventHandler)Delegate.Remove(extensionElementEventHandler2, value);
					extensionElementEventHandler = Interlocked.CompareExchange(ref extensionElementEventHandler_0, value2, extensionElementEventHandler2);
				}
				while ((object)extensionElementEventHandler != extensionElementEventHandler2);
			}
		}

		public event ServiceEventHandler NewFeed
		{
			add
			{
				ServiceEventHandler serviceEventHandler = serviceEventHandler_0;
				ServiceEventHandler serviceEventHandler2;
				do
				{
					serviceEventHandler2 = serviceEventHandler;
					ServiceEventHandler value2 = (ServiceEventHandler)Delegate.Combine(serviceEventHandler2, value);
					serviceEventHandler = Interlocked.CompareExchange(ref serviceEventHandler_0, value2, serviceEventHandler2);
				}
				while ((object)serviceEventHandler != serviceEventHandler2);
			}
			remove
			{
				ServiceEventHandler serviceEventHandler = serviceEventHandler_0;
				ServiceEventHandler serviceEventHandler2;
				do
				{
					serviceEventHandler2 = serviceEventHandler;
					ServiceEventHandler value2 = (ServiceEventHandler)Delegate.Remove(serviceEventHandler2, value);
					serviceEventHandler = Interlocked.CompareExchange(ref serviceEventHandler_0, value2, serviceEventHandler2);
				}
				while ((object)serviceEventHandler != serviceEventHandler2);
			}
		}

		public void QueryFeedAync(Uri queryUri, DateTime ifModifiedSince, object userData)
		{
			method_5(queryUri, ifModifiedSince, A_2: true, userData);
		}

		public void QueryStreamAync(Uri queryUri, DateTime ifModifiedSince, object userData)
		{
			method_5(queryUri, ifModifiedSince, A_2: false, userData);
		}

		private void method_5(Uri A_0, DateTime A_1, bool A_2, object A_3)
		{
			AsyncOperation asyncOperation = AsyncOperationManager.CreateOperation(A_3);
			AsyncQueryData data = new AsyncQueryData(A_0, A_1, A_2, asyncOperation, A_3, base.ProgressReportDelegate);
			AddUserDataToDictionary(A_3, asyncOperation);
			WorkerQueryEventHandler workerQueryEventHandler = method_6;
			workerQueryEventHandler.BeginInvoke(data, asyncOperation, base.CompletionMethodDelegate, null, null);
		}

		private void method_6(AsyncQueryData A_0, AsyncOperation A_1, SendOrPostCallback A_2)
		{
			try
			{
				long A_3;
				using Stream responseStream = method_16(A_0.UriToUse, A_0.Modified, null, out A_3);
				HandleResponseStream(A_0, responseStream, A_3);
			}
			catch (Exception ex)
			{
				Exception ex3 = (A_0.Exception = ex);
			}
			A_2(A_0);
		}

		public void UpdateAsync(AtomEntry entry, object userData)
		{
			AsyncSendData a_ = new AsyncSendData(this, entry, base.ProgressReportDelegate, userData);
			Delegate0 a_2 = method_8;
			method_12(a_, a_2, userData);
		}

		public void InsertAsync(Uri feedUri, AtomEntry entry, object userData)
		{
			AsyncSendData a_ = new AsyncSendData(this, feedUri, entry, base.ProgressReportDelegate, userData);
			Delegate0 a_2 = method_9;
			method_12(a_, a_2, userData);
		}

		public void BatchAsync(AtomFeed feed, Uri batchUri, object userData)
		{
			AsyncSendData a_ = new AsyncSendData(this, batchUri, feed, base.ProgressReportDelegate, userData);
			Delegate0 a_2 = method_10;
			method_12(a_, a_2, userData);
		}

		public void StreamSendFeedAsync(Uri targetUri, Stream inputStream, GDataRequestType type, string contentType, string slugHeader, object userData)
		{
			method_7(targetUri, inputStream, type, contentType, slugHeader, userData, A_6: true);
		}

		public void StreamSendStreamAsync(Uri targetUri, Stream inputStream, GDataRequestType type, string contentType, string slugHeader, object userData)
		{
			method_7(targetUri, inputStream, type, contentType, slugHeader, userData, A_6: false);
		}

		private void method_7(Uri A_0, Stream A_1, GDataRequestType A_2, string A_3, string A_4, object A_5, bool A_6)
		{
			AsyncSendData a_ = new AsyncSendData(this, A_0, A_1, A_2, A_3, A_4, base.ProgressReportDelegate, A_5, A_6);
			Delegate0 a_2 = method_11;
			method_12(a_, a_2, A_5);
		}

		protected override void HandleResponseStream(AsyncData data, Stream responseStream, long contentLength)
		{
			if (data.ParseFeed)
			{
				data.Feed = method_19(responseStream, data.UriToUse);
				data.DataStream = null;
			}
			else
			{
				base.HandleResponseStream(data, responseStream, contentLength);
			}
		}

		private void method_8(AsyncSendData A_0, AsyncOperation A_1, SendOrPostCallback A_2)
		{
			try
			{
				A_0.Entry = method_17(A_0.Entry, A_0);
			}
			catch (Exception ex)
			{
				Exception ex3 = (A_0.Exception = ex);
			}
			A_2(A_0);
		}

		private void method_9(AsyncSendData A_0, AsyncOperation A_1, SendOrPostCallback A_2)
		{
			try
			{
				A_0.Entry = method_18(A_0.UriToUse, A_0.Entry, A_0);
			}
			catch (Exception ex)
			{
				Exception ex3 = (A_0.Exception = ex);
			}
			A_2(A_0);
		}

		private void method_10(AsyncSendData A_0, AsyncOperation A_1, SendOrPostCallback A_2)
		{
			try
			{
				A_0.Feed = method_22(A_0.Feed, A_0.UriToUse, A_0);
			}
			catch (Exception ex)
			{
				Exception ex3 = (A_0.Exception = ex);
			}
			A_2(A_0);
		}

		private void method_11(AsyncSendData A_0, AsyncOperation A_1, SendOrPostCallback A_2)
		{
			try
			{
				using Stream responseStream = method_21(A_0.UriToUse, A_0.DataStream, A_0.Type, A_0.ContentType, A_0.SlugHeader, null, A_0);
				HandleResponseStream(A_0, responseStream, -1L);
			}
			catch (Exception ex)
			{
				Exception ex3 = (A_0.Exception = ex);
			}
			A_2(A_0);
		}

		private void method_12(AsyncSendData A_0, Delegate0 A_1, object A_2)
		{
			AsyncOperation asyncOperation2 = (A_0.Operation = AsyncOperationManager.CreateOperation(A_2));
			AddUserDataToDictionary(A_2, asyncOperation2);
			A_1.BeginInvoke(A_0, asyncOperation2, base.CompletionMethodDelegate, null, null);
		}

		public void DeleteAsync(AtomEntry entry, bool permanentDelete, object userData)
		{
			AsyncDeleteData a_ = new AsyncDeleteData(entry, permanentDelete, userData, base.ProgressReportDelegate);
			method_13(a_, method_14, userData);
		}

		private void method_13(AsyncDeleteData A_0, Delegate1 A_1, object A_2)
		{
			AsyncOperation asyncOperation2 = (A_0.Operation = AsyncOperationManager.CreateOperation(A_2));
			AddUserDataToDictionary(A_2, asyncOperation2);
			A_1.BeginInvoke(A_0, asyncOperation2, base.CompletionMethodDelegate, null, null);
		}

		private void method_14(AsyncDeleteData A_0, AsyncOperation A_1, SendOrPostCallback A_2)
		{
			try
			{
				Delete(A_0.Entry, A_0.PermanentDelete);
			}
			catch (Exception ex)
			{
				Exception ex3 = (A_0.Exception = ex);
			}
			A_2(A_0);
		}

		public Service()
		{
			RequestFactory = new GDataRequestFactory(GetType().Name);
			InitVersionInformation();
		}

		public Service(string applicationName)
		{
			RequestFactory = new GDataRequestFactory((applicationName == null) ? GetType().Name : applicationName);
			InitVersionInformation();
		}

		public Service(string service, string applicationName)
		{
			RequestFactory = new GDataGAuthRequestFactory(service, applicationName);
			string_0 = service;
			InitVersionInformation();
		}

		protected virtual void InitVersionInformation()
		{
		}

		public virtual void OnRequestFactoryChanged()
		{
			method_15();
		}

		private void method_15()
		{
			IVersionAware versionAware = igdataRequestFactory_0 as IVersionAware;
			if (versionAware != null)
			{
				versionAware.ProtocolMajor = ProtocolMajor;
				versionAware.ProtocolMinor = ProtocolMinor;
			}
		}

		[Obsolete("the name is confusing. Do not use this, use QueryClientLoginToken instead")]
		public string QueryAuthenticationToken()
		{
			if (Credentials != null)
			{
				GDataGAuthRequestFactory gDataGAuthRequestFactory = igdataRequestFactory_0 as GDataGAuthRequestFactory;
				if (gDataGAuthRequestFactory != null)
				{
					return gDataGAuthRequestFactory.QueryAuthToken(Credentials);
				}
			}
			return null;
		}

		public string QueryClientLoginToken()
		{
			if (Credentials != null)
			{
				GDataGAuthRequestFactory gDataGAuthRequestFactory = igdataRequestFactory_0 as GDataGAuthRequestFactory;
				if (gDataGAuthRequestFactory != null)
				{
					return gDataGAuthRequestFactory.QueryAuthToken(Credentials);
				}
			}
			return null;
		}

		public void SetAuthenticationToken(string token)
		{
			GDataGAuthRequestFactory gDataGAuthRequestFactory = igdataRequestFactory_0 as GDataGAuthRequestFactory;
			if (gDataGAuthRequestFactory != null)
			{
				gDataGAuthRequestFactory.GAuthToken = token;
				return;
			}
			GAuthSubRequestFactory gAuthSubRequestFactory = igdataRequestFactory_0 as GAuthSubRequestFactory;
			if (gAuthSubRequestFactory != null)
			{
				gAuthSubRequestFactory.Token = token;
			}
		}

		public void setUserCredentials(string username, string password)
		{
			Credentials = new GDataCredentials(username, password);
		}

		public Stream Query(Uri queryUri)
		{
			return Query(queryUri, DateTime.MinValue);
		}

		public Stream Query(Uri queryUri, DateTime ifModifiedSince)
		{
			long A_;
			return method_16(queryUri, ifModifiedSince, null, out A_);
		}

		public Stream Query(Uri queryUri, string etag)
		{
			long A_;
			return method_16(queryUri, DateTime.MinValue, etag, out A_);
		}

		private Stream method_16(Uri A_0, DateTime A_1, string A_2, out long A_3)
		{
			if (A_0 == null)
			{
				throw new ArgumentNullException("queryUri");
			}
			A_3 = -1L;
			IGDataRequest iGDataRequest = RequestFactory.CreateRequest(GDataRequestType.Query, A_0);
			iGDataRequest.Credentials = Credentials;
			iGDataRequest.IfModifiedSince = A_1;
			if (A_2 != null)
			{
				ISupportsEtag supportsEtag = iGDataRequest as ISupportsEtag;
				if (supportsEtag != null)
				{
					supportsEtag.Etag = A_2;
				}
			}
			try
			{
				iGDataRequest.Execute();
			}
			catch (Exception)
			{
				if (iGDataRequest.GetResponseStream() != null)
				{
					iGDataRequest.GetResponseStream().Close();
				}
				throw;
			}
			GDataGAuthRequest gDataGAuthRequest = iGDataRequest as GDataGAuthRequest;
			if (gDataGAuthRequest != null)
			{
				A_3 = gDataGAuthRequest.ContentLength;
			}
			return new GDataReturnStream(iGDataRequest);
		}

		public AtomEntry Get(string entryUri)
		{
			FeedQuery feedQuery = new FeedQuery(entryUri);
			AtomFeed atomFeed = Query(feedQuery);
			return atomFeed.Entries[0];
		}

		public AtomFeed Query(FeedQuery feedQuery)
		{
			AtomFeed result = null;
			if (feedQuery == null)
			{
				throw new ArgumentNullException("feedQuery", "The query argument MUST not be 7a242eee02ac9392");
			}
			Uri uri = null;
			try
			{
				uri = feedQuery.Uri;
			}
			catch (UriFormatException)
			{
				throw new ArgumentException("The query argument MUST contain a valid Uri", "feedQuery");
			}
			Stream stream = null;
			stream = ((feedQuery.Etag == null) ? Query(uri, feedQuery.ModifiedSince) : Query(uri, feedQuery.Etag));
			if (stream != null)
			{
				result = method_19(stream, feedQuery.Uri);
			}
			return result;
		}

		[Obsolete("FeedQuery has a modifiedSince property, use that instead")]
		public AtomFeed Query(FeedQuery feedQuery, DateTime ifModifiedSince)
		{
			feedQuery.ModifiedSince = ifModifiedSince;
			return Query(feedQuery);
		}

		public Stream QueryOpenSearchRssDescription(Uri serviceUri)
		{
			if (serviceUri == null)
			{
				throw new ArgumentNullException("serviceUri");
			}
			IGDataRequest iGDataRequest = RequestFactory.CreateRequest(GDataRequestType.Query, serviceUri);
			iGDataRequest.Credentials = Credentials;
			iGDataRequest.Execute();
			return iGDataRequest.GetResponseStream();
		}

		public AtomEntry Update(AtomEntry entry)
		{
			return method_17(entry, null);
		}

		public TEntry Update<TEntry>(TEntry entry) where TEntry : AtomEntry
		{
			return method_17(entry, null) as TEntry;
		}

		private AtomEntry method_17(AtomEntry A_0, AsyncSendData A_1)
		{
			if (A_0 == null)
			{
				throw new ArgumentNullException("entry");
			}
			if (A_0.ReadOnly)
			{
				throw new GDataRequestException("Can not update a read-only entry");
			}
			Uri uri = new Uri(A_0.EditUri.ToString());
			Stream a_ = EntrySend(uri, A_0, GDataRequestType.Update, A_1);
			return method_20(a_, uri);
		}

		AtomEntry IService.Insert(AtomFeed feed, AtomEntry entry)
		{
			if (feed == null)
			{
				throw new ArgumentNullException("feed");
			}
			if (entry == null)
			{
				throw new ArgumentNullException("entry");
			}
			if (feed.ReadOnly)
			{
				throw new GDataRequestException("Can not update a read-only feed");
			}
			Uri feedUri = new Uri(feed.Post);
			return Insert(feedUri, entry);
		}

		public TEntry Insert<TEntry>(AtomFeed feed, TEntry entry)
		{
			AtomEntry atomEntry = ((IService)this).Insert(feed, (AtomEntry)(object)entry);
			return (TEntry)(object)((atomEntry is TEntry) ? atomEntry : null);
		}

		public TEntry Insert<TEntry>(Uri feedUri, TEntry entry)
		{
			AtomEntry atomEntry = method_18(feedUri, (AtomEntry)(object)entry, null);
			return (TEntry)(object)((atomEntry is TEntry) ? atomEntry : null);
		}

		public TEntry Insert<TEntry>(string feedUri, TEntry entry) where TEntry : AtomEntry
		{
			return method_18(new Uri(feedUri), entry, null) as TEntry;
		}

		protected AtomEntry internalInsert(Uri feedUri, AtomEntry newEntry)
		{
			return method_18(feedUri, newEntry, null);
		}

		private AtomEntry method_18(Uri A_0, AtomEntry A_1, AsyncSendData A_2)
		{
			if (A_0 == null)
			{
				throw new ArgumentNullException("feedUri");
			}
			if (A_1 == null)
			{
				throw new ArgumentNullException("newEntry");
			}
			class59_0.method_0(A_1);
			Stream a_ = EntrySend(A_0, A_1, GDataRequestType.Insert, A_2);
			return method_20(a_, A_0);
		}

		public AtomEntry Update(Uri uriTarget, Stream input, string contentType, string slugHeader)
		{
			Stream a_ = StreamSend(uriTarget, input, GDataRequestType.Update, contentType, slugHeader);
			return method_20(a_, uriTarget);
		}

		public AtomEntry Insert(Uri uriTarget, Stream input, string contentType, string slugHeader)
		{
			Stream a_ = StreamSend(uriTarget, input, GDataRequestType.Insert, contentType, slugHeader);
			return method_20(a_, uriTarget);
		}

		internal AtomFeed method_19(Stream A_0, Uri A_1)
		{
			AtomFeed result = null;
			if (A_0 != null)
			{
				result = CreateFeed(A_1);
				class59_0.method_0(result);
				try
				{
					result.NewAtomEntry += OnParsedNewEntry;
					result.NewExtensionElement += OnNewExtensionElement;
					result.Parse(A_0, AlternativeFormat.Atom);
					return result;
				}
				finally
				{
					A_0.Close();
				}
			}
			return result;
		}

		internal AtomEntry method_20(Stream A_0, Uri A_1)
		{
			AtomFeed atomFeed = method_19(A_0, A_1);
			AtomEntry atomEntry = null;
			if (atomFeed != null && atomFeed.Entries.Count > 0)
			{
				atomEntry = atomFeed.Entries[0];
				if (atomEntry != null)
				{
					atomEntry.Service = this;
					atomEntry.method_3(null);
				}
			}
			return atomEntry;
		}

		public Stream EntrySend(Uri feedUri, AtomEntry baseEntry, GDataRequestType type)
		{
			return EntrySend(feedUri, baseEntry, type, null);
		}

		internal virtual Stream EntrySend(Uri feedUri, AtomBase baseEntry, GDataRequestType type, AsyncSendData data)
		{
			if (feedUri == null)
			{
				throw new ArgumentNullException("feedUri");
			}
			if (baseEntry == null)
			{
				throw new ArgumentNullException("baseEntry");
			}
			class59_0.method_0(baseEntry);
			IGDataRequest iGDataRequest = RequestFactory.CreateRequest(type, feedUri);
			iGDataRequest.Credentials = Credentials;
			ISupportsEtag supportsEtag = iGDataRequest as ISupportsEtag;
			ISupportsEtag supportsEtag2 = baseEntry as ISupportsEtag;
			if (supportsEtag != null && supportsEtag2 != null)
			{
				supportsEtag.Etag = supportsEtag2.Etag;
			}
			if (data != null)
			{
				GDataGAuthRequest gDataGAuthRequest = iGDataRequest as GDataGAuthRequest;
				if (gDataGAuthRequest != null)
				{
					gDataGAuthRequest.AsyncData = data;
				}
			}
			Stream requestStream = iGDataRequest.GetRequestStream();
			baseEntry.SaveToXml(requestStream);
			iGDataRequest.Execute();
			requestStream.Close();
			return iGDataRequest.GetResponseStream();
		}

		public Stream StringSend(Uri targetUri, string payload, GDataRequestType type)
		{
			if (targetUri == null)
			{
				throw new ArgumentNullException("targetUri");
			}
			if (payload == null)
			{
				throw new ArgumentNullException("payload");
			}
			IGDataRequest iGDataRequest = RequestFactory.CreateRequest(type, targetUri);
			iGDataRequest.Credentials = Credentials;
			Stream requestStream = iGDataRequest.GetRequestStream();
			StreamWriter streamWriter = new StreamWriter(requestStream);
			streamWriter.Write(payload);
			streamWriter.Flush();
			iGDataRequest.Execute();
			streamWriter.Close();
			return iGDataRequest.GetResponseStream();
		}

		public Stream StreamSend(Uri targetUri, Stream inputStream, GDataRequestType type, string contentType, string slugHeader)
		{
			return method_21(targetUri, inputStream, type, contentType, slugHeader, null, null);
		}

		public Stream StreamSend(Uri targetUri, Stream inputStream, GDataRequestType type, string contentType, string slugHeader, string etag)
		{
			return method_21(targetUri, inputStream, type, contentType, slugHeader, etag, null);
		}

		private Stream method_21(Uri A_0, Stream A_1, GDataRequestType A_2, string A_3, string A_4, string A_5, AsyncSendData A_6)
		{
			if (A_0 == null)
			{
				throw new ArgumentNullException("targetUri");
			}
			if (A_1 == null)
			{
				throw new ArgumentNullException("inputStream");
			}
			if (A_2 != GDataRequestType.Insert && A_2 != GDataRequestType.Update)
			{
				throw new ArgumentNullException("type");
			}
			IGDataRequest iGDataRequest = RequestFactory.CreateRequest(A_2, A_0);
			iGDataRequest.Credentials = Credentials;
			if (A_6 != null)
			{
				GDataGAuthRequest gDataGAuthRequest = iGDataRequest as GDataGAuthRequest;
				if (gDataGAuthRequest != null)
				{
					gDataGAuthRequest.AsyncData = A_6;
				}
			}
			if (A_3 != null)
			{
				GDataRequest gDataRequest = iGDataRequest as GDataRequest;
				if (gDataRequest != null)
				{
					gDataRequest.ContentType = A_3;
				}
			}
			if (A_4 != null)
			{
				GDataRequest gDataRequest2 = iGDataRequest as GDataRequest;
				if (gDataRequest2 != null)
				{
					gDataRequest2.Slug = A_4;
				}
			}
			if (A_5 != null)
			{
				ISupportsEtag supportsEtag = iGDataRequest as ISupportsEtag;
				if (supportsEtag != null)
				{
					supportsEtag.Etag = A_5;
				}
			}
			Stream requestStream = iGDataRequest.GetRequestStream();
			WriteInputStreamToRequest(A_1, requestStream);
			iGDataRequest.Execute();
			requestStream.Close();
			return new GDataReturnStream(iGDataRequest);
		}

		protected void WriteInputStreamToRequest(Stream input, Stream output)
		{
			BinaryWriter binaryWriter = new BinaryWriter(output);
			byte[] buffer = new byte[4096];
			int count;
			while ((count = input.Read(buffer, 0, 4096)) > 0)
			{
				binaryWriter.Write(buffer, 0, count);
			}
			binaryWriter.Flush();
		}

		protected virtual AtomFeed CreateFeed(Uri uriToUse)
		{
			ServiceEventArgs serviceEventArgs = null;
			AtomFeed atomFeed = null;
			if (serviceEventHandler_0 != null)
			{
				serviceEventArgs = new ServiceEventArgs(uriToUse, this);
				serviceEventHandler_0(this, serviceEventArgs);
			}
			if (serviceEventArgs != null)
			{
				atomFeed = serviceEventArgs.Feed;
			}
			if (atomFeed == null)
			{
				atomFeed = new AtomFeed(uriToUse, this);
			}
			return atomFeed;
		}

		public AtomFeed Batch(AtomFeed feed, Uri batchUri)
		{
			return method_22(feed, batchUri, null);
		}

		private AtomFeed method_22(AtomFeed A_0, Uri A_1, AsyncSendData A_2)
		{
			Uri uri = A_1;
			if (A_0 == null)
			{
				throw new ArgumentNullException("feed");
			}
			if (uri == null)
			{
				uri = ((A_0.Batch == null) ? null : new Uri(A_0.Batch));
			}
			if (uri == null)
			{
				throw new ArgumentNullException("batchUri");
			}
			if (A_0 == null)
			{
				throw new ArgumentNullException("feed");
			}
			if (A_0.BatchData == null)
			{
				A_0.BatchData = new GDataBatchFeedData();
			}
			Stream a_ = EntrySend(uri, A_0, GDataRequestType.Batch, A_2);
			return method_19(a_, uri);
		}

		public void Delete(AtomEntry entry)
		{
			Delete(entry, permanentDelete: false);
		}

		public void Delete(AtomEntry entry, bool permanentDelete)
		{
			string eTag = null;
			if (entry == null)
			{
				throw new ArgumentNullException("entry");
			}
			if (entry.ReadOnly)
			{
				throw new GDataRequestException("Can not update a read-only entry");
			}
			ISupportsEtag supportsEtag = entry as ISupportsEtag;
			if (supportsEtag != null)
			{
				eTag = supportsEtag.Etag;
			}
			if (!(entry.EditUri != null))
			{
				throw new GDataRequestException("Invalid Entry object (no edit uri) to call Delete on");
			}
			string uriString = entry.EditUri.Content + (permanentDelete ? "?delete=true" : string.Empty);
			Delete(new Uri(uriString), eTag);
		}

		public void Delete(Uri uriTarget)
		{
			Delete(uriTarget, null);
		}

		public void Delete(string uriTarget)
		{
			Delete(new Uri(uriTarget));
		}

		public void Delete(Uri uriTarget, string eTag)
		{
			if (uriTarget == null)
			{
				throw new ArgumentNullException("uriTarget");
			}
			IGDataRequest iGDataRequest = RequestFactory.CreateRequest(GDataRequestType.Delete, uriTarget);
			ISupportsEtag supportsEtag = iGDataRequest as ISupportsEtag;
			if (supportsEtag != null && eTag != null)
			{
				supportsEtag.Etag = eTag;
			}
			iGDataRequest.Credentials = Credentials;
			iGDataRequest.Execute();
			IDisposable disposable = iGDataRequest as IDisposable;
			disposable.Dispose();
		}

		protected void OnParsedNewEntry(object sender, FeedParserEventArgs e)
		{
			if (e == null)
			{
				throw new ArgumentNullException("e");
			}
			if (feedParserEventHandler_0 != null)
			{
				feedParserEventHandler_0(this, e);
			}
		}

		protected void OnNewExtensionElement(object sender, ExtensionElementEventArgs e)
		{
			if (e == null)
			{
				throw new ArgumentNullException("e");
			}
			if (extensionElementEventHandler_0 != null)
			{
				extensionElementEventHandler_0(this, e);
			}
		}
	}
}
