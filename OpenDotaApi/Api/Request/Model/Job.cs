using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Request.Model
{
    public class Job
    {
        [JsonPropertyName("jobId")]
        public long JobId { get; set; }
    }
}