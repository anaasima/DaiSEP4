using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DatabaseSEP4.Models
{
    [Table("DimGarden", Schema = "stage")]
    public class DimGarden
    {
        [Key] [JsonPropertyName("id")] public int Garden_ID { get; set; }
        [JsonPropertyName("name")] public string Name { get; set; }
        [JsonPropertyName("landArea")] public decimal LandArea { get; set; }
        [JsonPropertyName("city")] public string City { get; set; }
        [JsonPropertyName("street")] public string Street { get; set; }
        [JsonPropertyName("number")] public int Number { get; set; }
    }
}