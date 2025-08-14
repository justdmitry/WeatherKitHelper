namespace WeatherKitHelper
{
    public interface IWeatherKitClient
    {
        string DegreeCelsius => "°C";

        string DegreeFahrenheit => "°F";

        double ToFahrenheit(double celsius) => (celsius * 1.8) + 32;

        /// <summary>
        /// Determine the data sets available for the specified location.
        /// </summary>
        /// <param name="latitude">The latitude of the desired location (from -90 to +90).</param>
        /// <param name="longitude">The longitude of the desired location (from -180 to +180).</param>
        /// <param name="country">The ISO Alpha-2 country code for the requested location. This parameter is necessary for air quality and weather alerts.</param>
        /// <returns>Available data sets.</returns>
        Task<DataSet[]> GetAvailability(double latitude, double longitude, string country);

        /// <summary>
        /// Obtain weather data for the specified location.
        /// </summary>
        /// <param name="language">The language tag to use for localizing responses.</param>
        /// <param name="latitude">The latitude of the desired location (from -90 to +90).</param>
        /// <param name="longitude">The longitude of the desired location (from -180 to +180).</param>
        /// <param name="datasets">List of data sets to include in the response.</param>
        /// <param name="countryCode">The ISO Alpha-2 country code for the requested location. This parameter is necessary for weather alerts.</param>
        /// <param name="currentAsOf">The time to obtain current conditions (defaults to now).</param>
        /// <param name="dailyStart">The time to start the daily forecast (default is current day).</param>
        /// <param name="dailyEnd">The time to end the daily forecast (default is 10 days).</param>
        /// <param name="hourlyStart">The time to start the hourly forecast (default is current hour).</param>
        /// <param name="hourlyEnd">The time to end the hourly forecast (default is 24 hours or the length of the daily forecast, whichever is longer).</param>
        /// <param name="timezone">The name of the timezone to use for rolling up weather forecasts into daily forecasts (values like 'UTC+02:00' are fine).</param>
        /// <returns>Weather data.</returns>
        Task<Weather> GetWeather(
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
            string? timezone = null);

        /// <summary>
        /// Receive an active weather alert.
        /// </summary>
        /// <param name="language">The language tag to use for localizing responses.</param>
        /// <param name="id">The unique identifier for the weather alert.</param>
        /// <returns>The weather alert.</returns>
        Task<WeatherAlert> GetWeatherAlert(string language, string id);

        /// <summary>
        /// Receive attribution information.
        /// </summary>
        /// <param name="language">The language tag to use for localizing responses.</param>
        /// <returns>The attribution information.</returns>
        Task<Attribution> GetAttribution(string language);
    }
}
