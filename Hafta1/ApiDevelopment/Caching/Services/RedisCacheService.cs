using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StackExchange.Redis;
using System.Text.Json;

namespace Caching.Services
{
    public class RedisCacheService
    {
        private readonly IDatabase _cache;

        public RedisCacheService(IConnectionMultiplexer redis)
        {
            _cache = redis.GetDatabase();
        }

        // Veriyi önbelleğe yazma
        public async Task SetCacheAsync<T>(string key, T value, TimeSpan expiration)
        {
            var jsonData = JsonSerializer.Serialize(value);
            await _cache.StringSetAsync(key, jsonData, expiration);
        }

        // Önbellekten veri okuma
        public async Task<T?> GetCacheAsync<T>(string key)
        {
            var jsonData = await _cache.StringGetAsync(key);
            if (jsonData.IsNullOrEmpty) return default;

            return jsonData.HasValue ? JsonSerializer.Deserialize<T>(jsonData) : default;

        }
    }
}
