using System.ComponentModel.DataAnnotations.Schema;

namespace GradeTrackerAPI12978.Entities
{
    public class LearningModule12978
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public string? Code { get; set; }
        public int Credits { get; set; }
        public ICollection<Assignment12978> Assignments { get; set; } = new List<Assignment12978>();
    }
}
