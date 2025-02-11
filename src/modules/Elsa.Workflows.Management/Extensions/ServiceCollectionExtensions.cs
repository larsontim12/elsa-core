

// ReSharper disable once CheckNamespace

using Elsa.Workflows;

namespace Microsoft.Extensions.DependencyInjection;

/// <summary>
/// Provides extension methods to <see cref="IServiceCollection"/> for various kinds of services and providers. 
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Registers a <see cref="IActivityProvider"/>.
    /// </summary>
    public static IServiceCollection AddActivityProvider<T>(this IServiceCollection services) where T : class, IActivityProvider
    {
        return services
            .AddScoped<T>()
            .AddScoped<IActivityProvider, T>(sp => sp.GetRequiredService<T>());
    }
}