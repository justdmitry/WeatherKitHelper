namespace WeatherKitHelper.Model
{
    /// <summary>
    /// The level of danger to life and property.
    /// </summary>
    public enum Severity
    {
        /// <summary>
        /// Extraordinary threat.
        /// </summary>
        Extreme,

        /// <summary>
        /// Significant threat.
        /// </summary>
        Severe,

        /// <summary>
        /// Possible threat.
        /// </summary>
        Moderate,

        /// <summary>
        /// Minimal or no known threat.
        /// </summary>
        Minor,

        /// <summary>
        /// Unknown threat.
        /// </summary>
        Unknown,
    }
}