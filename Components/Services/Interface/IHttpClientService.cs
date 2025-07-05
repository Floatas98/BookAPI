namespace BookApp.Components.Services.Interface
{
    public interface IHttpClientService
    {
        public Task<HttpResponseMessage> GetAsync(string url);
        public Task<HttpResponseMessage> PostAsync(string url, HttpContent content);
        public Task<T?> GetFromJsonAsync<T>(string url);
    }
}
