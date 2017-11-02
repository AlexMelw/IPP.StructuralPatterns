namespace BridgeAppliance.Formatters
{
    using System.Linq;
    using Interfaces;

    public class BackwardsFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return $"{key}: {new string(value.Reverse().ToArray())}";
        }
    }
}