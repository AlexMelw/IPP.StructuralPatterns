namespace BridgeAppliance.Interfaces
{
    public abstract class Manuscript
    {
        protected readonly IFormatter formatter;

        #region CONSTRUCTORS

        public Manuscript(IFormatter formatter)
        {
            this.formatter = formatter;
        }

        #endregion

        public abstract void Print();
    }
}