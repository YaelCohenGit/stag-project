using BL.API;
using BL.BLImplementation;
using Dal;
using Microsoft.Extensions.DependencyInjection;

namespace BL;

public class BLManager
{
    //public OwnerToAptDetailsRepo ownerToAptDetailsRepo { get; }
    public AptDetailsService _aptDetailsService { get; }
    public BLManager()
    {
        ServiceCollection services = new();
        services.AddScoped<DalManager>();
        //services.AddScoped<OwnerToAptDetailsRepo>();
        services.AddScoped<IAptDetailsService, AptDetailsService>();
        services.AddScoped<IAptDetailsService, AptDetailsService>();
        ServiceProvider servicesProvider = services.BuildServiceProvider();
        _aptDetailsService = (AptDetailsService)servicesProvider.GetRequiredService<IAptDetailsService>();//fail
        _aptDetailsService = servicesProvider.GetService<AptDetailsService>();
        //ownerToAptDetailsRepo = servicesProvider.GetRequiredService<OwnerToAptDetailsRepo>();

    }
}
