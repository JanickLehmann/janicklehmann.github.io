using System.Net.Http;
using System.Net.Http.Json;
using janicklehmann.github.io.Models;

namespace janicklehmann.github.io.Services {
    public interface IIPService {
        Task<GeoIPResponse> GetUserIP();
    }

    public class IPService : IIPService {
        private readonly IHttpClientFactory _httpClientFactory;

        public IPService(IHttpClientFactory httpClientFactory) {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<GeoIPResponse> GetUserIP() {
            var client = _httpClientFactory.CreateClient("IP");
            client.DefaultRequestHeaders.Add("Origin", "https://localhost:7227/");
            return await client.GetFromJsonAsync<GeoIPResponse>("/json");
        }
    }
}