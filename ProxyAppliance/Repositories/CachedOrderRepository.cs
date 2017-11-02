namespace ProxyAppliance.Repositories
{
    using System.Runtime.Caching;
    using Entities;

    public class CachedOrderRepository : RemoteOrderRepository
    {
        public override OrderEntity GetById(int id)
        {
            string cacheKey = "OrderEntity-" + id;

            if (!(MemoryCache.Default[cacheKey] is OrderEntity entity))
            {
                entity = base.GetById(id);
                var cacheItem = new CacheItem(cacheKey, entity);
                var policy = new CacheItemPolicy();
                MemoryCache.Default.Add(cacheItem, policy);
            }

            return entity;
        }
    }
}