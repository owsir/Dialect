using System;
using System.Runtime.Caching;

namespace Dialect.Infrustructure
{
    public static class CacheManager
    {

        private static readonly MemoryCache cache;
        private const double defaultExpirationInDay = 1;

        static CacheManager()
        {
            cache = new MemoryCache("VisitorLog");
        }

        public static void Add(string key, object value)
        {
            var policy = new CacheItemPolicy
            {
                AbsoluteExpiration = DateTime.Now.AddDays(defaultExpirationInDay)
            };
            cache.Add(key, value, policy);
        }

        public static void Add(string key, object value, TimeSpan timeout)
        {
            cache.Add(key, value, new CacheItemPolicy
            {
                SlidingExpiration = timeout
            });
        }

        public static bool Contains(string key)
        {
            return cache.Contains(key);
        }
        public static void Set(string key, object value)
        {
            var policy = new CacheItemPolicy
            {
                AbsoluteExpiration = DateTime.Now.AddDays(defaultExpirationInDay)
            };
            cache.Set(key, value, policy);
        }

        public static void Set(string key, object value, TimeSpan timeout)
        {
            var policy = new CacheItemPolicy
            {
                SlidingExpiration = timeout
            };
            cache.Set(key, value, policy);
        }


        public static T Get<T>(string key)
        {
            if (cache.Get(key) != null) return (T)cache.Get(key);
            return default(T);
        }

        public static void Remove(string key)
        {
            cache.Remove(key);
        }
    }
}
