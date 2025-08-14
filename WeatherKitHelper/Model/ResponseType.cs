namespace WeatherKitHelper.Model
{
    /// <summary>
    /// The recommended action from a reporting agency.
    /// </summary>
    public enum ResponseType
    {
        /// <summary>
        /// Take shelter in place.
        /// </summary>
        Shelter,

        /// <summary>
        /// Relocate.
        /// </summary>
        Evacuate,

        /// <summary>
        /// Make preparations.
        /// </summary>
        Prepare,

        /// <summary>
        /// Execute a pre-planned activity.
        /// </summary>
        Execute,

        /// <summary>
        /// Avoid the event.
        /// </summary>
        Avoid,

        /// <summary>
        /// Monitor the situation.
        /// </summary>
        Monitor,

        /// <summary>
        /// Assess the situation.
        /// </summary>
        Assess,

        /// <summary>
        /// The event no longer poses a threat.
        /// </summary>
        AllClear,

        /// <summary>
        /// No action recommended.
        /// </summary>
        None,
    }
}