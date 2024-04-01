using Entities.Concrete;
using FluentValidation;

namespace Business.ValidatorRules.FluentValidation;

public class RentalValidator:AbstractValidator<Rental>
{
    public RentalValidator()
    {
        RuleFor(r => r.RentDate).NotEmpty();
        RuleFor(r=>r.CarId).NotEmpty();
        RuleFor(r => r.CustomerId).NotEmpty();
    }
}