namespace GradeTracker12978.DAL.Data.Entities
{
    public class Assignment12978
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public int Weighting { get; set; }
        public DateTime DueDate { get; set; }
        public double Grade { get; set; }
        public int AssignmentTypeId { get; set; }
        public required AssignmentType12978 AssignmentType { get; set; }
        public int ModuleId { get; set; }
        public required LearningModule12978 Module { get; set; }
    }
}
