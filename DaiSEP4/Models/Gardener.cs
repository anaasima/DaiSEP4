using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DatabaseSEP4.Models
{
    public class Gardener
    {
        [Key]
        [JsonPropertyName("id")]
        public int id { get; set; }
        [JsonPropertyName("username")]
        public string Username { get; set; }
        [JsonPropertyName("age")]
        public int Age { get; set; }
        [JsonPropertyName("sex")]
        public string Sex { get; set; }
        [JsonPropertyName("isOwner")]
        public bool IsOwner { get; set; }

    }
}