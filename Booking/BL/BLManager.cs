using BL.API;
using BL.BLImplementation;
using Dal;
using Microsoft.Extensions.DependencyInjection;

namespace BL;

public class BLManager
{
    /*public OwnerToAptDetailsRepo ownerToAptDetailsRepo { get; }*/
    public IAptDetailsService _aptDetailsService { get; }

    public BLManager()
    {
        ServiceCollection services = new();
        services.AddScoped<DalManager>();

        services.AddScoped<OwnerToAptDetailsRepo>();
      /*  services.AddScoped<AptDetailsService>();*/

        ServiceProvider servicesProvider = services.BuildServiceProvider();

        //ownerToAptDetailsRepo = (OwnerToAptDetailsRepo)servicesProvider.GetRequiredService<IOwnersService>();
        _aptDetailsService = servicesProvider.GetService<AptDetailsService>();
        //ownerToAptDetailsRepo = servicesProvider.GetRequiredService<OwnerToAptDetailsRepo>();

    }
}
