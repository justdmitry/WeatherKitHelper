#pragma warning disable CS0618 // Type or member is obsolete

namespace WeatherKitHelper.Tests.Model
{
    using WeatherKitHelper.Model;

    public class CurrentWeatherTests
    {
        [Fact]
        public void TestCurrentWeather()
        {
            var weather = System.Text.Json.JsonSerializer.Deserialize<Weather>(Responses.CurrentWeatherResponse, WeatherKitClient.JsonOptions);

            Assert.NotNull(weather);

            var obj = weather.CurrentWeather;
            Assert.NotNull(obj);
            Assert.NotNull(obj.Metadata);
            Assert.Equal(new DateTimeOffset(2025, 8, 13, 10, 41, 1, TimeSpan.Zero), obj.AsOf);
            Assert.Equal(0.24, obj.CloudCover);
            Assert.Equal(0.01, obj.CloudCoverLowAltPct);
            Assert.Equal(0.05, obj.CloudCoverMidAltPct);
            Assert.Equal(0.29, obj.CloudCoverHighAltPct);
            Assert.Equal("MostlyClear", obj.ConditionCode);
            Assert.Equal(WeatherCondition.MostlyClear, obj.GetWeatherCondition());
            Assert.Equal(true, obj.Daylight);
            Assert.Equal(0.34, obj.Humidity);
            Assert.Equal(0.01, obj.PrecipitationIntensity);
            Assert.Equal(1014.16, obj.Pressure);
            Assert.Equal(PressureTrend.Steady, obj.PressureTrend);
            Assert.Equal(35.33, obj.Temperature);
            Assert.Equal(36.86, obj.TemperatureApparent);
            Assert.Equal(17.1, obj.TemperatureDewPoint);
            Assert.Equal(8, obj.UvIndex);
            Assert.Equal(30774.27, obj.Visibility);
            Assert.Equal(212, obj.WindDirection);
            Assert.Equal(18.92, obj.WindGust);
            Assert.Equal(6.62, obj.WindSpeed);
        }
    }
}
