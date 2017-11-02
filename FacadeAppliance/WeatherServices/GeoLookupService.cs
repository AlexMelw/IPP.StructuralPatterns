namespace FacadeAppliance.WeatherServices
{
    public class GeoLookupService
    {
        public Coordinates GetCoordinatesForZipCode(string zipCode)
        {
            return new Coordinates
            {
                Latitude = 43.676422,
                Longitude = -116.278025
            };
        }

        public string GetCityForZipCode(string zipCode)
        {
            return "Chisinau";
        }

        public string GetStateForZipCode(string zipCode)
        {
            return "Republic of Moldova";
        }

        public class Coordinates
        {
            public double Latitude { get; set; }
            public double Longitude { get; set; }
        }
    }
}