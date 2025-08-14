namespace WeatherKitHelper.Model
{
    /// <summary>
    /// The direction of change of the sea level air pressure.
    /// </summary>
    public enum PressureTrend
    {
        /// <summary>
        /// The sea level air pressure is increasing.
        /// </summary>
        Rising,

        /// <summary>
        /// The sea level air pressure is decreasing.
        /// </summary>
        Falling,

        /// <summary>
        /// The sea level air pressure is remaining about the same.
        /// </summary>
        Steady,
    }
}
