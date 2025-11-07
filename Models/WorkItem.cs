
using System;

namespace UniSight.Models
{
    public class WorkItem
    {
        /// <summary>
<<<<<<< HEAD
        /// Id of the WorkItem
        /// </summary>
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Project { get; set; }
        public string OriginalEstimate { get; set; }
        public string CompletedWork { get; set; }
=======
        /// ADO work item identifier (maps to WorkItemID)
        /// </summary>
        public int WorkItemId { get; set; }

        /// <summary>
        /// Type of work item (Bug, Product Backlog Item, etc.)
        /// </summary>
        public string? WorkItemType { get; set; }

        public string? Title { get; set; }

        public string? State { get; set; }

        public string? Project { get; set; }

        public decimal? OriginalEstimate { get; set; }

        public decimal? CompletedWork { get; set; }

        public string? AssignedTo { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? ClosedDate { get; set; }

        public DateTime RetrievedOn { get; set; }
>>>>>>> a21b911 (Align EF models with existing schema)
    }
}
