using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Observations.Models {
	public class ObservationItem {

		/// <summary>
		/// Observation Item ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Created at
		/// </summary>
		[JsonProperty("created_at")]	public  DateTimeOffset CreatedAt { get ; set; }

		/// <summary>
		/// Closed at
		/// </summary>
		[JsonProperty("closed_at")]	public  DateTimeOffset? ClosedAt { get ; set; }

		/// <summary>
		/// Deleted at
		/// </summary>
		[JsonProperty("deleted_at")]	public  DateTimeOffset? DeletedAt { get ; set; }

		/// <summary>
		/// Updated at
		/// </summary>
		[JsonProperty("updated_at")]	public  DateTimeOffset UpdatedAt { get ; set; }

		/// <summary>
		/// Observation Item number
		/// </summary>
		[JsonProperty("number")]	public  string Number { get ; set; }

		/// <summary>
		/// Observation Item name
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }

		/// <summary>
		/// Observation Item description
		/// </summary>
		[JsonProperty("description")]	public  string Description { get ; set; }

		/// <summary>
		/// Observation Item status
		/// </summary>
		[JsonProperty("status")]	public  string Status { get ; set; }

		/// <summary>
		/// Observation Item priority
		/// </summary>
		[JsonProperty("priority")]	public  string Priority { get ; set; }

		/// <summary>
		/// Date that the Observation Item Assignee was notified
		/// </summary>
		[JsonProperty("date_notified")]	public  string DateNotified { get ; set; }

		/// <summary>
		/// Date that the Observation Item is due by
		/// </summary>
		[JsonProperty("due_date")]	public  string DueDate { get ; set; }

		/// <summary>
		/// Observation Item privacy status
		/// </summary>
		[JsonProperty("personal")]	public  bool Personal { get ; set; }

		/// <summary>
		/// Origin Item that the Observation was created from
		/// </summary>
		[JsonProperty("origin")]	public  ObservationOrigin Origin { get ; set; }

		[JsonProperty("assignee")]	public  ObservationItemAssignee Assignee { get ; set; }

		[JsonProperty("created_by")]	public  CreatedBy CreatedBy { get ; set; }

		[JsonProperty("location")]	public  Location Location { get ; set; }

		/// <summary>
		/// Specification Section
		/// </summary>
		[JsonProperty("specification_section")]	public  SpecificationSection SpecificationSection { get ; set; }

		[JsonProperty("trade")]	public  Trade Trade { get ; set; }

		[JsonProperty("type")]	public  ObservationType Type { get ; set; }

		[JsonProperty("custom_fields")]	public  JObject CustomFields { get ; set; }

        /// <summary>
        /// Attachments associated with the observation item
        /// </summary>
        [JsonProperty("attachments")] public List<Attachment> Attachments { get; set; }
    }
}
