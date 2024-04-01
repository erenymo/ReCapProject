using Entities.Concrete;
using FluentValidation;

namespace Business.ValidatorRules.FluentValidation;

public class CarValidator:AbstractValidator<Car>
{
    public CarValidator()
    {
        RuleFor(c => c.BrandId).NotEmpty();
        RuleFor(c => c.ColorId).NotEmpty();
        RuleFor(c => c.Description).NotEmpty();
        RuleFor(c => c.ModelYear).NotEmpty();
        RuleFor(c => c.DailyPrice).NotEmpty();
    }
}