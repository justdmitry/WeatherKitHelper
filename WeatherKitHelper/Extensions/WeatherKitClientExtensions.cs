namespace WeatherKitHelper
{
    public static class WeatherKitClientExtensions
    {
        /// <inheritdoc cref="IWeatherKitClient.GetWeather"/>
        public static Task<Weather> GetWeather(
            this IWeatherKitClient client,
            string language,
            double latitude,
            double longitude,
            DataSet[] datasets,
            string? countryCode = null,
            DateTimeOffset? currentAsOf = null,
            DateTimeOffset? dailyStart = null,
            DateTimeOffset? dailyEnd = null,
            DateTimeOffset? hourlyStart = null,
            DateTimeOffset? hourlyEnd = null,
            TimeSpan? timezone = null)
        {
            return client.GetWeather(language, latitude, longitude, datasets, countryCode, currentAsOf, dailyStart, dailyEnd, hourlyStart, hourlyEnd, FormatTimezone(timezone));
        }

        /// <inheritdoc cref="IWeatherKitClient.GetWeather"/>
        public static Task<Weather> GetWeather(
            this IWeatherKitClient client,
            string language,
            double latitude,
            double longitude,
            DataSet dataset,
            string? countryCode = null,
            DateTimeOffset? currentAsOf = null,
            DateTimeOffset? dailyStart = null,
            DateTimeOffset? dailyEnd = null,
            DateTimeOffset? hourlyStart = null,
            DateTimeOffset? hourlyEnd = null,
            TimeSpan? timezone = null)
        {
            return client.GetWeather(language, latitude, longitude, [dataset], countryCode, currentAsOf, dailyStart, dailyEnd, hourlyStart, hourlyEnd, FormatTimezone(timezone));
        }

        private static string? FormatTimezone(TimeSpan? value)
        {
            return value == null
                ? null
                : "UTC" + (value.Value < TimeSpan.Zero ? "-" : "+") + value.Value.ToString(@"hh\:mm");
        }
    }
}
