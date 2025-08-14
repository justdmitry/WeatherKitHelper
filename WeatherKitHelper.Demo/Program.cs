using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Polly;
using WeatherKitHelper;
using WeatherKitHelper.Model;

var builder = Host.CreateApplicationBuilder();

var token = builder.Configuration["Token"];
if (string.IsNullOrEmpty(token))
{
    Console.WriteLine("Please add 'token' into appsettings config (use Util.TokenGenerator to create one).");
    return;
}

builder.Services
    .AddHttpClient<IWeatherKitClient, WeatherKitClient>()
    .ConfigureHttpClient(x => x.DefaultRequestHeaders.Authorization = new("Bearer", token))  // Add authorization header.
    .AddTransientHttpErrorPolicy(x => x.WaitAndRetryAsync(3, z => TimeSpan.FromSeconds(z))); // Retry 3 times: with 1, 2 and 3 sec delay.

var app = builder.Build();

var client = app.Services.GetRequiredService<IWeatherKitClient>();

// Venice / Venezia
var lat = 45.43386009532135;
var lng = 12.333644642374948;
var lang = "it";

var datasets = await client.GetAvailability(lat, lng, lang);

Console.WriteLine("Available datasets: {0}", string.Join(",", datasets));

var weather = await client.GetWeather(lang, lat, lng, [DataSet.CurrentWeather]);

Console.WriteLine(
    "Current weather is: {0}, Temperature {1:#}{2} (or {3:#}{4})",
    weather.CurrentWeather.GetWeatherCondition().GetText(),
    weather.CurrentWeather.Temperature,
    client.DegreeCelsius,
    client.ToFahrenheit(weather.CurrentWeather.Temperature),
    client.DegreeFahrenheit);