namespace Patrick_God.Services.WeatherForecastService;

public interface IWeatherForecastService
{
    IEnumerable<WeatherForecast> Get();
}