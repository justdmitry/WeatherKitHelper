namespace WeatherKitHelper.Model
{
    /// <summary>
    /// A collecton of weather alerts.
    /// </summary>
    public class WeatherAlertCollection : ProductData
    {
        /// <summary>
        /// An array of weather alert summaries.
        /// </summary>
        public List<WeatherAlertSummary> Alerts { get; set; } = new();

        /// <summary>
        /// A URL that provides more information about the alerts.
        /// </summary>
        public string? DetailsURL { get; set; }
    }
}
