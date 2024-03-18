namespace GradeTrackerAPI12978.Data.DTOs.Assignments
{
    public class AssignmentCreateDTO12978
    {
        public required string Title { get; set; }
        public int Weighting { get; set; }
        public DateTime DueDate { get; set; }
        public double Grade { get; set; }
        public int AssignmentTypeId { get; set; }
        public int ModuleId { get; set; }
    }
}
