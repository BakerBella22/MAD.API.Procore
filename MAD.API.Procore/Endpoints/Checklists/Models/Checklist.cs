using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace MAD.API.Procore.Endpoints.Checklists.Models
{
    public class Checklist
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("inspection_type")]
        public InspectionType InspectionType { get; set; }

        [JsonProperty("list_template_id")]
        public long? ListTemplateId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("distribution_members")]
        public List<ChecklistDistributionMember> DistributionMembers { get; set; }

        [JsonProperty("due_at")]
        public DateTimeOffset? DueAt { get; set; }

        [JsonProperty("number")]
        public int? Number { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("inspection_date")]
        public string InspectionDate { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("closed_at")]
        public DateTimeOffset? ClosedAt { get; set; }

        [JsonProperty("item_count")]
        public int? ItemCount { get; set; }

        [JsonProperty("yes_item_count")]
        public int? YesItemCount { get; set; }

        [JsonProperty("personal")]
        public bool Personal { get; set; }

        [JsonProperty("item_total")]
        public int? ItemTotal { get; set; }

        [JsonProperty("conforming_item_count")]
        public int? ConformingItemCount { get; set; }

        [JsonProperty("deficient_item_count")]
        public int? DeficientItemCount { get; set; }

        [JsonProperty("na_item_count")]
        public int? NaItemCount { get; set; }

        [JsonProperty("neutral_item_count")]
        public int? NeutralItemCount { get; set; }

        [JsonProperty("not_inspected_item_count")]
        public int? NotInspectedItemCount { get; set; }

        [JsonProperty("drawing_ids")]
        public List<long> DrawingIds { get; set; }

        [JsonProperty("current_drawing_revision_ids")]
        public List<long> CurrentDrawingRevisionIds { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("specification_section")]
        public ChecklistSpecificationSection SpecificationSection { get; set; }

        [JsonProperty("trade")]
        public Trade Trade { get; set; }

        [JsonProperty("created_by")]
        public ChecklistCreatedBy CreatedBy { get; set; }

        [JsonProperty("closed_by")]
        public ChecklistClosedBy ClosedBy { get; set; }

        [JsonProperty("inspectors")]
        public List<ChecklistInspector> Inspectors { get; set; }

        [JsonProperty("signature_requests")]
        public List<ChecklistSignatureRequest> SignatureRequests { get; set; }

        [JsonProperty("responsible_contractor")]
        public ChecklistResponsibleContractor ResponsibleContractor { get; set; }

        [JsonProperty("responsible_party")]
        public ChecklistResponsibleParty ResponsibleParty { get; set; }

        [JsonProperty("response_set")]
        public ChecklistDefaultResponseSet ResponseSet { get; set; }

        [JsonProperty("attachments")]
        public List<ChecklistAttachment> Attachments { get; set; }

        [JsonProperty("sections")]
        public List<ChecklistSection> Sections { get; set; }

        [JsonProperty("custom_fields")]
        public JObject CustomFields { get; set; }

        [JsonProperty("managed_equipment_id")]
        public long? ManagedEquipmentId { get; set; }

        [JsonProperty("template_id")]
        public long? TemplateId { get; set; }

        [JsonProperty("list_template_name")]
        public string ListTemplateName { get; set; }

        [JsonProperty("trade_id")]
        public long? TradeId { get; set; }

        [JsonProperty("inspection_type_id")]
        public long? InspectionTypeId { get; set; }
    }
}
