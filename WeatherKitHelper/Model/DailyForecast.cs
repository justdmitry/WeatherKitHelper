namespace WeatherKitHelper.Model
{
    /// <summary>
    /// The daily forecast information.
    /// </summary>
    public class DailyForecast : ProductData
    {
        /// <summary>
        /// An array of the day forecast weather conditions.
        /// </summary>
        public List<DayWeatherConditions> Days { get; set; } = [];

        /// <summary>
        /// A URL that provides more information about the forecast.
        /// </summary>
        public string? LearnMoreURL { get; set; }
    }
}
