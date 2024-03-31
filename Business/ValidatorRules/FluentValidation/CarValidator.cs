using Entities.Concrete;
using FluentValidation;

namespace Business.ValidatorRules.FluentValidation;

public class CarValidator:AbstractValidator<Car>
{
    public CarValidator()
    {
        
    }
}