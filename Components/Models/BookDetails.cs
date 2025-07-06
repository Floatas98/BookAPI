using System.Text.Json.Serialization;

namespace BookApp.Components.Models
{
    public class BookDetails
    {
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("subjects")]
        public List<string>? Subjects { get; set; }

        [JsonPropertyName("key")]
        public string? Key { get; set; }

        [JsonPropertyName("authors")]
        public List<AuthorReference>? Authors { get; set; }

        [JsonPropertyName("type")]
        public TypeReference? Type { get; set; }

        [JsonPropertyName("description")]
        [JsonConverter(typeof(DescriptionWrapperConverter))]
        public DescriptionWrapper? Description { get; set; }

        [JsonPropertyName("links")]
        public List<Link>? Links { get; set; }

        [JsonPropertyName("covers")]
        public List<int>? Covers { get; set; }

        [JsonPropertyName("subject_places")]
        public List<string>? SubjectPlaces { get; set; }

        [JsonPropertyName("subject_people")]
        public List<string>? SubjectPeople { get; set; }

        [JsonPropertyName("excerpts")]
        public List<Excerpt>? Excerpts { get; set; }

        [JsonPropertyName("first_publish_date")]
        public string? FirstPublishDate { get; set; }

        [JsonPropertyName("latest_revision")]
        public int? LatestRevision { get; set; }

        [JsonPropertyName("revision")]
        public int? Revision { get; set; }

        [JsonPropertyName("created")]
        public Timestamp? Created { get; set; }

        [JsonPropertyName("last_modified")]
        public Timestamp? LastModified { get; set; }
    }

    public class AuthorReference
    {
        [JsonPropertyName("author")]
        public EntityReference? Author { get; set; }

        [JsonPropertyName("type")]
        public TypeReference? Type { get; set; }
    }

    public class EntityReference
    {
        [JsonPropertyName("key")]
        public string? Key { get; set; }
    }

    public class TypeReference
    {
        [JsonPropertyName("key")]
        public string? Key { get; set; }
    }

    public class Link
    {
        [JsonPropertyName("url")]
        public string? Url { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("type")]
        public TypeReference? Type { get; set; }
    }

    public class Excerpt
    {
        [JsonPropertyName("author")]
        public EntityReference? Author { get; set; }

        [JsonPropertyName("comment")]
        public string? Comment { get; set; }

        [JsonPropertyName("excerpt")]
        public string? Text { get; set; }
    }
}
