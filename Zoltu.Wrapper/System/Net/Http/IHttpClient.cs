using System;
using System.Diagnostics.Contracts;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace Zoltu.Wrapper.SystemWrapper.Net.Http
{
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
			get { return _httpClient.DefaultRequestHeaders; }
		}

		public long MaxResponseContentBufferSize
		{
			get
			{
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
				return _httpClient.Timeout;
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
			return _httpClient.DeleteAsync(requestUri);
		}

		public Task<HttpResponseMessage> DeleteAsync(String requestUri)
		{
			return _httpClient.DeleteAsync(requestUri);
		}

		public Task<HttpResponseMessage> DeleteAsync(Uri requestUri, CancellationToken cancellationToken)
		{
			return _httpClient.DeleteAsync(requestUri, cancellationToken);
		}

		public Task<HttpResponseMessage> DeleteAsync(String requestUri, CancellationToken cancellationToken)
		{
			return _httpClient.DeleteAsync(requestUri, cancellationToken);
		}

		public Task<HttpResponseMessage> GetAsync(Uri requestUri)
		{
			return _httpClient.GetAsync(requestUri);
		}

		public Task<HttpResponseMessage> GetAsync(String requestUri)
		{
			return _httpClient.GetAsync(requestUri);
		}

		public Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption)
		{
			return _httpClient.GetAsync(requestUri, completionOption);
		}

		public Task<HttpResponseMessage> GetAsync(Uri requestUri, CancellationToken cancellationToken)
		{
			return _httpClient.GetAsync(requestUri, cancellationToken);
		}

		public Task<HttpResponseMessage> GetAsync(String requestUri, CancellationToken cancellationToken)
		{
			return _httpClient.GetAsync(requestUri, cancellationToken);
		}

		public Task<HttpResponseMessage> GetAsync(String requestUri, HttpCompletionOption completionOption)
		{
			return _httpClient.GetAsync(requestUri, completionOption);
		}

		public Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
		{
			return _httpClient.GetAsync(requestUri, completionOption, cancellationToken);
		}

		public Task<HttpResponseMessage> GetAsync(String requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
		{
			return _httpClient.GetAsync(requestUri, completionOption, cancellationToken);
		}

		public Task<Byte[]> GetByteArrayAsync(Uri requestUri)
		{
			return _httpClient.GetByteArrayAsync(requestUri);
		}

		public Task<Byte[]> GetByteArrayAsync(String requestUri)
		{
			return _httpClient.GetByteArrayAsync(requestUri);
		}

		public Task<Stream> GetStreamAsync(Uri requestUri)
		{
			return _httpClient.GetStreamAsync(requestUri);
		}

		public Task<Stream> GetStreamAsync(String requestUri)
		{
			return _httpClient.GetStreamAsync(requestUri);
		}

		public Task<String> GetStringAsync(Uri requestUri)
		{
			return _httpClient.GetStringAsync(requestUri);
		}

		public Task<String> GetStringAsync(String requestUri)
		{
			return _httpClient.GetStringAsync(requestUri);
		}

		public Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content)
		{
			return _httpClient.PostAsync(requestUri, content);
		}

		public Task<HttpResponseMessage> PostAsync(String requestUri, HttpContent content)
		{
			return _httpClient.PostAsync(requestUri, content);
		}

		public Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			return _httpClient.PostAsync(requestUri, content, cancellationToken);
		}

		public Task<HttpResponseMessage> PostAsync(String requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			return _httpClient.PostAsync(requestUri, content, cancellationToken);
		}

		public Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content)
		{
			return _httpClient.PutAsync(requestUri, content);
		}

		public Task<HttpResponseMessage> PutAsync(String requestUri, HttpContent content)
		{
			return _httpClient.PutAsync(requestUri, content);
		}

		public Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			return _httpClient.PutAsync(requestUri, content, cancellationToken);
		}

		public Task<HttpResponseMessage> PutAsync(String requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			return _httpClient.PutAsync(requestUri, content, cancellationToken);
		}

		public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
		{
			return _httpClient.SendAsync(request);
		}

		public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption)
		{
			return _httpClient.SendAsync(request, completionOption);
		}

		public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			return _httpClient.SendAsync(request, cancellationToken);
		}

		public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken)
		{
			return _httpClient.SendAsync(request, completionOption, cancellationToken);
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
