using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class MovieSerie
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } // Mark as nullable
    [BsonElement("title")]
    public required string Title { get; set; } // Mark as nullable
    [BsonElement("date")]
    public string? Date { get; set; }
    [BsonElement("genres")]
    public ObjectId[]? Genres { get; set; } // Mark as nullable
    [BsonElement("platforms")]
    public ObjectId[]? Platforms { get; set; }
    [BsonElement("rotten_tomatoes_url")]
    public string? RottenTomatoesURL {get; set; }
    [BsonElement("status_id")]
    public ObjectId? Status { get; set; }
}