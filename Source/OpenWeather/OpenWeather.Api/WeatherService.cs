using Microsoft.Extensions.Caching.Memory;

namespace OpenWeather.Api;

internal sealed class WeatherService
{
    private readonly OpenWeatherService _weatherService;
    private readonly IMemoryCache _cache;

    internal WeatherService(OpenWeatherService weatherService, IMemoryCache cache)
    {
        _weatherService = weatherService;
        _cache = cache;
    }

    internal async Task<double> GetAverageTemperatureForLastFiveDaysAsync(double latitude, double longitude)
    {
        var weatherData = await _weatherService.GetWeatherDataForLastFiveDaysAsync(latitude, longitude);

        var cacheKey = $"WeatherData_{latitude}_{longitude}";

        if (_cache.TryGetValue(cacheKey, out double cachedTemperature))
        {
            return cachedTemperature;
        }

        var temperatures = weatherData?.Take(5 * 24).Select(h => h.Temperature) ?? Enumerable.Empty<double>();
        var averageTemperature = temperatures.Any() ? temperatures.Average() : 0;

        _cache.Set(cacheKey, averageTemperature, TimeSpan.FromHours(1));

        return 0;
    }
}
