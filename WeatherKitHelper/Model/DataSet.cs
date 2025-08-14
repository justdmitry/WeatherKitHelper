namespace WeatherKitHelper.Model
{
    /// <summary>
    /// The collection of weather information for a location.
    /// </summary>
    public enum DataSet
    {
        /// <summary>
        /// The current weather for the requested location.
        /// </summary>
        CurrentWeather,

        /// <summary>
        /// The daily forecast for the requested location.
        /// </summary>
        ForecastDaily,

        /// <summary>
        /// The hourly forecast for the requested location.
        /// </summary>
        ForecastHourly,

        /// <summary>
        /// The next hour forecast for the requested location.
        /// </summary>
        ForecastNextHour,

        /// <summary>
        /// Weather alerts for the requested location.
        /// </summary>
        WeatherAlerts,
    }
}
