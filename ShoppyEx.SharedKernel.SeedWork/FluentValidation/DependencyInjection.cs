using FluentValidation;
using Microsoft.Extensions.DependencyInjection;


namespace ShoppyEx.SharedKernel.SeedWork.FluentValidation
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCustomValidators<TType>(this IServiceCollection services)
        {
            return services.Scan(scan => scan
                .FromAssemblyOf<TType>()
                .AddClasses(c => c.AssignableTo(typeof(IValidator<>)))
                .AsImplementedInterfaces()
                .WithTransientLifetime());
        }
    }
}
