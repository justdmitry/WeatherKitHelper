namespace WeatherKitHelper.Model
{
    /// <summary>
    /// The current weather conditions for the specified location.
    /// </summary>
    public class CurrentWeather : ProductData
    {
        /// <summary>
        /// The date and time.
        /// </summary>
        public DateTimeOffset AsOf { get; set; }

        /// <summary>
        /// The percentage of the sky covered with clouds during the period, from 0 to 1.
        /// </summary>
        public double? CloudCover { get; set; }

        /// <summary>
        /// The percentage of the sky covered with low-altitude clouds during the period.
        /// </summary>
        [Obsolete(ObsoleteReasons.Undocumented)]
        public double? CloudCoverLowAltPct { get; set; }

        /// <summary>
        /// The percentage of the sky covered with middle altitude clouds during the period.
        /// </summary>
        [Obsolete(ObsoleteReasons.Undocumented)]
        public double? CloudCoverMidAltPct { get; set; }

        /// <summary>
        /// The percentage of the sky covered with high-altitude clouds during the period.
        /// </summary>
        [Obsolete(ObsoleteReasons.Undocumented)]
        public double? CloudCoverHighAltPct { get; set; }

        /// <summary>
        /// An enumeration value indicating the condition at the time.
        /// </summary>
        public string ConditionCode { get; set; } = string.Empty;

        /// <summary>
        /// A Boolean value indicating whether there is daylight.
        /// </summary>
        public bool? Daylight { get; set; }

        /// <summary>
        /// The relative humidity, from 0 to 1.
        /// </summary>
        public double Humidity { get; set; }

        /// <summary>
        /// The precipitation intensity, in millimeters per hour.
        /// </summary>
        public double PrecipitationIntensity { get; set; }

        /// <summary>
        /// The sea level air pressure, in millibars.
        /// </summary>
        public double Pressure { get; set; }

        /// <summary>
        /// The direction of change of the sea-level air pressure.
        /// </summary>
        public PressureTrend PressureTrend { get; set; }

        /// <summary>
        /// The current temperature, in degrees Celsius.
        /// </summary>
        public double Temperature { get; set; }

        /// <summary>
        /// The feels-like temperature when factoring wind and humidity, in degrees Celsius.
        /// </summary>
        public double TemperatureApparent { get; set; }

        /// <summary>
        /// The temperature at which relative humidity is 100%, in Celsius.
        /// </summary>
        public double TemperatureDewPoint { get; set; }

        /// <summary>
        /// The level of ultraviolet radiation.
        /// </summary>
        public int UvIndex { get; set; }

        /// <summary>
        /// The distance at which terrain is visible, in meters.
        /// </summary>
        public double Visibility { get; set; }

        /// <summary>
        /// The direction of the wind, in degrees.
        /// </summary>
        public int? WindDirection { get; set; }

        /// <summary>
        /// The maximum wind gust speed, in kilometers per hour.
        /// </summary>
        public double? WindGust { get; set; }

        /// <summary>
        /// The wind speed, in kilometers per hour.
        /// </summary>
        public double WindSpeed { get; set; }
    }
}