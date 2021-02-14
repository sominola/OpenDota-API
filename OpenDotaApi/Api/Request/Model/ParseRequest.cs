using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Request.Model
{
    public class ParseRequest
    {
        [JsonPropertyName("job")]
        public Job Job { get; set; }
    }
}