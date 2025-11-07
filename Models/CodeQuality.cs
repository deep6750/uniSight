
using System;

namespace UniSight.Models
{
    /// <summary>
    /// Represents code quality metrics for a project module.
    /// </summary>
    public class CodeQuality
    {
        public int QualityRecordID { get; set; }
        public string Project { get; set; }
        public string Module { get; set; }
        public decimal? TechDebtScore { get; set; }
        public decimal? ArchitectureScore { get; set; }
        public int? CodeIssuesCount { get; set; }
        public DateTime ScanDate { get; set; }
        public DateTime RetrievedOn { get; set; }
    }
}
