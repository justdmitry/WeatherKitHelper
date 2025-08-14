#pragma warning disable CS0618 // Type or member is obsolete

namespace WeatherKitHelper.Tests.Model
{
    using WeatherKitHelper.Model;

    public class ForecastHourlyTests
    {
        [Fact]
        public void TestForecastDaily()
        {
            var weather = System.Text.Json.JsonSerializer.Deserialize<Weather>(Responses.ForecastHourlyResponse, WeatherKitClient.JsonOptions);

            Assert.NotNull(weather);

            var obj = weather.ForecastHourly;
            Assert.NotNull(obj);
            Assert.NotNull(obj.Metadata);
            Assert.Equal(25, obj.Hours.Count);

            var hour = obj.Hours[0];
            Assert.NotNull(hour);
            Assert.Equal(0.21, hour.CloudCover);
            Assert.Equal("MostlyClear", hour.ConditionCode);
            Assert.Equal(WeatherCondition.MostlyClear, hour.GetWeatherCondition());
            Assert.Equal(true, hour.Daylight);
            Assert.Equal(new DateTimeOffset(2025, 8, 13, 11, 0, 0, TimeSpan.Zero), hour.ForecastStart);
            Assert.Equal(0.33, hour.Humidity);
            Assert.Equal(0, hour.PrecipitationAmount);
            Assert.Equal(0, hour.PrecipitationChance);
            Assert.Equal(PrecipitationType.Clear, hour.PrecipitationType);
            Assert.Equal(1014.05, hour.Pressure);
            Assert.Equal(PressureTrend.Steady, hour.PressureTrend);
            Assert.Equal(0, hour.SnowfallAmount);
            Assert.Equal(0, hour.SnowfallIntensity);
            Assert.Equal(35.65, hour.Temperature);
            Assert.Equal(37.11, hour.TemperatureApparent);
            Assert.Equal(16.9, hour.TemperatureDewPoint);
            Assert.Equal(8, hour.UvIndex);
            Assert.Equal(30758, hour.Visibility);
            Assert.Equal(216, hour.WindDirection);
            Assert.Equal(20.54, hour.WindGust);
            Assert.Equal(7.97, hour.WindSpeed);
        }
    }
}
