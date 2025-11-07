
using System;

namespace UniSight.Models
{
    public class PullRequest
    {
        /// <summary>
        /// Id of the PullRequest
        /// </summary>
        public Guid Id { get; set; }
        public string Author { get; set; }
        public string Status { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string Comments { get; set; }
    }
}
