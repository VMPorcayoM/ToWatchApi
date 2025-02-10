

using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[Controller]
[Route("api/[Controller]")]
public class StatusController(IMongoCollection<Status> statusCollection): ControllerBase
{
      private readonly IMongoCollection<Status> _statusCollection = statusCollection;
      [HttpGet]
      public async Task<IActionResult> GetAll()
      {
            var statusCollection = await _statusCollection.Find(status => true).ToListAsync();
            return Ok(statusCollection);
      }
}