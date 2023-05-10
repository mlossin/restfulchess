using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace RestfullChess.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private LinkGenerator _linkGenerator;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, LinkGenerator linkGenerator)
        {
            _logger = logger;
            _linkGenerator = linkGenerator;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get()
        {
            var reuslt = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
            return Ok(reuslt);
        }
    }
}