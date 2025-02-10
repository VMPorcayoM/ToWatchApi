using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/[controller]")]
public class MoviesSeriesController(IMongoCollection<MovieSerie> moviesSeriesCollection) : ControllerBase
{
    private readonly IMongoCollection<MovieSerie> _moviesSeriesCollection = moviesSeriesCollection;

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var moviesSeries = await _moviesSeriesCollection.Find(libro => true).ToListAsync();
        return Ok(moviesSeries);
    }
}