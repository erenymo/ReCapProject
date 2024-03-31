using Entities.Concrete;
using FluentValidation;

namespace Business.ValidatorRules.FluentValidation;

public class UserValidator:AbstractValidator<User>
{
    public UserValidator()
    {
        RuleFor(u => u.FirstName).NotEmpty();
        RuleFor(u => u.LastName).NotEmpty();
        RuleFor(u => u.Email).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
        RuleFor(u => u.Email).EmailAddress().WithMessage("Geçerli bir email adresi giriniz.");
        RuleFor(u => u.Password).NotEmpty();
    }
}
