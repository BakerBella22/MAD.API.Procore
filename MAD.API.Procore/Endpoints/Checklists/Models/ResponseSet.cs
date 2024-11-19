using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MAD.API.Procore.Endpoints.Checklists.Models
{
    public class ResponseSet
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("responses")]
        public List<ResponseOption> Responses { get; set; }

        [JsonProperty("deletable")]
        public bool Deletable { get; set; }

        [JsonProperty("procore_standard")]
        public bool ProcoreStandard { get; set; }
    }
}
