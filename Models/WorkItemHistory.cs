
using System;

namespace UniSight.Models
{
    public class WorkItemHistory
    {
        /// <summary>
<<<<<<< HEAD
        /// Id of the WorkItemHistory
        /// </summary>
        public Guid Id { get; set; }
        public Guid WorkItem { get; set; }
        public string Assignee { get; set; }
        public string AssignedBy { get; set; }
        public DateTime CreatedAt { get; set; }
=======
        /// Unique history record identifier (maps to HistoryID)
        /// </summary>
        public int HistoryId { get; set; }

        public int WorkItemId { get; set; }

        public DateTime ChangedDate { get; set; }

        public string? ChangedBy { get; set; }

        public string? OldState { get; set; }

        public string? NewState { get; set; }

        public string? FieldChanged { get; set; }

        public string? OldValue { get; set; }

        public string? NewValue { get; set; }
>>>>>>> a21b911 (Align EF models with existing schema)
    }
}
