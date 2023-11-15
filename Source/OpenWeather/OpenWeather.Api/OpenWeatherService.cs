namespace OpenWeather.Api;

internal sealed class OpenWeatherService(IHttpClientFactory httpClientFactory, IConfiguration configuration)
{
    private readonly IHttpClientFactory _httpClientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));
    private readonly string _openWeatherApiKey = configuration["OpenWeatherApiKey"] ?? throw new InvalidOperationException("OpenWeatherApiKey not found in configuration.");

    internal async Task<List<WeatherData>> GetWeatherDataForLastFiveDaysAsync(double latitude, double longitude)
    {
        List<WeatherData> weatherData = [];

        for (int i = 0; i < 5; i++)
        {
            var requestDay = DateTime.Now.AddDays(-i);
            DateTimeOffset dateTimeOffset = new(requestDay);
            long unixTimestamp = dateTimeOffset.ToUnixTimeSeconds();

            var apiUrl = $"https://api.openweathermap.org/data/2.5/onecall/timemachine?lat={latitude}&lon={longitude}&dt={unixTimestamp}&appid={_openWeatherApiKey}";
            using var client = _httpClientFactory.CreateClient();
            var responseData = await client.GetFromJsonAsync(apiUrl, WeatherDataJsonSerializerContext.Default.WeatherData);

            if (responseData != null)
            {
                weatherData.Add(responseData);
            }
        }

        return weatherData;
    }
}
