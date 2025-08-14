namespace WeatherKitHelper.Model
{
    using System.Globalization;
    using System.Resources;

    public static class EnumExtensions
    {
        private static ResourceManager? weatherConditionResourceManager;

        public static string GetText(this WeatherCondition value, CultureInfo? culture = null)
        {
            weatherConditionResourceManager ??= new ResourceManager("WeatherKitHelper.Extensions.WeatherConditionTexts", typeof(WeatherConditionExtensions).Assembly);

            return weatherConditionResourceManager.GetString(value.ToString(), culture) ?? value.ToString();
        }
    }
}
