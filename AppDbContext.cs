
using Microsoft.EntityFrameworkCore;
using UniSight.Models;

namespace UniSight
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<PullRequest> PullRequests { get; set; }
        public DbSet<WorkItem> WorkItems { get; set; }
        public DbSet<WorkItemHistory> WorkItemHistories { get; set; }
        public DbSet<CodeQuality> CodeQualities { get; set; }
    }
}
