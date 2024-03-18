using GradeTrackerAPI12978.Entities;
using Microsoft.EntityFrameworkCore;

namespace GradeTrackerAPI12978.Data
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options) { }
        public DbSet<LearningModule12978> Modules { get; set; }
        public DbSet<Assignment12978> Assignments { get; set; }
        public DbSet<AssignmentType12978> AssignmentTypes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Assignment12978>()
                .HasOne(x => x.AssignmentType)
                .WithMany(x => x.Assignments)
                .HasForeignKey(x => x.AssignmentTypeId);

            modelBuilder.Entity<Assignment12978>()
                .HasOne(x => x.Module)
                .WithMany(x => x.Assignments)
                .HasForeignKey(x => x.ModuleId);

            Seed(modelBuilder);
        }

        private void Seed(ModelBuilder modelBuilder)
        {
            // Seed AssignmentType entity
            modelBuilder.Entity<AssignmentType12978>().HasData(
                new AssignmentType12978 { Id = 1, Name = "Coursework" },
                new AssignmentType12978 { Id = 2, Name = "In-Class Test" },
                new AssignmentType12978 { Id = 3, Name = "Exam" },
                new AssignmentType12978 { Id = 4, Name = "Take-Home Exam" },
                new AssignmentType12978 { Id = 5, Name = "Portfolio Entry" },
                new AssignmentType12978 { Id = 6, Name = "Presentation" }
            );
        }
    }
}
