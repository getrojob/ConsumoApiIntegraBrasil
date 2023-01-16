using System.Text.Json.Serialization;

namespace IntegraBrasilApi.Model
{
    public class FeriadosNacionalModel
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}