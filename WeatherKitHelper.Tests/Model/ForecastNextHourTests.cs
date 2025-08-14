namespace WeatherKitHelper.Tests.Model
{
    public class ForecastNextHourTests
    {
        [Fact]
        public void TestForecastDaily()
        {
            var weather = System.Text.Json.JsonSerializer.Deserialize<Weather>(Responses.ForecastNextHourResponse, WeatherKitClient.JsonOptions);

            Assert.NotNull(weather);

            var obj = weather.ForecastNextHour;
            Assert.NotNull(obj);
            Assert.NotNull(obj.Metadata);

            Assert.Equal(new DateTimeOffset(2025, 8, 13, 11, 21, 0, TimeSpan.Zero), obj.ForecastStart);
            Assert.Equal(new DateTimeOffset(2025, 8, 13, 12, 44, 0, TimeSpan.Zero), obj.ForecastEnd);

            Assert.Equal(83, obj.Minutes.Count);
            var minute = obj.Minutes[0];
            Assert.NotNull(minute);
            Assert.Equal(0.01, minute.PrecipitationChance);
            Assert.Equal(0.02, minute.PrecipitationIntensity);
            Assert.Equal(new DateTimeOffset(2025, 8, 13, 11, 21, 0, TimeSpan.Zero), minute.StartTime);

            Assert.Single(obj.Summary);
            var summary = obj.Summary[0];
            Assert.NotNull(summary);
            Assert.Equal(PrecipitationType.Clear, summary.Condition);
            Assert.Equal(0.01, summary.PrecipitationChance);
            Assert.Equal(0.02, summary.PrecipitationIntensity);
            Assert.Equal(new DateTimeOffset(2025, 8, 13, 11, 21, 0, TimeSpan.Zero), summary.StartTime);
        }
    }
}
