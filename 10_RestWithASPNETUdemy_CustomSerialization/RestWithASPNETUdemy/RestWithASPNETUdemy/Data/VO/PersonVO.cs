using System.Text.Json.Serialization;

namespace RestWithASPNETUdemy.Data.VO
{
    public class PersonVO
    {
        // customizando o nome dos campos
        [JsonPropertyName("code")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        [JsonIgnore] // o campo será ignorado
        public string Address { get; set; }

        [JsonPropertyName("sex")]
        public string Gender { get; set; }
    }
}
