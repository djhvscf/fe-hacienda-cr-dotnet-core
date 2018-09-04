using Newtonsoft.Json;
using System;

namespace fe.hacienda.cr.dotnet.core.Entities
{
    public class Receptor
    {
        [JsonProperty("TipoIdentificacion")]
        public string TipoIdentificacion { get; set; }

        [JsonProperty("numeroIdentificacion")]
        public string NumeroIdentificacion { get; set; }

        public Boolean SinReceptor { get; set; }
    }
}
