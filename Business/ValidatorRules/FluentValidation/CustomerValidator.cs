using Entities.Concrete;
using FluentValidation;

namespace Business.ValidatorRules.FluentValidation;

public class CustomerValidator:AbstractValidator<Customer>
{
    public CustomerValidator()
    {
        RuleFor(c => c.CompanyName).NotEmpty();
        RuleFor(c => c.UserId).NotEmpty();
    }
}