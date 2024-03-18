namespace GradeTrackerAPI12978.Entities
{
    public class AssignmentType12978
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public ICollection<Assignment12978> Assignments { get; set; } = new List<Assignment12978>();
    }
}
