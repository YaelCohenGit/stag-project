using BL.BLImplementation;
using Dal;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLManager
    {

        public OwnerToAptDetailsRepo ownerToAptDetailsRepo { get; }

        public BLManager()
        {
            ServiceCollection services = new();
            services.AddScoped<DalManager>();
            services.AddScoped<OwnerToAptDetailsRepo>();

            ServiceProvider servicesProvider = services.BuildServiceProvider();

            ownerToAptDetailsRepo = servicesProvider.GetService<OwnerToAptDetailsRepo>();

        }
    }
}
