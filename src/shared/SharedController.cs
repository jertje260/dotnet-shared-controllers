using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace shared;

[ApiController]
[Route("[controller]")]
public class SharedController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<SharedController> _logger;

    public SharedController(ILogger<SharedController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetSharedWeatherForecast")]
    public IEnumerable<SharedWeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new SharedWeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
