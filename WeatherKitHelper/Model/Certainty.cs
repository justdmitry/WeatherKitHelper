namespace WeatherKitHelper.Model
{
    /// <summary>
    /// How likely the event is to occur.
    /// </summary>
    public enum Certainty
    {
        /// <summary>
        /// The event has already occurred or is ongoing.
        /// </summary>
        Observed,

        /// <summary>
        /// The event is likely to occur (greater than 50% probability).
        /// </summary>
        Likely,

        /// <summary>
        ///     The event is unlikley to occur (less than 50% probability).
        /// </summary>
        Possible,

        /// <summary>
        /// The event is not expected to occur (approximately 0% probability).
        /// </summary>
        Unlikely,

        /// <summary>
        /// It is unknown if the event will occur.
        /// </summary>
        Unknown,
    }
}
