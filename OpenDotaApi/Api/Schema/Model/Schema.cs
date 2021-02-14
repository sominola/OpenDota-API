using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Schema.Model
{
    public class Schema
    {
        [JsonPropertyName("table_name")]
        public string TableName { get; set; }

        [JsonPropertyName("column_name")]
        public string ColumnName { get; set; }

        [JsonPropertyName("data_type")]
        public string DataType { get; set; }
    }
}