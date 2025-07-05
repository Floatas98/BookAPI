using BookApp.Components.Models.Request;
using BookApp.Components.Models;
using System.Text.Json;
using BookApp.Components.Services.Interface;
using System.Reflection;

namespace BookApp.Components.Services
{
    public class OpenLibraryService
    {
        private readonly IHttpClientService _httpClientService;

        public OpenLibraryService(IHttpClientService httpClientService)
        {
            _httpClientService = httpClientService;
        }

        public async Task<List<Author>> SearchAuthors(string query)
        {
            var url = $"https://openlibrary.org/search/authors.json?q={query}";

            try
            {
                var response = await _httpClientService.GetAsync(url);

                if (!response.IsSuccessStatusCode) return new();

                string json = await response.Content.ReadAsStringAsync();
                var searchResult = JsonSerializer.Deserialize<AuthorSearchResult<Author>>(json);

                return searchResult?.Docs ?? new();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[{MethodBase.GetCurrentMethod()?.Name}] Error: {ex.Message}");
                return new();
            }
        }

        public async Task<List<Book>> GetBooksByAuthor(string authorKey)
        {
            if(string.IsNullOrEmpty(authorKey)) return new List<Book>();

            var url = $"https://openlibrary.org/search.json?author={authorKey}";
            try
            {
                var response = await _httpClientService.GetFromJsonAsync<AuthorSearchResult<Book>>(url);

                if (response?.Docs.Count == 0) return new();

                return response?.Docs!;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[{MethodBase.GetCurrentMethod()?.Name}] Error during search: {ex.Message}");
                return new();
            }
        }
    }
}
