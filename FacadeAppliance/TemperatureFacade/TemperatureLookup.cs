namespace FacadeAppliance.TemperatureFacade
{
    using WeatherServices;

    public class TemperatureLookup
    {
        readonly WeatherService _weatherService;
        readonly GeoLookupService _geoLookupService;
        readonly EnglishMetricConverter _converter;

        #region CONSTRUCTORS

        public TemperatureLookup()
            : this(new WeatherService(), new GeoLookupService(), new EnglishMetricConverter()) { }

        public TemperatureLookup(WeatherService weatherService, GeoLookupService geoLookupService,
            EnglishMetricConverter englishMetricConverter)
        {
            _weatherService = weatherService;
            _geoLookupService = geoLookupService;
            _converter = englishMetricConverter;
        }

        #endregion

        public LocalTemperature GetTemperature(string zipCode)
        {
            var coords = _geoLookupService.GetCoordinatesForZipCode(zipCode);
            var city = _geoLookupService.GetCityForZipCode(zipCode);
            var state = _geoLookupService.GetStateForZipCode(zipCode);

            var fahrenheit = _weatherService.GetTempFarenheit(coords.Latitude, coords.Longitude);
            var celsius = _converter.FarenheitToCelcious(fahrenheit);

            var localTemperature = new LocalTemperature
            {
                Farenheit = fahrenheit,
                Celcius = celsius,
                City = city,
                State = state
            };

            return localTemperature;
        }
    }
}