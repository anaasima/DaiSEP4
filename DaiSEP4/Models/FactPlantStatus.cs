using System.Collections;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DatabaseSEP4.Models
{
    public class FactPlantStatus
    {
        
        [JsonPropertyName("temperature")]
        public double Temperature { get; set; }
        [JsonPropertyName("co2")]
        public double CO2 { get; set; }
        [JsonPropertyName("light")]
        public double Light { get; set; }
        [JsonPropertyName("humidity")]
        public double Humidity { get; set; }
        public Garden Garden { get; set; }
        public Gardener Gardener { get; set; }
        public Plant Plant { get; set; }
    }
}