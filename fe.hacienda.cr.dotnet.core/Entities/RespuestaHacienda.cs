using Newtonsoft.Json;

namespace fe.hacienda.cr.dotnet.core.Entities
{
    public class RespuestaHacienda
    {
        [JsonProperty("clave")]
        public string Clave { get; set; }

        [JsonProperty("fecha")]
        public string Fecha { get; set; }

        [JsonProperty("ind-estado")]
        public string IndEstado { get; set; }

        [JsonProperty("respuesta-xml")]
        public string RespuestaXml { get; set; }
    }
}
