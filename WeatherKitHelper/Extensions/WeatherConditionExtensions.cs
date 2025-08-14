namespace WeatherKitHelper.Model
{
    public static class WeatherConditionExtensions
    {
        /// <summary>
        /// Tries to parse <see cref="CurrentWeather.ConditionCode"/>.
        /// </summary>
        /// <returns>Parsed <see cref="WeatherCondition"/> or <see cref="WeatherCondition.Unknown"/>.</returns>
        public static WeatherCondition GetWeatherCondition(this CurrentWeather source)
        {
            return GetWeatherCondition(source.ConditionCode);
        }

        /// <summary>
        /// Tries to parse <see cref="DayWeatherConditions.ConditionCode"/>.
        /// </summary>
        /// <returns>Parsed <see cref="WeatherCondition"/> or <see cref="WeatherCondition.Unknown"/>.</returns>
        public static WeatherCondition GetWeatherCondition(this DayWeatherConditions source)
        {
            return GetWeatherCondition(source.ConditionCode);
        }

        /// <summary>
        /// Tries to parse <see cref="DayPartForecast.ConditionCode"/>.
        /// </summary>
        /// <returns>Parsed <see cref="WeatherCondition"/> or <see cref="WeatherCondition.Unknown"/>.</returns>
        public static WeatherCondition GetWeatherCondition(this DayPartForecast source)
        {
            return GetWeatherCondition(source.ConditionCode);
        }

        /// <summary>
        /// Tries to parse <see cref="HourWeatherConditions.ConditionCode"/>.
        /// </summary>
        /// <returns>Parsed <see cref="WeatherCondition"/> or <see cref="WeatherCondition.Unknown"/>.</returns>
        public static WeatherCondition GetWeatherCondition(this HourWeatherConditions source)
        {
            return GetWeatherCondition(source.ConditionCode);
        }

        private static WeatherCondition GetWeatherCondition(string conditionCode)
        {
            return Enum.TryParse<WeatherCondition>(conditionCode, out var condition)
                ? condition
                : WeatherCondition.Unknown;
        }
    }
}
