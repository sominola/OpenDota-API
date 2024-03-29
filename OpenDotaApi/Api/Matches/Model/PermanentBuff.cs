﻿using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Matches.Model
{
    public class PermanentBuff
    {
        [JsonPropertyName("permanent_buff")]
        public long? PermanentBuffPermanentBuff { get; set; }

        [JsonPropertyName("stack_count")]
        public long? StackCount { get; set; }
    }
}