using FluentValidation;
using GradeTracker12978.DAL.Data.DTOs.Assignments;

namespace GradeTrackerAPI12978.Validation
{
    public class AssignmentValidator : AbstractValidator<AssignmentCreateDTO12978>
    {
        public AssignmentValidator()
        {
            RuleFor(a => a.Title)
                .NotEmpty().WithMessage("Title is required")
                .MinimumLength(1).WithMessage("Minimum length is 1");

            RuleFor(a => a.Weighting)
                .InclusiveBetween(0, 100).WithMessage("Assessment weighting can be between 0 and 100%");

            RuleFor(a => a.Grade)
                .InclusiveBetween(0, 100).WithMessage("Grade must be between 0 and 100");
        }
    }
}
