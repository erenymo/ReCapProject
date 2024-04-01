using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;

namespace Core.Aspects.Autofac.Validation;

public class ValidationAspect:MethodInterception
{
    private Type _validatorType;
    public ValidationAspect(Type validatorType)
    {
        if (!typeof(IValidator).IsAssignableFrom(validatorType))
        {
            throw new System.Exception("Bu bir doğrulama sınıfı değil");
        }

        _validatorType = validatorType;
    }
    protected override void OnBefore(IInvocation invocation)
    {
        var validator = (IValidator)Activator.CreateInstance(_validatorType); //Create an instance of validatorType
        var entityType = _validatorType.BaseType.GetGenericArguments()[0]; // find validatorType's base type and get the first generic argument
        var entities = invocation.Arguments.Where(t => t.GetType() == entityType); // find the parameters that equals to entityType of method
        foreach (var entity in entities)
        {
            ValidationTool.Validate(validator,entity);
        }
    }
}