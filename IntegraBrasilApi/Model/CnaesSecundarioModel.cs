using System.Text.Json.Serialization;

namespace IntegraBrasilApi.Model
{
    public class CnaesSecundarioModel
    {
        [JsonPropertyName("codigo")]
        public int? Codigo { get; set; }

        [JsonPropertyName("descricao")]
        public string? Descricao { get; set; }
    }
}
