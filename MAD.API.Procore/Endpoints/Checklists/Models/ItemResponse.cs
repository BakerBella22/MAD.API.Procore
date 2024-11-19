using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAD.API.Procore.Endpoints.Checklists.Models
{
    public class ItemResponse
    {
        [JsonProperty("item_id")]
        public long ItemId { get; set; }

        [JsonProperty("item_type")]
        public ItemType ItemType { get; set; }

        [JsonProperty("payload")]
        public Payload Payload { get; set; }

        [JsonProperty("responded_at")]
        public DateTime RespondedAt { get; set; }

        [JsonProperty("responder")]
        public Responder Responder { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
