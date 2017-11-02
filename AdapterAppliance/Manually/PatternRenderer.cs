namespace AdapterAppliance.Manually
{
    using System.Collections.Generic;

    public class PatternRenderer
    {
        private readonly IDataPatternRendererAdapter _dataPatternRenderer;

        #region CONSTRUCTORS

        public PatternRenderer(IDataPatternRendererAdapter dataPatternRenderer)
        {
            _dataPatternRenderer = dataPatternRenderer;
        }

        public PatternRenderer() : this(new DataPatternRendererAdapter()) { }

        #endregion

        public string ListPatterns(IEnumerable<Pattern> patterns)
        {
            return _dataPatternRenderer.ListPatterns(patterns);
        }
    }
}