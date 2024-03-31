using Entities.Concrete;
using FluentValidation;

namespace Business.ValidatorRules.FluentValidation;

public class ColorValidator:AbstractValidator<Color>
{
    public ColorValidator()
    {
        RuleFor(c => c.Name).MinimumLength(2);
    }
}