
using System;

namespace UniSight.Models
{
    /// <summary>
    /// Represents a work item in the system.
    /// </summary>
    public class WorkItem
    {
        public int WorkItemID { get; set; }
        public string WorkItemType { get; set; }
        public string Title { get; set; }
        public string State { get; set; }
        public string Project { get; set; }
        public decimal? OriginalEstimate { get; set; }
        public decimal? CompletedWork { get; set; }
        public string AssignedTo { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public DateTime RetrievedOn { get; set; }
    }
}
