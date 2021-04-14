using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public Plant Plant { get; set; }
        public DimGarden DimGarden { get; set; }
        public Gardener Gardener { get; set; }
        public int GardenID { get; set; }
        public int GardenerID { get; set; }
        public int PlantID { get; set; }
    }
}