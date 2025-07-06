using System.Text.Json.Serialization;

namespace BookApp.Components.Models
{
    public class DescriptionWrapper
    {
        [JsonPropertyName("value")]
        public string? Value { get; set; }
    }
}
