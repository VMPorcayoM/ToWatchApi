using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[Controller]
[Route("api/[Controller]")]
public class GenresController(IMongoCollection<Genre> genresCollection) : ControllerBase
{
      private readonly IMongoCollection<Genre> _genresCollection = genresCollection;
      [HttpGet]
      public async Task<IActionResult> GetAll()
      {
            var genresCollection = await _genresCollection.Find(genre => true).ToListAsync();
            return Ok(genresCollection);
      }
}