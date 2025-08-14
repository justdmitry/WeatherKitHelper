namespace WeatherKitHelper.Model
{
    public enum PrecipitationType
    {
        /// <summary>
        /// No precipitation is occurring.
        /// </summary>
        Clear,

        /// <summary>
        /// An unknown type of precipitation is occuring.
        /// </summary>
        Precipitation,

        /// <summary>
        /// Rain or freezing rain is falling.
        /// </summary>
        Rain,

        /// <summary>
        /// Snow is falling.
        /// </summary>
        Snow,

        /// <summary>
        /// Sleet or ice pellets are falling.
        /// </summary>
        Sleet,

        /// <summary>
        /// Hail is falling.
        /// </summary>
        Hail,

        /// <summary>
        /// Winter weather (wintery mix or wintery showers) is falling.
        /// </summary>
        Mixed,
    }
}