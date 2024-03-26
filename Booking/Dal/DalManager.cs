using Dal.API;
using Dal.Implementation;
using Dal.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Dal
{
    public class DalManager
    {
        public OwnersRepo Owners { get; }
        public AptDetailRepo AptDetail { get; }
        public TouristsRepo Tourists { get; }
        public DalManager()
        {
            // כאן הגדרנו אוסף של מחלקות שרות
            ServiceCollection services = new();
            // מוסיפים לאוסף אוביקטים
            services.AddDbContext<DBContext>();

            services.AddScoped<IOwnersRepo, OwnersRepo>();
            services.AddScoped<IAptDetailRepo, AptDetailRepo>();
            services.AddScoped<ITouristsRepo, TouristsRepo>();

            // הגדרת מנהל למחלקות השרות שנקרא פרווידר
            ServiceProvider serviceProvider = services.BuildServiceProvider();

            AptDetail = (AptDetailRepo)serviceProvider.GetRequiredService<IAptDetailRepo>();
            Tourists = (TouristsRepo)serviceProvider.GetRequiredService<ITouristsRepo>();
            Owners = (OwnersRepo)serviceProvider.GetRequiredService<IOwnersRepo>();
        }

    }
}
