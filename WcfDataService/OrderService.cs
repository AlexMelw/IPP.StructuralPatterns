namespace WcfDataService
{
    using System;

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "OrderService" in both code and config file together.
    public class OrderService : IOrderService
    {
        public OrderDTO GetDataUsingDataContract(int orderId)
        {
            return new OrderDTO
            {
                Id = orderId,
                CustomerId = 123,
                OrderDate = DateTime.Now,
                OrderItems = new[] { 1, 2, 3, 4, 5 }
            };
        }
    }
}