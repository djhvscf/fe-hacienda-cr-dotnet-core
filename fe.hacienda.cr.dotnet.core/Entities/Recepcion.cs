using Newtonsoft.Json;

namespace fe.hacienda.cr.dotnet.core.Entities
{
    public class Recepcion
    {
        [JsonProperty("clave")]
        public string Clave { get; set; }

        [JsonProperty("fecha")]
        public string Fecha { get; set; }

        [JsonProperty("emisor")]
        public Emisor Emisor { get; set; }

        [JsonProperty("receptor")]
        public Receptor Receptor { get; set; }

        [JsonProperty("comprobanteXml")]
        public string ComprobanteXml { get; set; }
    }
}
