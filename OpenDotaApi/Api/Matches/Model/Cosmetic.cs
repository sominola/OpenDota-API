using System;
using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Matches.Model
{
    public class Cosmetic
    {
        [JsonPropertyName("creation_date")]
        public DateTimeOffset? CreationDate { get; set; }

        [JsonPropertyName("image_inventory")]
        public string ImageInventory { get; set; }

        [JsonPropertyName("image_path")]
        public string ImagePath { get; set; }

        [JsonPropertyName("item_description")]
        public string ItemDescription { get; set; }

        [JsonPropertyName("item_id")]
        public int? ItemId { get; set; }

        [JsonPropertyName("item_name")]
        public string ItemName { get; set; }

        [JsonPropertyName("item_rarity")]
        public string ItemRarity { get; set; }

        [JsonPropertyName("item_type_name")]
        public string ItemTypeName { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("prefab")]
        public string Prefab { get; set; }

        [JsonPropertyName("used_by_heroes")]
        public string UsedByHeroes { get; set; }
    }
}