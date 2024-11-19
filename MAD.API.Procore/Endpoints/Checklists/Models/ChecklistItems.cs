using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAD.API.Procore.Endpoints.Checklists.Models
{
    public class ChecklistItems
    {
        [JsonProperty("items")]
        public List<ChecklistItem> Items { get; set; }
    }
}
