namespace WeatherKitHelper.Model
{
    /// <summary>
    /// The official text describing a severe weather event from the agency.
    /// </summary>
    public class EventText
    {
        /// <summary>
        /// The ISO language code that the text is in.
        /// </summary>
        public string? Language { get; set; }

        /// <summary>
        /// The severe weather event text.
        /// </summary>
        public string? Text { get; set; }
    }
}