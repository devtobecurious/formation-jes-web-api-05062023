using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using TestConfig.Configs;
using static System.Console;
namespace TestConfig.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
    private readonly int nb = 0;

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(IHostEnvironment env,
        IConfiguration configuration,
        ILogger<WeatherForecastController> logger,
        IOptionsSnapshot<GameConfig> gameConfigOption)
    {
        _logger = logger;
        WriteLine("ma chaine : {0}", configuration["ConnectionStrings:MaConnectionString"]);
        var nbAsString = configuration["GameConfig:Enemies:Nb"];

        var gameConfig = gameConfigOption.Value;

        if (!string.IsNullOrEmpty(nbAsString))
        {
            this.nb = int.Parse(nbAsString);
        }
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, this.nb).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
