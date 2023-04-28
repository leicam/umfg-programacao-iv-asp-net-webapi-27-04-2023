using System.Text.Json.Serialization;

namespace Umfg.Apresentacao.Entities
{
    public sealed class Produto
    {
        [JsonPropertyName("id")]
        public Guid Id { get; private set; }

        [JsonPropertyName("codigoBarra")]
        public string CodigoBarra { get; set; }

        [JsonPropertyName("descricao")]
        public string Decricao { get; set; }

        [JsonPropertyName("valor")]
        public decimal Valor { get; set; }

        public Produto()
        {
            Id = Guid.NewGuid();
        }
    }
}