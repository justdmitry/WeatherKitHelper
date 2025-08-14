namespace WeatherKitHelper.Model
{
    /// <summary>
    /// The shape of the moon as seen by an observer on the ground at a given time.
    /// </summary>
    public enum MoonPhase
    {
        /// <summary>
        /// The moon isn’t visible.
        /// </summary>
        New,

        /// <summary>
        /// A crescent-shaped sliver of the moon is visible, and increasing in size.
        /// </summary>
        WaxingCrescent,

        /// <summary>
        /// Approximately half of the moon is visible, and increasing in size.
        /// </summary>
        FirstQuarter,

        /// <summary>
        /// The entire disc of the moon is visible.
        /// </summary>
        Full,

        /// <summary>
        /// More than half of the moon is visible, and increasing in size.
        /// </summary>
        WaxingGibbous,

        /// <summary>
        /// More than half of the moon is visible, and decreasing in size.
        /// </summary>
        WaningGibbous,

        /// <summary>
        /// Approximately half of the moon is visible, and decreasing in size.
        /// </summary>
        ThirdQuarter,

        /// <summary>
        /// A crescent-shaped sliver of the moon is visible, and decreasing in size.
        /// </summary>
        WaningCrescent,
    }
}
