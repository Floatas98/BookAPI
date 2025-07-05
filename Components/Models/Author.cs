using System.Text.Json.Serialization;

namespace BookApp.Components.Models
{
    public class Author
    {
        [JsonPropertyName("key")]
        public string? Key { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}
