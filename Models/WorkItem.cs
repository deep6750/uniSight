
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniSight.Models
{
    [Table("WorkItem")]
    public class WorkItem
    {
        [Key]
        [Column("WorkItemID")]
        public int WorkItemId { get; set; }

        [Column("WorkItemType")]
        public string WorkItemType { get; set; }

        public string Title { get; set; }

        [Column("State")]
        public string State { get; set; }

        public string Project { get; set; }

        public decimal? OriginalEstimate { get; set; }

        public decimal? CompletedWork { get; set; }

        [Column("AssignedTo")]
        public string AssignedTo { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? ClosedDate { get; set; }

        public DateTime RetrievedOn { get; set; }
    }
}
