namespace WeatherKitHelper
{
    using System;
    using System.Globalization;
    using System.Net.Http.Json;
    using System.Text.Json;
    using System.Web;

    public class WeatherKitClient(HttpClient httpClient) : IWeatherKitClient
    {
        public const string Endpoint = "https://weatherkit.apple.com/api/v1/";

        public static readonly JsonSerializerOptions JsonOptions = new(JsonSerializerDefaults.Web)
        {
            Converters = { new JsonStringEnumConverter() },
        };

        /// <inheritdoc/>
        public async Task<DataSet[]> GetAvailability(double latitude, double longitude, string country)
        {
            var lat = latitude.ToString(CultureInfo.InvariantCulture);
            var lng = longitude.ToString(CultureInfo.InvariantCulture);

            var resp = await httpClient.GetFromJsonAsync<DataSet[]>($"{Endpoint}availability/{lat}/{lng}?country={country}", JsonOptions);

            return resp ?? [];
        }

        /// <inheritdoc/>
        public async Task<Weather> GetWeather(string language, double latitude, double longitude, DataSet[] datasets, string? countryCode = null, DateTimeOffset? currentAsOf = null, DateTimeOffset? dailyStart = null, DateTimeOffset? dailyEnd = null, DateTimeOffset? hourlyStart = null, DateTimeOffset? hourlyEnd = null, string? timezone = null)
        {
            var lat = latitude.ToString(CultureInfo.InvariantCulture);
            var lng = longitude.ToString(CultureInfo.InvariantCulture);

            var prms = HttpUtility.ParseQueryString(string.Empty);

            if (datasets.Length > 0)
            {
                prms.Add("dataSets", string.Join(",", datasets.Select(x => JsonNamingPolicy.CamelCase.ConvertName(x.ToString()))));
            }

            if (!string.IsNullOrEmpty(countryCode))
            {
                prms.Add("countryCode", countryCode);
            }

            if (currentAsOf != null)
            {
                prms.Add("currentAsOf", currentAsOf.Value.ToUniversalTime().ToString("s") + "Z");
            }

            if (dailyStart != null)
            {
                prms.Add("dailyStart", dailyStart.Value.ToUniversalTime().ToString("s") + "Z");
            }

            if (dailyEnd != null)
            {
                prms.Add("dailyEnd", dailyEnd.Value.ToUniversalTime().ToString("s") + "Z");
            }

            if (hourlyStart != null)
            {
                prms.Add("hourlyStart", hourlyStart.Value.ToUniversalTime().ToString("s") + "Z");
            }

            if (hourlyEnd != null)
            {
                prms.Add("hourlyEnd", hourlyEnd.Value.ToUniversalTime().ToString("s") + "Z");
            }

            if (!string.IsNullOrEmpty(timezone))
            {
                prms.Add("timezone", timezone);
            }

            var resp = await httpClient.GetFromJsonAsync<Weather>($"{Endpoint}weather/{language}/{lat}/{lng}?{prms}", JsonOptions);

            return resp!;
        }

        /// <inheritdoc/>
        public async Task<WeatherAlert> GetWeatherAlert(string language, string id)
        {
            var resp = await httpClient.GetFromJsonAsync<WeatherAlert>($"{Endpoint}weatherAlert/{language}/{id}", JsonOptions);

            return resp!;
        }

        /// <inheritdoc/>
        public async Task<Attribution> GetAttribution(string language)
        {
            var resp = await httpClient.GetFromJsonAsync<Attribution>($"https://weatherkit.apple.com/attribution/{language}", JsonOptions);

            return resp!;
        }
    }
}
