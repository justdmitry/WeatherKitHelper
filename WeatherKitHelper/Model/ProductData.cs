namespace WeatherKitHelper.Model
{
    /// <summary>
    /// A base type for all weather data.
    /// </summary>
    public abstract class ProductData
    {
        /// <summary>
        /// Descriptive information about the weather data.
        /// </summary>
        public Metadata? Metadata { get; set; }
    }
}