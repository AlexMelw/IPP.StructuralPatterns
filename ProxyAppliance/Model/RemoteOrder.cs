namespace ProxyAppliance.Model
{
    using Repositories;

    public class RemoteOrder : Order
    {
        #region CONSTRUCTORS

        public RemoteOrder(int id) : base(id) { }

        #endregion

        protected override void GetEntity()
        {
            OrderEntity = new RemoteOrderRepository().GetById(Id);
        }
    }
}