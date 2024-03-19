using FluentValidation;
using GradeTracker12978.DAL.Data.DTOs.Modules;

namespace GradeTrackerAPI12978.Validation
{
    public class ModuleValidator : AbstractValidator<ModuleCreateDTO12978>
    {
        public ModuleValidator()
        {
            RuleFor(m => m.Title)
                .NotEmpty().WithMessage("Title is required")
                .MinimumLength(1).WithMessage("Minimum length is 1");
            RuleFor(m => m.Credits)
                .InclusiveBetween(0, 120).WithMessage("The number of credits must be between 0 and 120");
        }
    }
}
