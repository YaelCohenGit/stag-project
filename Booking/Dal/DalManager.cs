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
        public DalManager(string connString)
        {
            // כאן הגדרנו אוסף של מחלקות שרות
            ServiceCollection services = new();
            // מוסיפים לאוסף אוביקטים
            services.AddDbContext<DBContext>((op => op.UseSqlServer(connString)));

            services.AddScoped<IOwnersRepo, OwnersRepo>();
            services.AddScoped<IAptDetailRepo, AptDetailsRepo>();
            services.AddScoped<ITouristsRepo, TouristsRepo>();

            // הגדרת מנהל למחלקות השרות שנקרא פרווידר
            ServiceProvider serviceProvider = services.BuildServiceProvider();

            AptDetail = (AptDetailsRepo)serviceProvider.GetRequiredService<IAptDetailRepo>();
            Tourists = (TouristsRepo)serviceProvider.GetRequiredService<ITouristsRepo>();
            Owners = (OwnersRepo)serviceProvider.GetRequiredService<IOwnersRepo>();
        }
    }
}
