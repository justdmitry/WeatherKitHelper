namespace WeatherKitHelper.Model
{
    /// <summary>
    /// The next hour forecast information.
    /// </summary>
    public class NextHourForecast : ProductData
    {
        /// <summary>
        /// The time the forecast ends.
        /// </summary>
        public DateTimeOffset? ForecastEnd { get; set; }

        /// <summary>
        /// The time the forecast starts.
        /// </summary>
        public DateTimeOffset? ForecastStart { get; set; }

        /// <summary>
        /// An array of the forecast minutes.
        /// </summary>
        public List<ForecastMinute> Minutes { get; set; } = [];

        /// <summary>
        /// An array of the forecast summaries.
        /// </summary>
        public List<ForecastPeriodSummary> Summary { get; set; } = [];
    }
}