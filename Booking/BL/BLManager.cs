using BL.BLImplementation;
using Dal;
using Microsoft.Extensions.DependencyInjection;

namespace BL;

public class BLManager
{

    public OwnerToAptDetailsRepo ownerToAptDetailsRepo { get; }
    public IAptDetailsService aptDetailsService { get; }

    public BLManager()
    {
        ServiceCollection services = new();
        services.AddScoped<DalManager>();
        services.AddScoped<OwnerToAptDetailsRepo>();
        services.AddScoped<IAptDetailsService,AptDetailsService>();

        ServiceProvider servicesProvider = services.BuildServiceProvider();

        ownerToAptDetailsRepo = servicesProvider.GetRequiredService<OwnerToAptDetailsRepo>();
        aptDetailsService = servicesProvider.GetRequiredService<IAptDetailsService>();
    }
}
