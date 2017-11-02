namespace ProxyAppliance.Repositories
{
    using System;
    using Entities;
    using OrderService;

    public class RemoteOrderRepository : Repository<OrderEntity>
    {
        public override OrderEntity GetById(int id)
        {
            Console.WriteLine("--> Using WCF to Fetch Order " + id);
            var dto = new OrderServiceClient().GetDataUsingDataContract(id);

            return new OrderEntity()
            {
                Id = dto.Id,
                CustomerId = dto.CustomerId,
                OrderDetails = dto.OrderItems,
                OrderDate = dto.OrderDate
            };
        }
    }
}