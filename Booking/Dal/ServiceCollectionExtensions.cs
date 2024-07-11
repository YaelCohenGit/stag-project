using Dal.API;
using Dal.Implementation;
using Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static void AddRepositories(this IServiceCollection collection)
    {
        collection.AddScoped<IAptDetailRepo, AptDetailsRepo>();
    }
}