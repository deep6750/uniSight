using System;

namespace UniSight.Models
{
    public class CodeQuality
    {
        /// <summary>
        /// Unique identifier for the code quality record (maps to QualityRecordID)
        /// </summary>
        public int QualityRecordId { get; set; }

        public string? Project { get; set; }

        public string? Module { get; set; }

        public decimal? TechDebtScore { get; set; }

        public decimal? ArchitectureScore { get; set; }

        public int? CodeIssuesCount { get; set; }

        public DateTime ScanDate { get; set; }

        public DateTime RetrievedOn { get; set; }
    }
}

