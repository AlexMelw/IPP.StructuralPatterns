namespace BridgeAppliance.Formatters
{
    using Interfaces;

    public class FancyFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return $">>> {key} ===========> {value}";
        }
    }
}