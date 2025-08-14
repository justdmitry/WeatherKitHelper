namespace WeatherKitHelper.Model
{
    /// <summary>
    /// The summary for a specified period in the minute forecast.
    /// </summary>
    public class ForecastPeriodSummary
    {
        /// <summary>
        /// The type of precipitation forecasted.
        /// </summary>
        public PrecipitationType Condition { get; set; }

        /// <summary>
        /// The end time of the forecast.
        /// </summary>
        public DateTimeOffset? EndTime { get; set; }

        /// <summary>
        /// The probability of precipitation during this period.
        /// </summary>
        public double PrecipitationChance { get; set; }

        /// <summary>
        /// The precipitation intensity in millimeters per hour.
        /// </summary>
        public double PrecipitationIntensity { get; set; }

        /// <summary>
        /// The start time of the forecast.
        /// </summary>
        public DateTimeOffset StartTime { get; set; }
    }
}