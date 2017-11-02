namespace ProxyAppliance.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Model;

    [TestClass]
    public class OrderFromServiceShould
    {
        [TestMethod]
        public void LoadDetailsFromWcf()
        {
            var myOrder = new RemoteOrder(1);
            ConsoleReporting.PrintOrderDetails(myOrder);
        }
    }
}