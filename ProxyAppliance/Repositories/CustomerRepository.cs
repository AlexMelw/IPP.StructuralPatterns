namespace ProxyAppliance.Repositories
{
    using System;
    using Entities;

    public class CustomerRepository : Repository<CustomerEntity>
    {
        public override CustomerEntity GetById(int id)
        {
            Console.WriteLine("--> Fetching Customer " + id);
            return new CustomerEntity()
            {
                Id = id,
                Name = "Customer " + id
            };
        }
    }
}