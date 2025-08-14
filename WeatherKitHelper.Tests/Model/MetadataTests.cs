#pragma warning disable CS0618 // Type or member is obsolete

namespace WeatherKitHelper.Tests.Model
{
    public class MetadataTests
    {
        [Fact]
        public void TestMetadata()
        {
            var json = @$"{{""attributionURL"":""https://developer.apple.com/weatherkit/data-source-attribution/"",
""expireTime"":""2025-08-12T16:05:38Z"",""latitude"":55.750,""longitude"":37.620,""readTime"":""2025-08-12T15:10:06Z"",
""reportedTime"":""2025-08-12T13:05:35Z"",""units"":""m"",""version"":1,""sourceType"":""modeled""}}";

            var obj = System.Text.Json.JsonSerializer.Deserialize<Metadata>(json, WeatherKitClient.JsonOptions);

            Assert.NotNull(obj);
            Assert.Equal("https://developer.apple.com/weatherkit/data-source-attribution/", obj.AttributionURL);
            Assert.Equal(new DateTimeOffset(2025, 8, 12, 16, 5, 38, TimeSpan.Zero), obj.ExpireTime);
            Assert.Equal(55.750, obj.Latitude);
            Assert.Equal(37.620, obj.Longitude);
            Assert.Equal(new DateTimeOffset(2025, 8, 12, 15, 10, 6, TimeSpan.Zero), obj.ReadTime);
            Assert.Equal(new DateTimeOffset(2025, 8, 12, 13, 5, 35, TimeSpan.Zero), obj.ReportedTime);
            Assert.Equal(UnitsSystem.Metric, obj.Units);
            Assert.Equal(1, obj.Version);
            Assert.Equal("modeled", obj.SourceType);
        }
    }
}