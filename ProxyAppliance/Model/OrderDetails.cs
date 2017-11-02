namespace ProxyAppliance.Model
{
    using Repositories;

    public class OrderDetails
    {
        private readonly int _id;
        public string Name { get; set; }
        public decimal Price { get; set; }

        #region CONSTRUCTORS

        public OrderDetails() { }

        public OrderDetails(int id)
        {
            _id = id;
            var orderDetailsEntity = new OrderDetailsRepository().GetById(id);
            Name = orderDetailsEntity.Name;
            Price = orderDetailsEntity.Price;
        }

        #endregion
    }
}