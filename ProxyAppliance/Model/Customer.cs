namespace ProxyAppliance.Model
{
    using System.Collections.Generic;
    using Entities;
    using Repositories;

    public class Customer
    {
        private readonly int _id;

        public string Name { get; set; }
        public List<Order> Orders { get; set; }

        #region CONSTRUCTORS

        public Customer() { }

        public Customer(int id)
        {
            _id = id;
            CustomerEntity customerEntity = new CustomerRepository().GetById(id);
            Name = customerEntity.Name;
        }

        #endregion
    }
}