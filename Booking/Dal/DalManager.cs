using Dal.API;
using Dal.Implementation;
using Dal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Dal
{
    public class DalManager
    {
        public OwnersRepo Owners { get; }
        public AptDetailsRepo AptDetail { get; }
        public TouristsRepo Tourists { get; }
        public WantedAptsRepo WantedApts { get; }
        public DalManager(string connString)
        {
            ServiceCollection services = new();
            services.AddDbContext<DBContext>((op => op.UseSqlServer(connString)));

            services.AddScoped<IOwnersRepo, OwnersRepo>();
            services.AddScoped<IAptDetailRepo, AptDetailsRepo>();
            services.AddScoped<ITouristsRepo, TouristsRepo>();
            services.AddScoped<IWantedAptsRepo, WantedAptsRepo>();

            ServiceProvider serviceProvider = services.BuildServiceProvider();

            AptDetail = (AptDetailsRepo)serviceProvider.GetRequiredService<IAptDetailRepo>();
            Tourists = (TouristsRepo)serviceProvider.GetRequiredService<ITouristsRepo>();
            Owners = (OwnersRepo)serviceProvider.GetRequiredService<IOwnersRepo>();
            WantedApts = (WantedAptsRepo)serviceProvider.GetRequiredService<IWantedAptsRepo>();
        }
    }
}
