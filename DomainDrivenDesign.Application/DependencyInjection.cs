using DomainDrivenDesign.Domain.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace DomainDrivenDesign.Application;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(
        this IServiceCollection services)
    {
        services.AddMediatR(cfr =>
        {
            cfr.RegisterServicesFromAssemblies(
                Assembly.GetExecutingAssembly(),
                typeof(Entity).Assembly);
        });

        return services;
    }
}
