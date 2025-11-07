
using System;

namespace UniSight.Models
{
    public class WorkItemHistory
    {
        /// <summary>
        /// Id of the WorkItemHistory
        /// </summary>
        public Guid Id { get; set; }
        public Guid WorkItem { get; set; }
        public string Assignee { get; set; }
        public string AssignedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
