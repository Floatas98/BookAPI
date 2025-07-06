using System.Text.Json.Serialization;

namespace BookApp.Components.Models
{
    public class Timestamp
    {
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("value")]
        public string? Value { get; set; }
    }
}
