
using System;

namespace UniSight.Models
{
    /// <summary>
    /// Represents the history of changes to a work item.
    /// </summary>
    public class WorkItemHistory
    {
        public int HistoryID { get; set; }
        public int WorkItemID { get; set; }
        public DateTime ChangedDate { get; set; }
        public string ChangedBy { get; set; }
        public string OldState { get; set; }
        public string NewState { get; set; }
        public string FieldChanged { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
    }
}
