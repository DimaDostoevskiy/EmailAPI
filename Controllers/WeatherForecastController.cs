using Microsoft.AspNetCore.Mvc;

namespace EmailAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        var weatherForecast1 = new WeatherForecast(){
            Date = DateTime.Now.AddDays(Random.Shared.Next(1, 7)),
            TemperatureC = Random.Shared.Next(-20, 55),
            SummarysList = new string[] {
                Summaries[Random.Shared.Next(Summaries.Length)],
                Summaries[Random.Shared.Next(Summaries.Length)],
                Summaries[Random.Shared.Next(Summaries.Length)],
            }
        };
        var weatherForecast2 = new WeatherForecast(){
            Date = DateTime.Now.AddDays(Random.Shared.Next(1, 7)),
            TemperatureC = Random.Shared.Next(-20, 55),
            SummarysList = new string[] {
                Summaries[Random.Shared.Next(Summaries.Length)],
                Summaries[Random.Shared.Next(Summaries.Length)],
                Summaries[Random.Shared.Next(Summaries.Length)],
            }
        };
        var weatherForecast3 = new WeatherForecast(){
            Date = DateTime.Now.AddDays(Random.Shared.Next(1, 7)),
            TemperatureC = Random.Shared.Next(-20, 55),
            SummarysList = new string[] {
                Summaries[Random.Shared.Next(Summaries.Length)],
                Summaries[Random.Shared.Next(Summaries.Length)],
                Summaries[Random.Shared.Next(Summaries.Length)],
            }
        };

        var list = new List<WeatherForecast>();
        
        list.Add(weatherForecast1);
        list.Add(weatherForecast2);
        list.Add(weatherForecast3);

        return list.ToArray();
    }
}
