
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniSight.Models
{
    [Table("PullRequest")]
    public class PullRequest
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        public string Repository { get; set; }
        public string Author { get; set; }
        public string Status { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        [Column("CommentCount")]
        public int CommentCount { get; set; }
        public string Project { get; set; }
        public DateTime RetrievedOn { get; set; }
    }
}
