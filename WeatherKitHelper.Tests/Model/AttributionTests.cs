namespace WeatherKitHelper.Tests.Model
{
    public class AttributionTests
    {
        [Fact]
        public void TestAttribution()
        {
            var attribution = System.Text.Json.JsonSerializer.Deserialize<Attribution>(Responses.AttributionResponse, WeatherKitClient.JsonOptions);

            Assert.NotNull(attribution);

            Assert.Equal("/assets/branding/ru/Apple_Weather_wht_ru_1X_090122.png", attribution.LogoDark1x);
            Assert.Equal("/assets/branding/ru/Apple_Weather_wht_ru_2X_090122.png", attribution.LogoDark2x);
            Assert.Equal("/assets/branding/ru/Apple_Weather_wht_ru_3X_090122.png", attribution.LogoDark3x);

            Assert.Equal("/assets/branding/ru/Apple_Weather_blk_ru_1X_090122.png", attribution.LogoLight1x);
            Assert.Equal("/assets/branding/ru/Apple_Weather_blk_ru_2X_090122.png", attribution.LogoLight2x);
            Assert.Equal("/assets/branding/ru/Apple_Weather_blk_ru_3X_090122.png", attribution.LogoLight3x);

            Assert.Equal("/assets/branding/square-mark.png", attribution.LogoSquare1x);
            Assert.Equal("/assets/branding/square-mark@2x.png", attribution.LogoSquare2x);
            Assert.Equal("/assets/branding/square-mark@3x.png", attribution.LogoSquare3x);

            Assert.Equal("Apple Weather", attribution.ServiceName);
        }
    }
}
