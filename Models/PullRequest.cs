
using System;

namespace UniSight.Models
{
    public class PullRequest
    {
        /// <summary>
<<<<<<< HEAD
        /// Id of the PullRequest
        /// </summary>
        public Guid Id { get; set; }
        public string Author { get; set; }
        public string Status { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string Comments { get; set; }
=======
        /// Azure DevOps pull request identifier (maps to ID)
        /// </summary>
        public int Id { get; set; }

        public string Repository { get; set; } = null!;

        public string Author { get; set; } = null!;

        public string? Status { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime? CompletionDate { get; set; }

        public int CommentCount { get; set; }

        public string Project { get; set; } = null!;

        public DateTime RetrievedOn { get; set; }
>>>>>>> a21b911 (Align EF models with existing schema)
    }
}
