namespace AdapterAppliance.Manually
{
    using System.Collections.Generic;

    public interface IDataPatternRendererAdapter
    {
        string ListPatterns(IEnumerable<Pattern> patterns);
    }
}