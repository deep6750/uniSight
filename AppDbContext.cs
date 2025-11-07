
using Microsoft.EntityFrameworkCore;
using UniSight.Models;

namespace UniSight
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<WorkItem> WorkItems { get; set; }
        public DbSet<WorkItemHistory> WorkItemHistories { get; set; }
        public DbSet<PullRequest> PullRequests { get; set; }
    }
}
