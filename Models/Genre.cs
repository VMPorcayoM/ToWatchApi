using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;
using MongoDB.Bson;

public interface IGenre{
      public ObjectId Id { get; set; }
      public string Name {get; set;}

}