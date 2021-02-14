using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Status.Model
{
    public partial class ApiPath
    {
        [JsonPropertyName("hostname")]
        public string Hostname { get; set; }

        [JsonPropertyName("count")]
        public int? Count { get; set; }
    }
}