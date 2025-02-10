using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Genre{
      [BsonId]
      [BsonRepresentation(BsonType.ObjectId)]
      public ObjectId Id { get; set; }
      [BsonElement("name")]
      public required string Name {get; set;}

}