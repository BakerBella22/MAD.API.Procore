using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAD.API.Procore.Endpoints.Checklists.Models
{
    public class ItemType
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

}
