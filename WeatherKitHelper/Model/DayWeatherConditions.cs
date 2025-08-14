namespace WeatherKitHelper.Model
{
    /// <summary>
    /// The historical or forecasted weather conditions for a specified day.
    /// </summary>
    public class DayWeatherConditions
    {
        /// <summary>
        /// An enumeration value indicating the condition at the time.
        /// </summary>
        public string ConditionCode { get; set; } = string.Empty;

        /// <summary>
        /// The forecast between 7 AM and 7 PM for the day.
        /// </summary>
        public DayPartForecast? DaytimeForecast { get; set; }

        /// <summary>
        /// The ending date and time of the day.
        /// </summary>
        public DateTimeOffset ForecastEnd { get; set; }

        /// <summary>
        /// The starting date and time of the day.
        /// </summary>
        public DateTimeOffset ForecastStart { get; set; }

        /// <summary>
        /// The maximum ultraviolet index value during the day.
        /// </summary>
        public int MaxUvIndex { get; set; }

        /// <summary>
        /// The phase of the moon on the specified day.
        /// </summary>
        public MoonPhase MoonPhase { get; set; }

        /// <summary>
        /// The time of moonrise on the specified day.
        /// </summary>
        public DateTimeOffset? Moonrise { get; set; }

        /// <summary>
        /// The time of moonset on the specified day.
        /// </summary>
        public DateTimeOffset? Moonset { get; set; }

        /// <summary>
        /// The day part forecast between 7 PM and 7 AM for the overnight.
        /// </summary>
        public DayPartForecast? OvernightForecast { get; set; }

        /// <summary>
        /// The amount of precipitation forecasted to occur during the day, in millimeters.
        /// </summary>
        public double PrecipitationAmount { get; set; }

        /// <summary>
        /// The chance of precipitation forecasted to occur during the day.
        /// </summary>
        public double PrecipitationChance { get; set; }

        /// <summary>
        /// The type of precipitation forecasted to occur during the day.
        /// </summary>
        public PrecipitationType PrecipitationType { get; set; }

        [Obsolete(ObsoleteReasons.Undocumented)]
        public DayPartForecast? RestOfDayForecast { get; set; }

        /// <summary>
        /// The depth of snow as ice crystals forecasted to occur during the day, in millimeters.
        /// </summary>
        public double SnowfallAmount { get; set; }

        /// <summary>
        /// The time when the sun is lowest in the sky.
        /// </summary>
        public DateTimeOffset? SolarMidnight { get; set; }

        /// <summary>
        /// The time when the sun is highest in the sky.
        /// </summary>
        public DateTimeOffset? SolarNoon { get; set; }

        /// <summary>
        /// The time when the top edge of the sun reaches the horizon in the morning.
        /// </summary>
        public DateTimeOffset? Sunrise { get; set; }

        /// <summary>
        /// The time when the sun is 18 degrees below the horizon in the morning.
        /// </summary>
        public DateTimeOffset? SunriseAstronomical { get; set; }

        /// <summary>
        /// The time when the sun is 6 degrees below the horizon in the morning.
        /// </summary>
        public DateTimeOffset? SunriseCivil { get; set; }

        /// <summary>
        /// The time when the sun is 12 degrees below the horizon in the morning.
        /// </summary>
        public DateTimeOffset? SunriseNautical { get; set; }

        /// <summary>
        /// The time when the top edge of the sun reaches the horizon in the evening.
        /// </summary>
        public DateTimeOffset? Sunset { get; set; }

        /// <summary>
        /// The time when the sun is 18 degrees below the horizon in the evening.
        /// </summary>
        public DateTimeOffset? SunsetAstronomical { get; set; }

        /// <summary>
        /// The time when the sun is 6 degrees below the horizon in the evening.
        /// </summary>
        public DateTimeOffset? SunsetCivil { get; set; }

        /// <summary>
        /// The time when the sun is 12 degrees below the horizon in the evening.
        /// </summary>
        public DateTimeOffset? SunsetNautical { get; set; }

        /// <summary>
        /// The maximum temperature forecasted to occur during the day, in degrees Celsius.
        /// </summary>
        public double TemperatureMax { get; set; }

        /// <summary>
        /// The minimum temperature forecasted to occur during the day, in degrees Celsius.
        /// </summary>
        public double TemperatureMin { get; set; }

        [Obsolete(ObsoleteReasons.Undocumented)]
        public double WindGustSpeedMax { get; set; }

        [Obsolete(ObsoleteReasons.Undocumented)]
        public double WindSpeedAvg { get; set; }

        [Obsolete(ObsoleteReasons.Undocumented)]
        public double WindSpeedMax { get; set; }
    }
}