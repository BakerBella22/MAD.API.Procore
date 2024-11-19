using MAD.API.Procore.Endpoints.Checklists.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAD.API.Procore.Endpoints.Checklists
{
    public class ListChecklistItemsRequest : ProcorePaginatedRequest<List<ChecklistItem>>
    {
        public override string Resource => $"/projects/{this.ProjectId}/checklist/list_items";

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")]
        public long ProjectId { get; set; }

        /// <summary>
        /// Return items with the specified IDs.
        /// </summary>
        [RequestParameter("filters[id]")]
        public List<int>? Ids { get; set; }

        /// <summary>
        /// Return items last updated within the specified ISO 8601 datetime range.
        /// </summary>
        [RequestParameter("filters[updated_at]")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Return items with the specified Checklist List IDs.
        /// </summary>
        [RequestParameter("filters[list_id]")]
        public long ListId { get; set; }

        /// <summary>
        /// Return items with the specified Checklist Section IDs.
        /// </summary>
        [RequestParameter("filters[section_id]")]
        public List<int>? SectionIds { get; set; }

        /// <summary>
        /// Page number for pagination.
        /// </summary>
        [RequestParameter("page")]
        public int? Page { get; set; }

        /// <summary>
        /// Items per page for pagination.
        /// </summary>
        [RequestParameter("per_page")]
        public int? PerPage { get; set; }
    }
}
