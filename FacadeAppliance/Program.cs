namespace FacadeAppliance
{
    using System;
    using TemperatureFacade;

    class Program
    {
        static void Main(string[] args)
        {
            const string zipCode = "2002"; // Chisinau, Botanica

            var temperatureFacade = new TemperatureLookup();
            LocalTemperature localTemp = temperatureFacade.GetTemperature(zipCode);

            Console.WriteLine($"The current temperature is {localTemp.Farenheit:F1}(F) / {localTemp.Celcius:F1}(C) " +
                              $"in {localTemp.City}, {localTemp.State}");
        }
    }
}