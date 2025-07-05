using System.Text.Json.Serialization;

namespace BookApp.Components.Models.Request
{
    public class AuthorSearchResult<TResult> where TResult : class
    {
        [JsonPropertyName("numFound")]
        public int NumFound { get; set; }

        [JsonPropertyName("start")]
        public int Start { get; set; }

        [JsonPropertyName("numFoundExact")]
        public bool NumFoundExact { get; set; }

        [JsonPropertyName("docs")]
        public List<TResult> Docs { get; set; } = new();
    }
}
