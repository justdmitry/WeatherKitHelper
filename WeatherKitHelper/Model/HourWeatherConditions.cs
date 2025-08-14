namespace WeatherKitHelper.Model
{
    /// <summary>
    /// The historical or forecasted weather conditions for a specified hour.
    /// </summary>
    public class HourWeatherConditions
    {
        /// <summary>
        /// The percentage of the sky covered with clouds during the period, from 0 to 1.
        /// </summary>
        public double CloudCover { get; set; }

        /// <summary>
        /// An enumeration value indicating the condition at the time.
        /// </summary>
        public string ConditionCode { get; set; } = string.Empty;

        /// <summary>
        /// Indicates whether the hour starts during the day or night.
        /// </summary>
        public bool? Daylight { get; set; }

        /// <summary>
        /// The starting date and time of the forecast.
        /// </summary>
        public DateTimeOffset ForecastStart { get; set; }

        /// <summary>
        /// The relative humidity at the start of the hour, from 0 to 1.
        /// </summary>
        public double Humidity { get; set; }

        /// <summary>
        /// The amount of precipitation forecasted to occur during period, in millimeters.
        /// </summary>
        public double? PrecipitationAmount { get; set; }

        /// <summary>
        /// The chance of precipitation forecasted to occur during the hour, from 0 to 1.
        /// </summary>
        public double PrecipitationChance { get; set; }

        /// <summary>
        /// The type of precipitation forecasted to occur during the period.
        /// </summary>
        public PrecipitationType PrecipitationType { get; set; }

        /// <summary>
        /// The sea-level air pressure, in millibars.
        /// </summary>
        public double Pressure { get; set; }

        /// <summary>
        /// The direction of change of the sea-level air pressure.
        /// </summary>
        public PressureTrend? PressureTrend { get; set; }

        [Obsolete(ObsoleteReasons.Undocumented)]
        public double? SnowfallAmount { get; set; }

        /// <summary>
        /// The rate at which snow crystals are falling, in millimeters per hour.
        /// </summary>
        public double? SnowfallIntensity { get; set; }

        /// <summary>
        /// The temperature at the start of the hour, in degrees Celsius.
        /// </summary>
        public double Temperature { get; set; }

        /// <summary>
        /// The feels-like temperature when considering wind and humidity, at the start of the hour, in degrees Celsius.
        /// </summary>
        public double TemperatureApparent { get; set; }

        /// <summary>
        /// The temperature at which relative humidity is 100% at the top of the hour, in degrees Celsius.
        /// </summary>
        public double TemperatureDewPoint { get; set; }

        /// <summary>
        /// The level of ultraviolet radiation at the start of the hour.
        /// </summary>
        public int UvIndex { get; set; }

        /// <summary>
        /// The distance at which terrain is visible at the start of the hour, in meters.
        /// </summary>
        public double Visibility { get; set; }

        /// <summary>
        /// The direction of the wind at the start of the hour, in degrees.
        /// </summary>
        public int? WindDirection { get; set; }

        /// <summary>
        /// The maximum wind gust speed during the hour, in kilometers per hour.
        /// </summary>
        public double? WindGust { get; set; }

        /// <summary>
        /// The wind speed at the start of the hour, in kilometers per hour.
        /// </summary>
        public double WindSpeed { get; set; }
    }
}