using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Caching.Services;

namespace Caching.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly RedisCacheService _cacheService;
        private static readonly string CacheKey = "WeatherData";

        public WeatherController(RedisCacheService cacheService)
        {
            _cacheService = cacheService;
        }

        // GET: api/weather
        [HttpGet]
        public async Task<IActionResult> GetWeatherData()
        {
            // Önbellekten veri oku
            var cachedData = await _cacheService.GetCacheAsync<List<string>>(CacheKey);
            if (cachedData != null)
            {
                return Ok(new { Source = "Cache", Data = cachedData });
            }

            // Önbellekte yoksa veriyi oluştur
            var weatherData = new List<string>
            {
                "Sunny",
                "Rainy",
                "Cloudy",
                "Windy"
            };

            // Veriyi önbelleğe yaz
            await _cacheService.SetCacheAsync(CacheKey, weatherData, TimeSpan.FromMinutes(5));

            return Ok(new { Source = "API", Data = weatherData });
        }
    }
}
