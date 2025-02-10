using MongoDB.Bson;

public interface IMovieSerie
{
    public ObjectId Id { get; set; } // Mark as nullable
    public string Title { get; set; } // Mark as nullable
    public string? Date { get; set; }
    public ObjectId[]? Genres { get; set; } // Mark as nullable
    public ObjectId[]? Platforms { get; set; }
    public string? RottenTomatoesURL {get; set; }
    public ObjectId? Status { get; set; }
}