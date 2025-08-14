namespace WeatherKitHelper.Model
{
    /// <summary>
    /// A summary forecast for a daytime or overnight period.
    /// </summary>
    public class DayPartForecast
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
        /// The ending date and time of the forecast.
        /// </summary>
        public DateTimeOffset ForecastEnd { get; set; }

        /// <summary>
        /// The starting date and time of the forecast.
        /// </summary>
        public DateTimeOffset ForecastStart { get; set; }

        /// <summary>
        /// The relative humidity during the period, from 0 to 1.
        /// </summary>
        public double Humidity { get; set; }

        /// <summary>
        /// The amount of precipitation forecasted to occur during the period, in millimeters.
        /// </summary>
        public double PrecipitationAmount { get; set; }

        /// <summary>
        /// The chance of precipitation forecasted to occur during the period.
        /// </summary>
        public double PrecipitationChance { get; set; }

        /// <summary>
        /// The type of precipitation forecasted to occur during the period.
        /// </summary>
        public PrecipitationType PrecipitationType { get; set; }

        /// <summary>
        /// The depth of snow as ice crystals forecasted to occur during the period, in millimeters.
        /// </summary>
        public double SnowfallAmount { get; set; }

        [Obsolete(ObsoleteReasons.Undocumented)]
        public double TemperatureMax { get; set; }

        [Obsolete(ObsoleteReasons.Undocumented)]
        public double TemperatureMin { get; set; }

        [Obsolete(ObsoleteReasons.Undocumented)]
        public double WindGustSpeedMax { get; set; }

        [Obsolete(ObsoleteReasons.Undocumented)]
        public double WindSpeedAvg { get; set; }

        [Obsolete(ObsoleteReasons.Undocumented)]
        public double WindSpeedMax { get; set; }

        /// <summary>
        /// The direction the wind is forecasted to come from during the period, in degrees.
        /// </summary>
        public int? WindDirection { get; set; }

        /// <summary>
        /// The average speed the wind is forecasted to be during the period, in kilometers per hour.
        /// </summary>
        public double WindSpeed { get; set; }
    }
}