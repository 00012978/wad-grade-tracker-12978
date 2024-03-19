using GradeTracker12978.DAL.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeTracker12978.DAL.Data.Configuration
{
    public static class AssignmentsContextConfiguration
    {
        public static void ConfigureAssignments(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assignment12978>()
                .HasOne(x => x.AssignmentType)
                .WithMany(x => x.Assignments)
                .HasForeignKey(x => x.AssignmentTypeId);

            modelBuilder.Entity<Assignment12978>()
                .HasOne(x => x.Module)
                .WithMany(x => x.Assignments)
                .HasForeignKey(x => x.ModuleId);
        }
    }
}
