using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DatabaseSEP4.Models
{
    public class DimGarden
    {
        [Key] [JsonPropertyName("id")] public int Id { get; set; }
        [JsonPropertyName("name")] public string Name { get; set; }
        [JsonPropertyName("landArea")] public double LandArea { get; set; }
        [JsonPropertyName("city")] public string City { get; set; }
        [JsonPropertyName("street")] public string Street { get; set; }
        [JsonPropertyName("number")] public int Number { get; set; }
    }
}