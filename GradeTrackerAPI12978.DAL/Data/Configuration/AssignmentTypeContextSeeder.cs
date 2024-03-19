using GradeTracker12978.DAL.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeTracker12978.DAL.Data.Configuration
{
    public static class AssignmentTypeContextSeeder
    {
        public static void SeedAssignmentTypes(this ModelBuilder modelBuilder)
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
