namespace Domain.Validators;

public class FullnameValidator: AbstractValidator<Fullname>
{
    public FullnameValidator()
    {
        RuleFor(x => x.FirstName)
            .NotNull().WithMessage("First name is required")
            .NotEmpty().WithMessage("First name cannot be empty")
            .MaximumLength(20).WithMessage("First name must not exceed 20 characters");

        RuleFor(x => x.LastName)
            .NotNull().WithMessage("Last name is required")
            .NotEmpty().WithMessage("Last name cannot be empty")
            .MaximumLength(20).WithMessage("Last name must not exceed 20 characters");

        RuleFor(x => x.MiddleName)
            .NotEmpty().WithMessage("Middle name cannot be empty")
            .MaximumLength(20).WithMessage("Middle name must not exceed 20 characters");
    }
}