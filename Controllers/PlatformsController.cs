using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[Controller]
[Route("api/[Controller]")]
public class PlatformsController(IMongoCollection<Platform> platformsColletion) : ControllerBase
{
      private readonly IMongoCollection<Platform> _platformsCollection = platformsColletion;
      [HttpGet]
      public async Task<IActionResult> GetAll()
      {
            var platformsColletion = await _platformsCollection.Find(platform => true).ToListAsync();
            return Ok(platformsColletion);
      }
}