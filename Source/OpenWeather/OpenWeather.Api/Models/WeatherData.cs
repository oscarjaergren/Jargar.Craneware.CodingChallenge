using System.Text.Json.Serialization;

namespace OpenWeather.Api;

internal sealed record WeatherData
{
    public DateTime Date { get; set; }

    public required double Temperature { get; set; }
}

[JsonSerializable(typeof(WeatherData))]
internal sealed partial class WeatherDataJsonSerializerContext : JsonSerializerContext
{
}