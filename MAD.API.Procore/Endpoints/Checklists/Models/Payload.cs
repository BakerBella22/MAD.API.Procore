using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAD.API.Procore.Endpoints.Checklists.Models
{
    public class Payload
    {
        [JsonProperty("text_value")]
        public string TextValue { get; set; }

        [JsonProperty("number_value")]
        public int? NumberValue { get; set; }

        [JsonProperty("date_value")]
        public DateTime? DateValue { get; set; }

        [JsonProperty("response_option")]
        public ResponseOption ResponseOption { get; set; }
    }

}
