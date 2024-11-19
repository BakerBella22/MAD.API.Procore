using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAD.API.Procore.Endpoints.Checklists.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    namespace MAD.API.Procore.Endpoints.Checklists.Models
    {
        public class ChecklistItemsResponse
        {
            [JsonProperty("data")] // Adjust if the Procore API uses a different wrapper key
            public List<ChecklistItem> Result { get; set; }
        }
    }
}
