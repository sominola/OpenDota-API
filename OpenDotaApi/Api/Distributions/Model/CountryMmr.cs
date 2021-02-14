using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Distributions.Model
{
    public class CountryMmr
    {
        [JsonPropertyName("command")]
        public string Command { get; set; }

        [JsonPropertyName("rowCount")]
        public long? RowCount { get; set; }

        [JsonPropertyName("rows")]
        public List<CountryMmrRow> Rows { get; set; }

        [JsonPropertyName("fields")]
        public List<Field> Fields { get; set; }

        [JsonPropertyName("_types")]
        public CountryMmrTypes Types { get; set; }

        [JsonPropertyName("rowAsArray")]
        public bool? RowAsArray { get; set; }
    }

    public class CountryMmrRow
    {
        [JsonPropertyName("loccountrycode")]
        public string Loccountrycode { get; set; }

        [JsonPropertyName("count")]
        public long? Count { get; set; }

        [JsonPropertyName("avg")]
        public int? Avg { get; set; }

        [JsonPropertyName("common")]
        public string Common { get; set; }
    }

    public class Field
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("tableID")]
        public long? TableId { get; set; }

        [JsonPropertyName("columnID")]
        public int? ColumnId { get; set; }

        [JsonPropertyName("dataTypeID")]
        public int? DataTypeId { get; set; }

        [JsonPropertyName("dataTypeSize")]
        public int? DataTypeSize { get; set; }

        [JsonPropertyName("dataTypeModifier")]
        public int? DataTypeModifier { get; set; }

        [JsonPropertyName("format")]
        public string Format { get; set; }
    }

    public class CountryMmrTypes
    {
        [JsonPropertyName("_types")]
        public Types Types { get; set; }

        // [JsonPropertyName("text")]
        // public Binary Text { get; set; }
        //
        // [JsonPropertyName("binary")]
        // public Binary Binary { get; set; }
    }

    public class Types
    {
        // [JsonPropertyName("arrayParser")]
        // public Binary ArrayParser { get; set; }

        [JsonPropertyName("builtins")]
        public Dictionary<string, long> Builtins { get; set; }
    }
}