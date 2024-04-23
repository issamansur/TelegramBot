namespace Domain.Validators;

public class PersonValidator: AbstractValidator<Person>
{
    public PersonValidator()
    {
        RuleFor(x => x.Fullname)
            .NotNull().WithMessage("Fullname is required")
            .SetValidator(new FullnameValidator());

        RuleFor(x => x.Gender)
            .NotNull().WithMessage("Gender is required")
            .IsInEnum().WithMessage("Gender is invalid");
        
        RuleFor(x => x.BirthDate)
            .NotNull().WithMessage("Birth date is required")
            .LessThan(DateTime.Now.AddYears(-150)).WithMessage("Birth date is invalid");
        
        RuleFor(x => x.PhoneNumber)
            .NotNull().WithMessage("Phone number is required")
            .Matches(@"^\d{11}$").WithMessage("Phone number is invalid");
        
        RuleFor(x => x.TelegramId)
            .NotNull().WithMessage("Telegram ID is required")
            .NotEmpty().WithMessage("Telegram ID cannot be empty")
            .Must(x => int.TryParse(x, out _)).WithMessage("Telegram ID is invalid");
    }
}