namespace WeatherKitHelper.Model
{
    /// <summary>
    /// A list of image asset URLs for attribution.
    /// </summary>
    public class Attribution
    {
        /// <summary>
        /// Attribution URLs of image assets are partial. Append the partial URL to https://weatherkit.apple.com to obtain the image asset.
        /// </summary>
        public static readonly string BasePath = "https://weatherkit.apple.com";

        /// <summary>
        /// The partial URL of the dark appearance of the Apple Weather logo with a scale factor of 1, or @1x.
        /// </summary>
        [JsonPropertyName("logoDark@1x")]
        public string LogoDark1x { get; set; } = string.Empty;

        /// <summary>
        /// The partial URL of the dark appearance of the Apple Weather logo with a scale factor of 2, or @2x.
        /// </summary>
        [JsonPropertyName("logoDark@2x")]
        public string LogoDark2x { get; set; } = string.Empty;

        /// <summary>
        /// The partial URL of the dark appearance of the Apple Weather logo with a scale factor of 3, or @3x.
        /// </summary>
        [JsonPropertyName("logoDark@3x")]
        public string LogoDark3x { get; set; } = string.Empty;

        /// <summary>
        /// The partial URL of the light appearance of the Apple Weather logo with a scale factor of 1, or @1x.
        /// </summary>
        [JsonPropertyName("logoLight@1x")]
        public string LogoLight1x { get; set; } = string.Empty;

        /// <summary>
        /// The partial URL of the light appearance of the Apple Weather logo with a scale factor of 2, or @2x.
        /// </summary>
        [JsonPropertyName("logoLight@2x")]
        public string LogoLight2x { get; set; } = string.Empty;

        /// <summary>
        /// The partial URL of the light appearance of the Apple Weather logo with a scale factor of 3, or @3x.
        /// </summary>
        [JsonPropertyName("logoLight@3x")]
        public string LogoLight3x { get; set; } = string.Empty;

        /// <summary>
        /// The partial URL of a square weather logo with a scale factor of 1, or @1x.
        /// </summary>
        [JsonPropertyName("logoSquare@1x")]
        public string LogoSquare1x { get; set; } = string.Empty;

        /// <summary>
        /// The partial URL of a square weather logo with a scale factor of 2, or @2x.
        /// </summary>
        [JsonPropertyName("logoSquare@2x")]
        public string LogoSquare2x { get; set; } = string.Empty;

        /// <summary>
        /// The partial URL of a square weather logo with a scale factor of 3, or @3x.
        /// </summary>
        [JsonPropertyName("logoSquare@3x")]
        public string LogoSquare3x { get; set; } = string.Empty;

        /// <summary>
        /// The name of the service.
        /// </summary>
        public string ServiceName { get; set; } = string.Empty;
    }
}
