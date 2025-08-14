namespace WeatherKitHelper.Model
{
    /// <summary>
    /// The precipitation forecast for a specified minute.
    /// </summary>
    public class ForecastMinute
    {
        /// <summary>
        /// The probability of precipitation during this minute.
        /// </summary>
        public double PrecipitationChance { get; set; }

        /// <summary>
        /// The precipitation intensity in millimeters per hour.
        /// </summary>
        public double PrecipitationIntensity { get; set; }

        /// <summary>
        /// The start time of the minute.
        /// </summary>
        public DateTimeOffset StartTime { get; set; }
    }
}