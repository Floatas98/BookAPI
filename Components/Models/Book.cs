using System.Text.Json.Serialization;

namespace BookApp.Components.Models
{
    public class Book
    {
        [JsonPropertyName("key")]
        public string? Key { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("description")]
        public DescriptionWrapper? Description { get; set; }

        [JsonPropertyName("subjects")]
        public List<string>? Subjects { get; set; }

        [JsonPropertyName("first_publish_year")]
        public int? FirstPublishYear { get; set; }

        [JsonPropertyName("created")]
        public Timestamp? Created { get; set; }

        [JsonPropertyName("last_modified")]
        public Timestamp? LastModified { get; set; }
    }

    public class DescriptionWrapper
    {
        [JsonPropertyName("value")]
        public string? Value { get; set; }
    }

    public class Timestamp
    {
        [JsonPropertyName("value")]
        public DateTime? Value { get; set; }
    }
}
