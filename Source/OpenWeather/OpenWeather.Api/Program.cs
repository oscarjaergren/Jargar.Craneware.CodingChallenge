using OpenWeather.Api;

var builder = WebApplication.CreateSlimBuilder(args);

builder.Services.ConfigureHttpJsonOptions(options => options.SerializerOptions.TypeInfoResolverChain.Insert(0, WeatherDataJsonSerializerContext.Default));
builder.Services.AddHttpClient();
builder.Services.AddScoped<OpenWeatherService>();
builder.Services.AddMemoryCache();
builder.Configuration.AddUserSecrets<Program>();

var app = builder.Build();

//Area of improvement, if more endpoints were to be created this would be split up into modules
app.MapGet("/api/average-temperature/{latitude}/{longitude}", async (double latitude, double longitude, WeatherService weatherService) =>
{
     var averageTemperate = await weatherService.GetAverageTemperatureForLastFiveDaysAsync(latitude, longitude);
     return Results.Ok(new { AverageTemperature = averageTemperate });
});

app.Run();
