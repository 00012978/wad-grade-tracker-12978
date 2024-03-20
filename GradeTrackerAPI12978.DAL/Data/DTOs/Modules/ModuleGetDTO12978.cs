namespace GradeTracker12978.DAL.Data.DTOs.Modules
{
    public class ModuleGetDTO12978
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public string? Code { get; set; }
        public int Credits { get; set; }
        public double? TotalMark { get; set; }
        public ICollection<string> Assignments { get; set; } = new List<string>();
    }
}
