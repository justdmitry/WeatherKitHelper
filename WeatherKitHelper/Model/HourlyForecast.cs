namespace WeatherKitHelper.Model
{
    /// <summary>
    /// The hourly forecast information.
    /// </summary>
    public class HourlyForecast : ProductData
    {
        /// <summary>
        /// An array of hourly forecasts.
        /// </summary>
        public List<HourWeatherConditions> Hours { get; set; } = [];
    }
}