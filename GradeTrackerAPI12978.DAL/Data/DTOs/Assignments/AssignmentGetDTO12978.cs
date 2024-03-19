namespace GradeTracker12978.DAL.Data.DTOs.Assignments
{
    public class AssignmentGetDTO12978
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Weighting { get; set; }
        public DateTime DueDate { get; set; }
        public double Grade { get; set; }
        public string AssignmentTypeName { get; set; }
        public string ModuleTitle { get; set; }
    }
}
