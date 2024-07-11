using BL.API;
using BL.BLImplementation;
using Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection collection)
    {
        collection.AddScoped<IAptDetailsService, AptDetailsService>();
        collection.AddRepositories();
        return collection;
    }
}