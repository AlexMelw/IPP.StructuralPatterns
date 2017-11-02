namespace ProxyAppliance.Model
{
    using System;
    using System.Collections.Generic;
    using Entities;
    using Repositories;

    public class Order
    {
        protected OrderEntity OrderEntity;
        protected int _id;
        public virtual DateTime OrderDate { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual List<OrderDetails> Items { get; set; }

        public int Id
        {
            get { return _id; }
        }

        #region CONSTRUCTORS

        public Order() { }

        public Order(int id)
        {
            _id = id;
            GetEntity();
            OrderDate = OrderEntity.OrderDate;
            Customer = GetCustomer();
            Items = GetItems();
        }

        #endregion

        protected virtual void GetEntity()
        {
            OrderEntity = new OrderRepository().GetById(Id);
        }

        protected virtual Customer GetCustomer()
        {
            return new Customer(OrderEntity.CustomerId);
        }

        protected virtual List<OrderDetails> GetItems()
        {
            var items = new List<OrderDetails>();
            foreach (var orderDetailId in OrderEntity.OrderDetails)
            {
                items.Add(new OrderDetails(orderDetailId));
            }
            return items;
        }
    }
}