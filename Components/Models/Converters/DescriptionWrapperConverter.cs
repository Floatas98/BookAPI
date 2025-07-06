using System.Text.Json.Serialization;
using System.Text.Json;

namespace BookApp.Components.Models;

public class DescriptionWrapperConverter
    : JsonConverter<DescriptionWrapper?>
{
    public override DescriptionWrapper? Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String)
        {
            var text = reader.GetString();
            return new DescriptionWrapper { Value = text };
        }
        else if (reader.TokenType == JsonTokenType.StartObject)
        {
            using var doc = JsonDocument.ParseValue(ref reader);
            if (doc.RootElement.TryGetProperty("value", out var valElem))
            {
                return new DescriptionWrapper { Value = valElem.GetString() };
            }
        }

        return null;
    }

    public override void Write(
        Utf8JsonWriter writer,
        DescriptionWrapper? value,
        JsonSerializerOptions options)
    {
        if (value?.Value != null)
        {
            writer.WriteStartObject();
            writer.WriteString("value", value.Value);
            writer.WriteEndObject();
        }
        else
        {
            writer.WriteNullValue();
        }
    }
}