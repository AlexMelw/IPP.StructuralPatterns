using System;
using System.Collections.Generic;

namespace ProxyAppliance.Model
{
    public abstract class AbstractOrder
    {
        public abstract Customer Customer { get; }
        public abstract int Id { get; }
        public abstract List<OrderDetails> Items { get;}
        public abstract DateTime OrderDate { get; }
    }
}