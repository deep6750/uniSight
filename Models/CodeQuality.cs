using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniSight.Models
{
    [Table("CodeQuality")]
    public class CodeQuality
    {
        [Key]
        [Column("QualityRecordID")]
        public int QualityRecordId { get; set; }

        public string Project { get; set; }

        public string Module { get; set; }

        public decimal? TechDebtScore { get; set; }

        public decimal? ArchitectureScore { get; set; }

        public int? CodeIssuesCount { get; set; }

        public DateTime ScanDate { get; set; }

        public DateTime RetrievedOn { get; set; }
    }
}

