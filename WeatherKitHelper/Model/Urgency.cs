namespace WeatherKitHelper.Model
{
    /// <summary>
    /// An indication of urgency of action from the reporting agency.
    /// </summary>
    public enum Urgency
    {
        /// <summary>
        /// Take responsive action immediately.
        /// </summary>
        Immediate,

        /// <summary>
        /// Take responsive action in the next hour.
        /// </summary>
        Expected,

        /// <summary>
        /// Take responsive action in the near future.
        /// </summary>
        Future,

        /// <summary>
        /// Responsive action is no longer required.
        /// </summary>
        Past,

        /// <summary>
        /// The urgency is unknown.
        /// </summary>
        Unknown,
    }
}
