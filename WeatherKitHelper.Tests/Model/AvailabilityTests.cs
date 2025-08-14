namespace WeatherKitHelper.Tests.Model
{
    public class AvailabilityTests
    {
        [Fact]
        public void Test()
        {
            var json = $@"[""currentWeather"",""forecastDaily"",""forecastHourly""]";

            var obj = System.Text.Json.JsonSerializer.Deserialize<DataSet[]>(json, WeatherKitClient.JsonOptions);

            Assert.NotNull(obj);
            Assert.NotEmpty(obj);
            Assert.Contains(DataSet.CurrentWeather, obj);
            Assert.Contains(DataSet.ForecastDaily, obj);
            Assert.Contains(DataSet.ForecastHourly, obj);
            Assert.DoesNotContain(DataSet.ForecastNextHour, obj);
            Assert.DoesNotContain(DataSet.WeatherAlerts, obj);
        }
    }
}
