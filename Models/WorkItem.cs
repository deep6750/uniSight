
using System;

namespace UniSight.Models
{
    public class WorkItem
    {
        /// <summary>
        /// Id of the WorkItem
        /// </summary>
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Project { get; set; }
        public string OriginalEstimate { get; set; }
        public string CompletedWork { get; set; }
    }
}
