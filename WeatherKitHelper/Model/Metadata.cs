namespace WeatherKitHelper.Model
{
    /// <summary>
    /// Descriptive information about the weather data.
    /// </summary>
    public class Metadata
    {
        /// <summary>
        /// The URL of the legal attribution for the data source.
        /// </summary>
        public string? AttributionURL { get; set; }

        /// <summary>
        /// The time when the weather data is no longer valid.
        /// </summary>
        public DateTimeOffset ExpireTime { get; set; }

        /// <summary>
        /// The ISO language code for localizable fields.
        /// </summary>
        public string? Language { get; set; }

        /// <summary>
        /// The latitude of the relevant location.
        /// </summary>
        public double Latitude { get; set; }

        /// <summary>
        /// The longitude of the relevant location.
        /// </summary>
        public double Longitude { get; set; }

        /// <summary>
        /// The URL of a logo for the data provider.
        /// </summary>
        public string? ProviderLogo { get; set; }

        /// <summary>
        /// The name of the data provider.
        /// </summary>
        public string? ProviderName { get; set; }

        /// <summary>
        /// The time the weather data was procured.
        /// </summary>
        public DateTimeOffset ReadTime { get; set; }

        /// <summary>
        /// The time the provider reported the weather data.
        /// </summary>
        public DateTimeOffset? ReportedTime { get; set; }

        /// <remarks>Value "modeled" have been seen there.</remarks>
        [Obsolete(ObsoleteReasons.Undocumented)]
        public string? SourceType { get; set; }

        /// <summary>
        /// The weather data is temporarily unavailable from the provider.
        /// </summary>
        public bool? TemporarilyUnavailable { get; set; }

        /// <summary>
        /// The system of units that the weather data is reported in. This is set to metric.
        /// </summary>
        public UnitsSystem? Units { get; set; }

        /// <summary>
        /// The data format version.
        /// </summary>
        public int Version { get; set; }
    }
}