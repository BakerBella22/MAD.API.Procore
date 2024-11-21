using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAD.API.Procore.Endpoints.Checklists.Models
{
    public class ChecklistItem
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("company_template_item_details")]
        public string CompanyTemplateItemDetails { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("item_reference_ids")]
        public List<long> ItemReferenceIds { get; set; }

        [JsonProperty("item_response")]
        public ItemResponse ItemResponse { get; set; }

        [JsonProperty("list_id")]
        public long ListId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("responded_with")]
        public string RespondedWith { get; set; }

        [JsonProperty("response")]
        public string Response { get; set; }

        [JsonProperty("response_set")]
        public string ResponseSet { get; set; }

        [JsonProperty("response_type_id")]
        public long? ResponseTypeId { get; set; }

        [JsonProperty("section_id")]
        public long SectionId { get; set; }

        [JsonProperty("signature_request_ids")]
        public List<long> SignatureRequestIds { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("template_item_id")]
        public long TemplateItemId { get; set; }

        [JsonProperty("type")]
        public ItemType Type { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
