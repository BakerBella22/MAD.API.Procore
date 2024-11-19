using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAD.API.Procore.Endpoints.Checklists.Models
{
    public class Response
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("corresponding_status")]
        public string CorrespondingStatus { get; set; }
    }

}
