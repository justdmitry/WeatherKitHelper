namespace WeatherKitHelper.Model
{
    using System.Text.Json.Nodes;

    /// <summary>
    /// An official message indicating severe weather from a reporting agency.
    /// </summary>
    public class WeatherAlert : WeatherAlertSummary
    {
        /// <summary>
        /// An object defining the geographic region the weather alert applies to.
        /// </summary>
        public JsonNode? Area { get; set; }

        /// <summary>
        /// An array of official text messages describing a severe weather event from the agency.
        /// </summary>
        public List<EventText> Messages { get; set; } = [];
    }
}