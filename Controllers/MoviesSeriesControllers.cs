using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;

[ApiController]
[Route("api/[controller]")]
public class MoviesSeriesController : ControllerBase
{
      private readonly IMongoCollection<IMovieSerie> _moviesSeries;
      
}