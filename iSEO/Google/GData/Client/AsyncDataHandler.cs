using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Threading;

namespace Google.GData.Client
{
	public abstract class AsyncDataHandler
	{
		protected delegate void WorkerQueryEventHandler(AsyncQueryData data, AsyncOperation asyncOp, SendOrPostCallback completionMethodDelegate);

		private AsyncOperationCompletedEventHandler asyncOperationCompletedEventHandler_0;

		private AsyncOperationProgressEventHandler asyncOperationProgressEventHandler_0;

		private SendOrPostCallback sendOrPostCallback_0;

		private SendOrPostCallback sendOrPostCallback_1;

		private SendOrPostCallback sendOrPostCallback_2;

		private HybridDictionary hybridDictionary_0 = new HybridDictionary();

		protected SendOrPostCallback ProgressReportDelegate => sendOrPostCallback_0;

		protected SendOrPostCallback CompletionMethodDelegate => sendOrPostCallback_2;

		protected SendOrPostCallback OnCompletedDelegate => sendOrPostCallback_1;

		public event AsyncOperationCompletedEventHandler AsyncOperationCompleted
		{
			add
			{
				AsyncOperationCompletedEventHandler asyncOperationCompletedEventHandler = asyncOperationCompletedEventHandler_0;
				AsyncOperationCompletedEventHandler asyncOperationCompletedEventHandler2;
				do
				{
					asyncOperationCompletedEventHandler2 = asyncOperationCompletedEventHandler;
					AsyncOperationCompletedEventHandler value2 = (AsyncOperationCompletedEventHandler)Delegate.Combine(asyncOperationCompletedEventHandler2, value);
					asyncOperationCompletedEventHandler = Interlocked.CompareExchange(ref asyncOperationCompletedEventHandler_0, value2, asyncOperationCompletedEventHandler2);
				}
				while ((object)asyncOperationCompletedEventHandler != asyncOperationCompletedEventHandler2);
			}
			remove
			{
				AsyncOperationCompletedEventHandler asyncOperationCompletedEventHandler = asyncOperationCompletedEventHandler_0;
				AsyncOperationCompletedEventHandler asyncOperationCompletedEventHandler2;
				do
				{
					asyncOperationCompletedEventHandler2 = asyncOperationCompletedEventHandler;
					AsyncOperationCompletedEventHandler value2 = (AsyncOperationCompletedEventHandler)Delegate.Remove(asyncOperationCompletedEventHandler2, value);
					asyncOperationCompletedEventHandler = Interlocked.CompareExchange(ref asyncOperationCompletedEventHandler_0, value2, asyncOperationCompletedEventHandler2);
				}
				while ((object)asyncOperationCompletedEventHandler != asyncOperationCompletedEventHandler2);
			}
		}

		public event AsyncOperationProgressEventHandler AsyncOperationProgress
		{
			add
			{
				AsyncOperationProgressEventHandler asyncOperationProgressEventHandler = asyncOperationProgressEventHandler_0;
				AsyncOperationProgressEventHandler asyncOperationProgressEventHandler2;
				do
				{
					asyncOperationProgressEventHandler2 = asyncOperationProgressEventHandler;
					AsyncOperationProgressEventHandler value2 = (AsyncOperationProgressEventHandler)Delegate.Combine(asyncOperationProgressEventHandler2, value);
					asyncOperationProgressEventHandler = Interlocked.CompareExchange(ref asyncOperationProgressEventHandler_0, value2, asyncOperationProgressEventHandler2);
				}
				while ((object)asyncOperationProgressEventHandler != asyncOperationProgressEventHandler2);
			}
			remove
			{
				AsyncOperationProgressEventHandler asyncOperationProgressEventHandler = asyncOperationProgressEventHandler_0;
				AsyncOperationProgressEventHandler asyncOperationProgressEventHandler2;
				do
				{
					asyncOperationProgressEventHandler2 = asyncOperationProgressEventHandler;
					AsyncOperationProgressEventHandler value2 = (AsyncOperationProgressEventHandler)Delegate.Remove(asyncOperationProgressEventHandler2, value);
					asyncOperationProgressEventHandler = Interlocked.CompareExchange(ref asyncOperationProgressEventHandler_0, value2, asyncOperationProgressEventHandler2);
				}
				while ((object)asyncOperationProgressEventHandler != asyncOperationProgressEventHandler2);
			}
		}

		public AsyncDataHandler()
		{
			sendOrPostCallback_0 = method_0;
			sendOrPostCallback_1 = method_1;
			sendOrPostCallback_2 = method_2;
		}

		public void CancelAsync(object userData)
		{
			lock (hybridDictionary_0.SyncRoot)
			{
				object obj = hybridDictionary_0[userData];
				if (obj != null)
				{
					hybridDictionary_0.Remove(userData);
					AsyncOperation asyncOperation = obj as AsyncOperation;
					AsyncData a_ = new AsyncData(null, userData, sendOrPostCallback_0);
					AsyncOperationCompletedEventArgs arg = new AsyncOperationCompletedEventArgs(a_, A_1: true);
					asyncOperation.PostOperationCompleted(sendOrPostCallback_1, arg);
				}
			}
		}

		protected void AddUserDataToDictionary(object userData, AsyncOperation asyncOp)
		{
			lock (hybridDictionary_0.SyncRoot)
			{
				if (hybridDictionary_0.Contains(userData))
				{
					throw new ArgumentException("UserData parameter must be unique", "userData");
				}
				hybridDictionary_0[userData] = asyncOp;
			}
		}

		protected bool CheckIfOperationIsCancelled(object userData)
		{
			lock (hybridDictionary_0.SyncRoot)
			{
				if (!hybridDictionary_0.Contains(userData))
				{
					return true;
				}
			}
			return false;
		}

		private void method_0(object A_0)
		{
			AsyncOperationProgressEventArgs e = A_0 as AsyncOperationProgressEventArgs;
			if (asyncOperationProgressEventHandler_0 != null)
			{
				asyncOperationProgressEventHandler_0(this, e);
			}
		}

		private void method_1(object A_0)
		{
			if (asyncOperationCompletedEventHandler_0 != null)
			{
				AsyncOperationCompletedEventArgs e = A_0 as AsyncOperationCompletedEventArgs;
				asyncOperationCompletedEventHandler_0(this, e);
			}
		}

		private void method_2(object A_0)
		{
			AsyncData asyncData = A_0 as AsyncData;
			AsyncOperation asyncOperation = asyncData.Operation;
			AsyncOperationCompletedEventArgs arg = new AsyncOperationCompletedEventArgs(asyncData);
			lock (hybridDictionary_0.SyncRoot)
			{
				if (!hybridDictionary_0.Contains(asyncData.UserData))
				{
					asyncOperation = null;
				}
				else
				{
					hybridDictionary_0.Remove(asyncOperation.UserSuppliedState);
				}
			}
			asyncOperation?.PostOperationCompleted(sendOrPostCallback_1, arg);
		}

		protected virtual void HandleResponseStream(AsyncData data, Stream responseStream, long contentLength)
		{
			HandleResponseStream(data, responseStream, contentLength, null);
		}

		protected virtual void HandleResponseStream(AsyncData data, Stream responseStream, long contentLength, IService service)
		{
			data.DataStream = method_3(data, responseStream, contentLength);
			IAsyncEntryData asyncEntryData = data as IAsyncEntryData;
			Service service2 = service as Service;
			if (asyncEntryData != null && service != null)
			{
				asyncEntryData.Entry = service2.method_20(data.DataStream, data.UriToUse);
			}
		}

		private MemoryStream method_3(AsyncData A_0, Stream A_1, long A_2)
		{
			if (A_1 == null)
			{
				return null;
			}
			MemoryStream memoryStream = new MemoryStream();
			byte[] buffer = new byte[4096];
			double num = 0.0;
			long num2 = 0L;
			int num3;
			while ((num3 = A_1.Read(buffer, 0, 4096)) > 0)
			{
				memoryStream.Write(buffer, 0, num3);
				if (A_0 != null && A_0.Delegate != null)
				{
					num2 += num3;
					if (A_2 > 4096L)
					{
						num = (double)num2 * 100.0 / (double)A_2;
					}
					if (CheckIfOperationIsCancelled(A_0.UserData))
					{
						throw new ArgumentException("Operation was cancelled");
					}
					AsyncOperationProgressEventArgs arg = new AsyncOperationProgressEventArgs(A_2, num2, (int)num, A_0.UriToUse, A_0.HttpVerb, A_0.UserData);
					A_0.Operation.Post(A_0.Delegate, arg);
				}
			}
			memoryStream.Seek(0L, SeekOrigin.Begin);
			return memoryStream;
		}

		internal bool method_4(AsyncData A_0, AsyncOperationProgressEventArgs A_1)
		{
			bool result;
			if (result = !CheckIfOperationIsCancelled(A_0.UserData))
			{
				A_0.Operation.Post(A_0.Delegate, A_1);
			}
			return result;
		}
	}
}
