namespace WeatherKitHelper.Model
{
    /// <summary>
    /// Detailed information about the weather alert.
    /// </summary>
    public class WeatherAlertSummary
    {
        /// <summary>
        /// An official designation of the affected area.
        /// </summary>
        public string? AreaId { get; set; }

        /// <summary>
        /// A human-readable name of the affected area.
        /// </summary>
        public string? AreaName { get; set; }

        /// <summary>
        /// How likely the event is to occur.
        /// </summary>
        public Certainty Certainty { get; set; }

        /// <summary>
        /// The ISO code of the reporting country.
        /// </summary>
        public string CountryCode { get; set; } = string.Empty;

        /// <summary>
        /// A human-readable description of the event.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// The URL to a page containing detailed information about the event.
        /// </summary>
        public string? DetailsUrl { get; set; }

        /// <summary>
        /// The time the event went into effect.
        /// </summary>
        public DateTimeOffset EffectiveTime { get; set; }

        /// <summary>
        /// The time when the underlying weather event is projected to end.
        /// </summary>
        public DateTimeOffset? EventEndTime { get; set; }

        /// <summary>
        /// The time when the underlying weather event is projected to start.
        /// </summary>
        public DateTimeOffset? EventOnsetTime { get; set; }

        /// <summary>
        /// The time when the event expires.
        /// </summary>
        public DateTimeOffset ExpireTime { get; set; }

        /// <summary>
        /// A unique identifier of the event.
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// The time that event was issued by the reporting agency.
        /// </summary>
        public DateTimeOffset IssuedTime { get; set; }

        /// <summary>
        /// An array of recommended actions from the reporting agency.
        /// </summary>
        public List<ResponseType> Responses { get; set; } = [];

        /// <summary>
        /// The level of danger to life and property.
        /// </summary>
        public Severity Severity { get; set; }

        /// <summary>
        /// The name of the reporting agency.
        /// </summary>
        public string Source { get; set; } = string.Empty;

        /// <summary>
        /// An indication of urgency of action from the reporting agency.
        /// </summary>
        public Urgency? Urgency { get; set; }
    }
}