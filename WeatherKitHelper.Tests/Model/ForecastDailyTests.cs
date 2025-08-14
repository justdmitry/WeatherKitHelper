#pragma warning disable CS0618 // Type or member is obsolete

namespace WeatherKitHelper.Tests.Model
{
    using WeatherKitHelper.Model;

    public class ForecastDailyTests
    {
        [Fact]
        public void TestForecastDaily()
        {
            var weather = System.Text.Json.JsonSerializer.Deserialize<Weather>(Responses.ForecastDailyResponse, WeatherKitClient.JsonOptions);

            Assert.NotNull(weather);

            var obj = weather.ForecastDaily;
            Assert.NotNull(obj);
            Assert.NotNull(obj.Metadata);
            Assert.Equal(10, obj.Days.Count);

            var day = obj.Days[0];
            Assert.NotNull(day);
            Assert.Equal("MostlyClear", day.ConditionCode);
            Assert.Equal(WeatherCondition.MostlyClear, day.GetWeatherCondition());
            Assert.Equal(new DateTimeOffset(2025, 8, 12, 22, 0, 0, TimeSpan.Zero), day.ForecastStart);
            Assert.Equal(new DateTimeOffset(2025, 8, 13, 22, 0, 0, TimeSpan.Zero), day.ForecastEnd);
            Assert.Equal(8, day.MaxUvIndex);
            Assert.Equal(MoonPhase.WaningGibbous, day.MoonPhase);
            Assert.Equal(new DateTimeOffset(2025, 8, 13, 20, 12, 37, TimeSpan.Zero), day.Moonrise);
            Assert.Equal(new DateTimeOffset(2025, 8, 13, 08, 52, 21, TimeSpan.Zero), day.Moonset);
            Assert.Equal(0.1, day.PrecipitationAmount);
            Assert.Equal(0.01, day.PrecipitationChance);
            Assert.Equal(PrecipitationType.Clear, day.PrecipitationType);
            Assert.Equal(0.1, day.SnowfallAmount);
            Assert.Equal(new DateTimeOffset(2025, 8, 12, 23, 15, 23, TimeSpan.Zero), day.SolarMidnight);
            Assert.Equal(new DateTimeOffset(2025, 8, 13, 11, 14, 57, TimeSpan.Zero), day.SolarNoon);
            Assert.Equal(new DateTimeOffset(2025, 8, 13, 04, 16, 23, TimeSpan.Zero), day.Sunrise);
            Assert.Equal(new DateTimeOffset(2025, 8, 13, 02, 29, 16, TimeSpan.Zero), day.SunriseAstronomical);
            Assert.Equal(new DateTimeOffset(2025, 8, 13, 03, 46, 13, TimeSpan.Zero), day.SunriseCivil);
            Assert.Equal(new DateTimeOffset(2025, 8, 13, 03, 09, 11, TimeSpan.Zero), day.SunriseNautical);
            Assert.Equal(new DateTimeOffset(2025, 8, 13, 18, 13, 13, TimeSpan.Zero), day.Sunset);
            Assert.Equal(new DateTimeOffset(2025, 8, 13, 19, 59, 54, TimeSpan.Zero), day.SunsetAstronomical);
            Assert.Equal(new DateTimeOffset(2025, 8, 13, 18, 43, 23, TimeSpan.Zero), day.SunsetCivil);
            Assert.Equal(new DateTimeOffset(2025, 8, 13, 19, 20, 11, TimeSpan.Zero), day.SunsetNautical);
            Assert.Equal(36.09, day.TemperatureMax);
            Assert.Equal(23.44, day.TemperatureMin);
            Assert.Equal(32.85, day.WindGustSpeedMax);
            Assert.Equal(7.1, day.WindSpeedAvg);
            Assert.Equal(16.53, day.WindSpeedMax);

            var df = day.DaytimeForecast;
            Assert.NotNull(df);
            Assert.Equal(0.28, df.CloudCover);
            Assert.Equal("MostlyClear", df.ConditionCode);
            Assert.Equal(WeatherCondition.MostlyClear, df.GetWeatherCondition());
            Assert.Equal(new DateTimeOffset(2025, 8, 13, 5, 0, 0, TimeSpan.Zero), df.ForecastStart);
            Assert.Equal(new DateTimeOffset(2025, 8, 13, 17, 0, 0, TimeSpan.Zero), df.ForecastEnd);
            Assert.Equal(0.42, df.Humidity);
            Assert.Equal(0.1, df.PrecipitationAmount);
            Assert.Equal(0.1, df.PrecipitationChance);
            Assert.Equal(PrecipitationType.Clear, df.PrecipitationType);
            Assert.Equal(0, df.SnowfallAmount);
            Assert.Equal(36.09, df.TemperatureMax);
            Assert.Equal(23.49, df.TemperatureMin);
            Assert.Equal(258, df.WindDirection);
            Assert.Equal(32.85, df.WindGustSpeedMax);
            Assert.Equal(8.68, df.WindSpeed);
            Assert.Equal(16.53, df.WindSpeedMax);

            var of = day.OvernightForecast;
            Assert.NotNull(of);
            Assert.Equal(0.61, of.CloudCover);
            Assert.Equal("PartlyCloudy", of.ConditionCode);
            Assert.Equal(WeatherCondition.PartlyCloudy, of.GetWeatherCondition());
            Assert.Equal(new DateTimeOffset(2025, 8, 13, 17, 0, 0, TimeSpan.Zero), of.ForecastStart);
            Assert.Equal(new DateTimeOffset(2025, 8, 14, 05, 0, 0, TimeSpan.Zero), of.ForecastEnd);
            Assert.Equal(0.59, of.Humidity);
            Assert.Equal(0, of.PrecipitationAmount);
            Assert.Equal(0, of.PrecipitationChance);
            Assert.Equal(PrecipitationType.Clear, of.PrecipitationType);
            Assert.Equal(0, of.SnowfallAmount);
            Assert.Equal(32.8, of.TemperatureMax);
            Assert.Equal(23.46, of.TemperatureMin);
            Assert.Equal(359, of.WindDirection);
            Assert.Equal(24.23, of.WindGustSpeedMax);
            Assert.Equal(5.06, of.WindSpeed);
            Assert.Equal(9.86, of.WindSpeedMax);

            var rf = day.RestOfDayForecast;
            Assert.NotNull(rf);
            Assert.Equal(0.34, rf.CloudCover);
            Assert.Equal("MostlyClear", rf.ConditionCode);
            Assert.Equal(WeatherCondition.MostlyClear, rf.GetWeatherCondition());
            Assert.Equal(new DateTimeOffset(2025, 8, 13, 10, 38, 0, TimeSpan.Zero), rf.ForecastStart);
            Assert.Equal(new DateTimeOffset(2025, 8, 13, 22, 0, 0, TimeSpan.Zero), rf.ForecastEnd);
            Assert.Equal(0.42, rf.Humidity);
            Assert.Equal(0, rf.PrecipitationAmount);
            Assert.Equal(0, rf.PrecipitationChance);
            Assert.Equal(PrecipitationType.Clear, rf.PrecipitationType);
            Assert.Equal(0, rf.SnowfallAmount);
            Assert.Equal(36.09, rf.TemperatureMax);
            Assert.Equal(26.5, rf.TemperatureMin);
            Assert.Equal(258, rf.WindDirection);
            Assert.Equal(32.85, rf.WindGustSpeedMax);
            Assert.Equal(8.62, rf.WindSpeed);
            Assert.Equal(16.53, rf.WindSpeedMax);
        }
    }
}
