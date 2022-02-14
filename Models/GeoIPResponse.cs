using System.Text.Json.Serialization;

namespace janicklehmann.github.io.Models
{
    public class GeoIPResponse {
        [JsonPropertyName("ip")]
        public string IPAddress { get; set; }

        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }
        
        [JsonPropertyName("country_name")]
        public string Country { get; set; }

        [JsonPropertyName("region_code")]
        public string Region { get; set; }

        [JsonPropertyName("region_name")]
        public string RegionName { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("zip_code")]
        public string PostalCode { get; set; }

        [JsonPropertyName("latitude")]
        public float Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public float Longitude { get; set; }

        // TODO:
        // "time_zone":"Europe/Zurich",
    }
}