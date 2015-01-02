using System;
using System.Diagnostics.Contracts;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace Zoltu.Wrapper.SystemWrapper.Net.Http
{
	[ContractClass(typeof(IHttpClientContract))]
	public interface IHttpClient : IDisposable
	{
		Uri BaseAddress { get; set; }
		HttpRequestHeaders DefaultRequestHeaders { get; }
		Int64 MaxResponseContentBufferSize { get; set; }
		TimeSpan Timeout { get; set; }

		void CancelPendingRequests();
		Task<HttpResponseMessage> DeleteAsync(Uri requestUri);
		Task<HttpResponseMessage> DeleteAsync(String requestUri);
		Task<HttpResponseMessage> DeleteAsync(Uri requestUri, CancellationToken cancellationToken);
		Task<HttpResponseMessage> DeleteAsync(String requestUri, CancellationToken cancellationToken);
		Task<HttpResponseMessage> GetAsync(Uri requestUri);
		Task<HttpResponseMessage> GetAsync(String requestUri);
		Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption);
		Task<HttpResponseMessage> GetAsync(Uri requestUri, CancellationToken cancellationToken);
		Task<HttpResponseMessage> GetAsync(String requestUri, CancellationToken cancellationToken);
		Task<HttpResponseMessage> GetAsync(String requestUri, HttpCompletionOption completionOption);
		Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken);
		Task<HttpResponseMessage> GetAsync(String requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken);
		Task<Byte[]> GetByteArrayAsync(Uri requestUri);
		Task<Byte[]> GetByteArrayAsync(String requestUri);
		Task<Stream> GetStreamAsync(Uri requestUri);
		Task<Stream> GetStreamAsync(String requestUri);
		Task<String> GetStringAsync(Uri requestUri);
		Task<String> GetStringAsync(String requestUri);
		Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content);
		Task<HttpResponseMessage> PostAsync(String requestUri, HttpContent content);
		Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken);
		Task<HttpResponseMessage> PostAsync(String requestUri, HttpContent content, CancellationToken cancellationToken);
		Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content);
		Task<HttpResponseMessage> PutAsync(String requestUri, HttpContent content);
		Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken);
		Task<HttpResponseMessage> PutAsync(String requestUri, HttpContent content, CancellationToken cancellationToken);
		Task<HttpResponseMessage> SendAsync(HttpRequestMessage request);
		Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption);
		Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);
		Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken);
	}

	[ContractClassFor(typeof(IHttpClient))]
	abstract class IHttpClientContract : IHttpClient
	{
		public abstract Uri BaseAddress { get; set; }
		public HttpRequestHeaders DefaultRequestHeaders
		{
			get
			{
				Contract.Ensures(Contract.Result<HttpRequestHeaders>() != null);
				return default(HttpRequestHeaders);
			}
		}
		public Int64 MaxResponseContentBufferSize
		{
			get
			{
				Contract.Ensures(Contract.Result<Int64>() > 0);
				return default(Int64);
			}
			set
			{
				Contract.Requires(value > 0);
			}
		}
		public TimeSpan Timeout
		{
			get
			{
				// FIXME: This should be (result >= TimeSpan.Zero || result == infinite) but a bug in Code Contracts is causing validation of that to fail
				Contract.Ensures(Contract.Result<TimeSpan>() >= System.Threading.Timeout.InfiniteTimeSpan);
				return default(TimeSpan);
			}
			set
			{
				Contract.Requires(value > TimeSpan.Zero || value == System.Threading.Timeout.InfiniteTimeSpan);
			}
		}

		public abstract void CancelPendingRequests();

		public Task<HttpResponseMessage> DeleteAsync(String requestUri)
		{
			Contract.Requires(requestUri != null || BaseAddress != null);
			Contract.Ensures(Contract.Result<Task<HttpResponseMessage>>() != null);
			return null;
		}

		public Task<HttpResponseMessage> DeleteAsync(Uri requestUri)
		{
			Contract.Requires((requestUri != null && (requestUri.IsAbsoluteUri || BaseAddress != null)) || BaseAddress != null);
			Contract.Ensures(Contract.Result<Task<HttpResponseMessage>>() != null);
			return null;
		}

		public Task<HttpResponseMessage> DeleteAsync(String requestUri, CancellationToken cancellationToken)
		{
			Contract.Requires(requestUri != null || BaseAddress != null);
			Contract.Ensures(Contract.Result<Task<HttpResponseMessage>>() != null);
			return null;
		}

		public Task<HttpResponseMessage> DeleteAsync(Uri requestUri, CancellationToken cancellationToken)
		{
			Contract.Requires((requestUri != null && (requestUri.IsAbsoluteUri || BaseAddress != null)) || BaseAddress != null);
			Contract.Ensures(Contract.Result<Task<HttpResponseMessage>>() != null);
			return null;
		}

		public abstract void Dispose();

		public Task<HttpResponseMessage> GetAsync(String requestUri)
		{
			Contract.Requires(requestUri != null || BaseAddress != null);
			Contract.Ensures(Contract.Result<Task<HttpResponseMessage>>() != null);
			return null;
		}

		public Task<HttpResponseMessage> GetAsync(Uri requestUri)
		{
			Contract.Requires((requestUri != null && (requestUri.IsAbsoluteUri || BaseAddress != null)) || BaseAddress != null);
			Contract.Ensures(Contract.Result<Task<HttpResponseMessage>>() != null);
			return null;
		}

		public Task<HttpResponseMessage> GetAsync(String requestUri, CancellationToken cancellationToken)
		{
			Contract.Requires(requestUri != null || BaseAddress != null);
			Contract.Ensures(Contract.Result<Task<HttpResponseMessage>>() != null);
			return null;
		}

		public Task<HttpResponseMessage> GetAsync(String requestUri, HttpCompletionOption completionOption)
		{
			Contract.Requires(requestUri != null || BaseAddress != null);
			Contract.Ensures(Contract.Result<Task<HttpResponseMessage>>() != null);
			return null;
		}

		public Task<HttpResponseMessage> GetAsync(Uri requestUri, CancellationToken cancellationToken)
		{
			Contract.Requires((requestUri != null && (requestUri.IsAbsoluteUri || BaseAddress != null)) || BaseAddress != null);
			Contract.Ensures(Contract.Result<Task<HttpResponseMessage>>() != null);
			return null;
		}

		public Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption)
		{
			Contract.Requires((requestUri != null && (requestUri.IsAbsoluteUri || BaseAddress != null)) || BaseAddress != null);
			Contract.Ensures(Contract.Result<Task<HttpResponseMessage>>() != null);
			return null;
		}

		public Task<HttpResponseMessage> GetAsync(String requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
		{
			Contract.Requires(requestUri != null || BaseAddress != null);
			Contract.Ensures(Contract.Result<Task<HttpResponseMessage>>() != null);
			return null;
		}

		public Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
		{
			Contract.Requires((requestUri != null && (requestUri.IsAbsoluteUri || BaseAddress != null)) || BaseAddress != null);
			Contract.Ensures(Contract.Result<Task<HttpResponseMessage>>() != null);
			return null;
		}

		public Task<Byte[]> GetByteArrayAsync(String requestUri)
		{
			Contract.Requires(requestUri != null || BaseAddress != null);
			Contract.Ensures(Contract.Result<Task<Byte[]>>() != null);
			return null;
		}

		public Task<Byte[]> GetByteArrayAsync(Uri requestUri)
		{
			Contract.Requires((requestUri != null && (requestUri.IsAbsoluteUri || BaseAddress != null)) || BaseAddress != null);
			Contract.Ensures(Contract.Result<Task<Byte[]>>() != null);
			return null;
		}

		public Task<Stream> GetStreamAsync(String requestUri)
		{
			Contract.Requires(requestUri != null || BaseAddress != null);
			Contract.Ensures(Contract.Result<Task<Stream>>() != null);
			return null;
		}

		public Task<Stream> GetStreamAsync(Uri requestUri)
		{
			Contract.Requires((requestUri != null && (requestUri.IsAbsoluteUri || BaseAddress != null)) || BaseAddress != null);
			Contract.Ensures(Contract.Result<Task<Stream>>() != null);
			return null;
		}

		public Task<String> GetStringAsync(String requestUri)
		{
			Contract.Requires(requestUri != null || BaseAddress != null);
			Contract.Ensures(Contract.Result<Task<String>>() != null);
			return null;
		}

		public Task<String> GetStringAsync(Uri requestUri)
		{
			Contract.Requires((requestUri != null && (requestUri.IsAbsoluteUri || BaseAddress != null)) || BaseAddress != null);
			Contract.Ensures(Contract.Result<Task<String>>() != null);
			return null;
		}

		public Task<HttpResponseMessage> PostAsync(String requestUri, HttpContent content)
		{
			Contract.Requires(requestUri != null || BaseAddress != null);
			Contract.Ensures(Contract.Result<Task<HttpResponseMessage>>() != null);
			return null;
		}

		public Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content)
		{
			Contract.Requires((requestUri != null && (requestUri.IsAbsoluteUri || BaseAddress != null)) || BaseAddress != null);
			Contract.Ensures(Contract.Result<Task<HttpResponseMessage>>() != null);
			return null;
		}

		public Task<HttpResponseMessage> PostAsync(String requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			Contract.Requires(requestUri != null || BaseAddress != null);
			Contract.Ensures(Contract.Result<Task<HttpResponseMessage>>() != null);
			return null;
		}

		public Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			Contract.Requires((requestUri != null && (requestUri.IsAbsoluteUri || BaseAddress != null)) || BaseAddress != null);
			Contract.Ensures(Contract.Result<Task<HttpResponseMessage>>() != null);
			return null;
		}

		public Task<HttpResponseMessage> PutAsync(String requestUri, HttpContent content)
		{
			Contract.Requires(requestUri != null || BaseAddress != null);
			Contract.Ensures(Contract.Result<Task<HttpResponseMessage>>() != null);
			return null;
		}

		public Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content)
		{
			Contract.Requires((requestUri != null && (requestUri.IsAbsoluteUri || BaseAddress != null)) || BaseAddress != null);
			Contract.Ensures(Contract.Result<Task<HttpResponseMessage>>() != null);
			return null;
		}

		public Task<HttpResponseMessage> PutAsync(String requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			Contract.Requires(requestUri != null || BaseAddress != null);
			Contract.Ensures(Contract.Result<Task<HttpResponseMessage>>() != null);
			return null;
		}

		public Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			Contract.Requires((requestUri != null && (requestUri.IsAbsoluteUri || BaseAddress != null)) || BaseAddress != null);
			Contract.Ensures(Contract.Result<Task<HttpResponseMessage>>() != null);
			return null;
		}

		public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
		{
			Contract.Requires(request != null);
			Contract.Requires((request.RequestUri != null && (request.RequestUri.IsAbsoluteUri || BaseAddress != null)) || BaseAddress != null);
			Contract.Ensures(Contract.Result<Task<HttpResponseMessage>>() != null);
			return null;
		}

		public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			Contract.Requires(request != null);
			Contract.Requires((request.RequestUri != null && (request.RequestUri.IsAbsoluteUri || BaseAddress != null)) || BaseAddress != null);
			Contract.Ensures(Contract.Result<Task<HttpResponseMessage>>() != null);
			return null;
		}

		public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption)
		{
			Contract.Requires(request != null);
			Contract.Requires((request.RequestUri != null && (request.RequestUri.IsAbsoluteUri || BaseAddress != null)) || BaseAddress != null);
			Contract.Ensures(Contract.Result<Task<HttpResponseMessage>>() != null);
			return null;
		}

		public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken)
		{
			Contract.Requires(request != null);
			Contract.Requires((request.RequestUri != null && (request.RequestUri.IsAbsoluteUri || BaseAddress != null)) || BaseAddress != null);
			Contract.Ensures(Contract.Result<Task<HttpResponseMessage>>() != null);
			return null;
		}
	}

	public static class IHttpClientExtensions
	{
		public static IHttpClient Wrap(this HttpClient httpClient)
		{
			Contract.Requires(httpClient != null);
			Contract.Ensures(Contract.Result<IHttpClient>() != null);

			return new HttpClientWrapper(httpClient);
		}
	}

	public class HttpClientWrapper : IHttpClient
	{
		private readonly HttpClient _httpClient;

		public Uri BaseAddress
		{
			get
			{
				return _httpClient.BaseAddress;
			}
			set
			{
				_httpClient.BaseAddress = value;
			}
		}

		public HttpRequestHeaders DefaultRequestHeaders
		{
			get
			{
				var defaultRequestHeaders = _httpClient.DefaultRequestHeaders;
				Contract.Assume(defaultRequestHeaders != null);
				return defaultRequestHeaders;
			}
		}

		public Int64 MaxResponseContentBufferSize
		{
			get
			{
				Contract.Assume(_httpClient.MaxResponseContentBufferSize > 0);
				return _httpClient.MaxResponseContentBufferSize;
			}
			set
			{
				_httpClient.MaxResponseContentBufferSize = value;
			}
		}

		public TimeSpan Timeout
		{
			get
			{
				var timeout = _httpClient.Timeout;
				Contract.Assume(timeout >= System.Threading.Timeout.InfiniteTimeSpan);
				return timeout;
			}
			set
			{
				_httpClient.Timeout = value;
			}
		}

		public void CancelPendingRequests()
		{
			_httpClient.CancelPendingRequests();
		}

		public Task<HttpResponseMessage> DeleteAsync(Uri requestUri)
		{
			var task = _httpClient.DeleteAsync(requestUri);
			Contract.Assume(task != null);
			return task;
		}

		public Task<HttpResponseMessage> DeleteAsync(String requestUri)
		{
			var task = _httpClient.DeleteAsync(requestUri);
			Contract.Assume(task != null);
			return task;
		}

		public Task<HttpResponseMessage> DeleteAsync(Uri requestUri, CancellationToken cancellationToken)
		{
			var task = _httpClient.DeleteAsync(requestUri, cancellationToken);
			Contract.Assume(task != null);
			return task;
		}

		public Task<HttpResponseMessage> DeleteAsync(String requestUri, CancellationToken cancellationToken)
		{
			var task = _httpClient.DeleteAsync(requestUri, cancellationToken);
			Contract.Assume(task != null);
			return task;
		}

		public Task<HttpResponseMessage> GetAsync(Uri requestUri)
		{
			var task = _httpClient.GetAsync(requestUri);
			Contract.Assume(task != null);
			return task;
		}

		public Task<HttpResponseMessage> GetAsync(String requestUri)
		{
			var task = _httpClient.GetAsync(requestUri);
			Contract.Assume(task != null);
			return task;
		}

		public Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption)
		{
			var task = _httpClient.GetAsync(requestUri, completionOption);
			Contract.Assume(task != null);
			return task;
		}

		public Task<HttpResponseMessage> GetAsync(Uri requestUri, CancellationToken cancellationToken)
		{
			var task = _httpClient.GetAsync(requestUri, cancellationToken);
			Contract.Assume(task != null);
			return task;
		}

		public Task<HttpResponseMessage> GetAsync(String requestUri, CancellationToken cancellationToken)
		{
			var task = _httpClient.GetAsync(requestUri, cancellationToken);
			Contract.Assume(task != null);
			return task;
		}

		public Task<HttpResponseMessage> GetAsync(String requestUri, HttpCompletionOption completionOption)
		{
			var task = _httpClient.GetAsync(requestUri, completionOption);
			Contract.Assume(task != null);
			return task;
		}

		public Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
		{
			var task = _httpClient.GetAsync(requestUri, completionOption, cancellationToken);
			Contract.Assume(task != null);
			return task;
		}

		public Task<HttpResponseMessage> GetAsync(String requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
		{
			var task = _httpClient.GetAsync(requestUri, completionOption, cancellationToken);
			Contract.Assume(task != null);
			return task;
		}

		public Task<Byte[]> GetByteArrayAsync(Uri requestUri)
		{
			var task = _httpClient.GetByteArrayAsync(requestUri);
			Contract.Assume(task != null);
			return task;
		}

		public Task<Byte[]> GetByteArrayAsync(String requestUri)
		{
			var task = _httpClient.GetByteArrayAsync(requestUri);
			Contract.Assume(task != null);
			return task;
		}

		public Task<Stream> GetStreamAsync(Uri requestUri)
		{
			var task = _httpClient.GetStreamAsync(requestUri);
			Contract.Assume(task != null);
			return task;
		}

		public Task<Stream> GetStreamAsync(String requestUri)
		{
			var task = _httpClient.GetStreamAsync(requestUri);
			Contract.Assume(task != null);
			return task;
		}

		public Task<String> GetStringAsync(Uri requestUri)
		{
			var task = _httpClient.GetStringAsync(requestUri);
			Contract.Assume(task != null);
			return task;
		}

		public Task<String> GetStringAsync(String requestUri)
		{
			var task = _httpClient.GetStringAsync(requestUri);
			Contract.Assume(task != null);
			return task;
		}

		public Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content)
		{
			var task = _httpClient.PostAsync(requestUri, content);
			Contract.Assume(task != null);
			return task;
		}

		public Task<HttpResponseMessage> PostAsync(String requestUri, HttpContent content)
		{
			var task = _httpClient.PostAsync(requestUri, content);
			Contract.Assume(task != null);
			return task;
		}

		public Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			var task = _httpClient.PostAsync(requestUri, content, cancellationToken);
			Contract.Assume(task != null);
			return task;
		}

		public Task<HttpResponseMessage> PostAsync(String requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			var task = _httpClient.PostAsync(requestUri, content, cancellationToken);
			Contract.Assume(task != null);
			return task;
		}

		public Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content)
		{
			var task = _httpClient.PutAsync(requestUri, content);
			Contract.Assume(task != null);
			return task;
		}

		public Task<HttpResponseMessage> PutAsync(String requestUri, HttpContent content)
		{
			var task = _httpClient.PutAsync(requestUri, content);
			Contract.Assume(task != null);
			return task;
		}

		public Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			var task = _httpClient.PutAsync(requestUri, content, cancellationToken);
			Contract.Assume(task != null);
			return task;
		}

		public Task<HttpResponseMessage> PutAsync(String requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			var task = _httpClient.PutAsync(requestUri, content, cancellationToken);
			Contract.Assume(task != null);
			return task;
		}

		public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
		{
			var task = _httpClient.SendAsync(request);
			Contract.Assume(task != null);
			return task;
		}

		public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption)
		{
			var task = _httpClient.SendAsync(request, completionOption);
			Contract.Assume(task != null);
			return task;
		}

		public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			var task = _httpClient.SendAsync(request, cancellationToken);
			Contract.Assume(task != null);
			return task;
		}

		public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken)
		{
			var task = _httpClient.SendAsync(request, completionOption, cancellationToken);
			Contract.Assume(task != null);
			return task;
		}

		public HttpClientWrapper(HttpClient httpClient)
		{
			Contract.Requires(httpClient != null);

			_httpClient = httpClient;
		}

		public void Dispose()
		{
			_httpClient.Dispose();
		}

		[ContractInvariantMethod]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Justification = "Required for code contracts.")]
		private void ObjectInvariant()
		{
			Contract.Invariant(_httpClient != null);
		}
	}
}
