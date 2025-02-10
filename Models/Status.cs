using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Status
{
      [BsonId]
      [BsonRepresentation(BsonType.ObjectId)]
      public string Id { get; set; }
      [BsonElement("name")]
      public required string Name { get; set; }
}