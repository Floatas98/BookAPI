using BookApp.Components.Services.Interface;

namespace BookApp.Components.Services
{
    public class HttpClientService : IHttpClientService
    {
        private readonly HttpClient _httpClient;

        public HttpClientService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> GetAsync(string url)
        {
            return await _httpClient.GetAsync(url);
 
        }

        public async Task<HttpResponseMessage> PostAsync(string url, HttpContent content)
        {
            return await _httpClient.PostAsync(url, content);
        }

        public async Task<T?> GetFromJsonAsync<T>(string url)
        {
            return await _httpClient.GetFromJsonAsync<T>(url);
        }
    }
}
