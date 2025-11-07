
using System;

namespace UniSight.Models
{
    /// <summary>
    /// Represents a pull request in the system.
    /// </summary>
    public class PullRequest
    {
        public int ID { get; set; }
        public string Repository { get; set; }
        public string Author { get; set; }
        public string Status { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public int CommentCount { get; set; }
        public string Project { get; set; }
        public DateTime RetrievedOn { get; set; }
    }
}
