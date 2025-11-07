
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniSight.Models
{
    [Table("WorkItemHistory")]
    public class WorkItemHistory
    {
        [Key]
        [Column("HistoryID")]
        public int HistoryId { get; set; }

        [Column("WorkItemID")]
        public int WorkItemId { get; set; }

        public DateTime ChangedDate { get; set; }

        public string ChangedBy { get; set; }

        public string OldState { get; set; }

        public string NewState { get; set; }

        public string FieldChanged { get; set; }

        public string OldValue { get; set; }

        public string NewValue { get; set; }
    }
}
