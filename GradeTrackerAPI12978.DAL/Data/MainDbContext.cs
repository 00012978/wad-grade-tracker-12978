using GradeTracker12978.DAL.Data.Configuration;
using GradeTracker12978.DAL.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GradeTracker12978.DAL.Data
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

            modelBuilder.ConfigureAssignments();

            SeedAssignmentTypes(modelBuilder);
        }

        private void SeedAssignmentTypes(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedAssignmentTypes();
        }
    }
}
