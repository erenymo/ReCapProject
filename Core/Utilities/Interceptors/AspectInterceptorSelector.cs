using System.Reflection;
using Castle.DynamicProxy;

namespace Core.Utilities.Interceptors;

public class AspectInterceptorSelector:IInterceptorSelector
{
    public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
    {
        var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>
            (true).ToList(); // Get class' attributes
        var methodAttributes = type.GetMethod(method.Name)
            .GetCustomAttributes<MethodInterceptionBaseAttribute>(true); // Get method's attributes (validation,log,cache...)
        classAttributes.AddRange(methodAttributes);

        return classAttributes.OrderBy(x => x.Priority).ToArray();
    }
}