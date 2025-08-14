namespace WeatherKitHelper.Model
{
    /// <summary>
    /// The system of units that the weather data is reported in.
    /// </summary>
    public enum UnitsSystem
    {
        /// <summary>
        /// The metric system.
        /// </summary>
        [JsonStringEnumMemberName("m")]
        Metric,
    }
}