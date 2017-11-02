namespace BridgeAppliance.Formatters
{
    using Interfaces;

    class StandardFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return $"{key}: {value}";
        }
    }
}