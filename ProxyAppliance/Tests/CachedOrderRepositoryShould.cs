namespace ProxyAppliance.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Repositories;

    [TestClass]
    public class CachedOrderRepositoryShould
    {
        [TestMethod]
        public void LoadOrderFromSourceOnlyOnce()
        {
            var orderEntity1 = new CachedOrderRepository().GetById(1);
            var orderEntity2 = new CachedOrderRepository().GetById(1);
            var orderEntity3 = new CachedOrderRepository().GetById(1);
        }
    }
}