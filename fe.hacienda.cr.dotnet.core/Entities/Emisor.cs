using Newtonsoft.Json;

namespace fe.hacienda.cr.dotnet.core.Entities
{
    public class Emisor
    {
        [JsonProperty("TipoIdentificacion")]
        public string TipoIdentificacion { get; set; }

        [JsonProperty("numeroIdentificacion")]
        public string NumeroIdentificacion { get; set; }
    }
}
