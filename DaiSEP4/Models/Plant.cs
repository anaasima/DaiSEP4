using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DatabaseSEP4.Models
{
    public class Plant
    {
        [Key] [JsonPropertyName("id")] public int ID { get; set; }
        [JsonPropertyName("height")] public int Height { get; set; }
        [JsonPropertyName("width")] public int Width { get; set; }
        [JsonPropertyName("stageOfGrowth")] public string StageOfGrowth { get; set; }
        [JsonPropertyName("soilType")] public string SoilType { get; set; }
        [JsonPropertyName("ownSoilVolume")] public int OwnSoilVolume { get; set; } //is it square meters or a string?
        [JsonPropertyName("gardenLocation")] public string GardenLocation { get; set; }
        [JsonPropertyName("seededAt")] public string SeededAt { get; set; }
        [JsonPropertyName("harvestedAt")] public string HarvestedAt { get; set; }
        [JsonPropertyName("commonPlantName")] public string CommonPlantName { get; set; }
        [JsonPropertyName("categoryName")] public string CategoryName { get; set; }
    }
}