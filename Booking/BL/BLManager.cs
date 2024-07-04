﻿using BL.API;
using BL.BLImplementation;
using Dal;
using Microsoft.Extensions.DependencyInjection;

namespace BL;

public class BLManager
{
    //public OwnerToAptDetailsRepo ownerToAptDetailsRepo { get; }
    public AptDetailsService aptDetailsService { get; }
    public BLManager(string connString)
    {
        ServiceCollection services = new();
        services.AddScoped<DalManager>();
        services.AddScoped(d => new DalManager(connString));
        services.AddScoped<IAptDetailsService, AptDetailsService>();

        ServiceProvider servicesProvider = services.BuildServiceProvider();
        aptDetailsService = (AptDetailsService)servicesProvider.GetRequiredService<IAptDetailsService>();
    }
}
