
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
<<<<<<< HEAD
=======
        public DbSet<CodeQuality> CodeQualities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<WorkItem>(entity =>
            {
                entity.ToTable("WorkItem");
                entity.HasKey(e => e.WorkItemId);

                entity.Property(e => e.WorkItemId)
                      .HasColumnName("WorkItemID")
                      .ValueGeneratedNever();
                entity.Property(e => e.WorkItemType).HasColumnName("WorkItemType").HasMaxLength(50);
                entity.Property(e => e.Title).HasColumnName("Title").HasMaxLength(300);
                entity.Property(e => e.State).HasColumnName("State").HasMaxLength(50);
                entity.Property(e => e.Project).HasColumnName("Project").HasMaxLength(200);
                entity.Property(e => e.OriginalEstimate).HasColumnType("decimal(10,2)");
                entity.Property(e => e.CompletedWork).HasColumnType("decimal(10,2)");
                entity.Property(e => e.AssignedTo).HasColumnName("AssignedTo").HasMaxLength(150);
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.ClosedDate).HasColumnType("datetime");
                entity.Property(e => e.RetrievedOn)
                      .HasColumnType("datetime")
                      .HasDefaultValueSql("GETUTCDATE()")
                      .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WorkItemHistory>(entity =>
            {
                entity.ToTable("WorkItemHistory");
                entity.HasKey(e => e.HistoryId);

                entity.Property(e => e.HistoryId).HasColumnName("HistoryID");
                entity.Property(e => e.WorkItemId).HasColumnName("WorkItemID");
                entity.Property(e => e.ChangedDate).HasColumnType("datetime");
                entity.Property(e => e.ChangedBy).HasColumnName("ChangedBy").HasMaxLength(150);
                entity.Property(e => e.OldState).HasColumnName("OldState").HasMaxLength(50);
                entity.Property(e => e.NewState).HasColumnName("NewState").HasMaxLength(50);
                entity.Property(e => e.FieldChanged).HasColumnName("FieldChanged").HasMaxLength(200);
                entity.Property(e => e.OldValue).HasColumnName("OldValue").HasMaxLength(500);
                entity.Property(e => e.NewValue).HasColumnName("NewValue").HasMaxLength(500);

                entity.HasOne<WorkItem>()
                      .WithMany()
                      .HasForeignKey(e => e.WorkItemId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<PullRequest>(entity =>
            {
                entity.ToTable("PullRequest");
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                      .HasColumnName("ID")
                      .ValueGeneratedNever();
                entity.Property(e => e.Repository).HasColumnName("Repository").HasMaxLength(200);
                entity.Property(e => e.Author).HasColumnName("Author").HasMaxLength(150);
                entity.Property(e => e.Status).HasColumnName("Status").HasMaxLength(50);
                entity.Property(e => e.CreationDate).HasColumnType("datetime");
                entity.Property(e => e.CompletionDate).HasColumnType("datetime");
                entity.Property(e => e.CommentCount).HasColumnName("CommentCount").HasDefaultValue(0);
                entity.Property(e => e.Project).HasColumnName("Project").HasMaxLength(200);
                entity.Property(e => e.RetrievedOn)
                      .HasColumnType("datetime")
                      .HasDefaultValueSql("GETUTCDATE()")
                      .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CodeQuality>(entity =>
            {
                entity.ToTable("CodeQuality");
                entity.HasKey(e => e.QualityRecordId);

                entity.Property(e => e.QualityRecordId).HasColumnName("QualityRecordID");
                entity.Property(e => e.Project).HasColumnName("Project").HasMaxLength(200);
                entity.Property(e => e.Module).HasColumnName("Module").HasMaxLength(200);
                entity.Property(e => e.TechDebtScore).HasColumnType("decimal(10,2)");
                entity.Property(e => e.ArchitectureScore).HasColumnType("decimal(10,2)");
                entity.Property(e => e.CodeIssuesCount).HasColumnName("CodeIssuesCount");
                entity.Property(e => e.ScanDate).HasColumnType("datetime");
                entity.Property(e => e.RetrievedOn)
                      .HasColumnType("datetime")
                      .HasDefaultValueSql("GETUTCDATE()")
                      .ValueGeneratedOnAdd();
            });
        }
>>>>>>> a21b911 (Align EF models with existing schema)
    }
}
