using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Distributions.Model
{
    public class Mmr
    {
        [JsonPropertyName("command")]
        public string Command { get; set; }

        [JsonPropertyName("rowCount")]
        public long? RowCount { get; set; }

        [JsonPropertyName("rows")]
        public List<MmrRow> Rows { get; set; }

        [JsonPropertyName("fields")]
        public List<Field> Fields { get; set; }

        [JsonPropertyName("_types")]
        public CountryMmrTypes Types { get; set; }

        [JsonPropertyName("rowAsArray")]
        public bool? RowAsArray { get; set; }

        [JsonPropertyName("sum")]
        public Sum Sum { get; set; }
    }

    public class MmrRow
    {
        [JsonPropertyName("bin")]
        public long? Bin { get; set; }

        [JsonPropertyName("bin_name")]
        public long? BinName { get; set; }

        [JsonPropertyName("count")]
        public long? Count { get; set; }

        [JsonPropertyName("cumulative_sum")]
        public long? CumulativeSum { get; set; }
    }

    public class Sum
    {
        [JsonPropertyName("count")]
        public long? Count { get; set; }
    }
}