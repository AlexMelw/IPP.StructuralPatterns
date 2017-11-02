namespace FacadeAppliance.TemperatureFacade
{
    using WeatherServices;

    public class TemperatureLookupFacade
    {
        readonly WeatherService weatherService;
        readonly GeoLookupService geoLookupService;
        readonly EnglishMetricConverter converter;

        #region CONSTRUCTORS

        public TemperatureLookupFacade()
            : this(new WeatherService(), new GeoLookupService(), new EnglishMetricConverter()) { }

        public TemperatureLookupFacade(WeatherService weatherService, GeoLookupService geoLookupService,
            EnglishMetricConverter englishMetricConverter)
        {
            this.weatherService = weatherService;
            this.geoLookupService = geoLookupService;
            converter = englishMetricConverter;
        }

        #endregion

        public LocalTemperature GetTemperature(string zipCode)
        {
            var coords = geoLookupService.GetCoordinatesForZipCode(zipCode);
            var city = geoLookupService.GetCityForZipCode(zipCode);
            var state = geoLookupService.GetStateForZipCode(zipCode);

            var farenheit = weatherService.GetTempFarenheit(coords.Latitude, coords.Longitude);
            var celcius = converter.FarenheitToCelcious(farenheit);

            var localTemperature = new LocalTemperature()
            {
                Farenheit = farenheit,
                Celcius = celcius,
                City = city,
                State = state
            };

            return localTemperature;
        }
    }
}