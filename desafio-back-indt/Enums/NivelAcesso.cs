using System.Text.Json.Serialization;

namespace desafio_back_indt.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum NivelAcessoEnum
    {
        Admin,
        Usuario
    }
}
