using Dal.API;
using Dal.Implementation;
using Dal.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Dal
{
    public class DalManager
    {
        /* public IOwnersRepo owners { get; }
         public IAptDetailRepo AptDetail { get; }
         public ITouristsRepo Tourists { get; }

         public DalManager()
         {
             // באן הגדרנו אוסף של מחלקות שרות
             ServiceCollection services = new();
             // מוסיפים לאוסף אוביקטים
             services.AddDbContext<DBContext>();
             services.AddScoped<IOwnersRepo, OwnersRepo>();
             services.AddScoped<IAptDetailRepo, AptDetailRepo>();
             services.AddScoped<ITouristsRepo, TouristsRepo>();

             // הגדרת מנהל למחלקות השרות שנקרא פרווידר
             ServiceProvider serviceProvider = services.BuildServiceProvider();

             AptDetail = serviceProvider.GetRequiredService<IAptDetailRepo>();
             Tourists = serviceProvider.GetRequiredService<ITouristsRepo>();
             owners = serviceProvider.GetRequiredService<IOwnersRepo>();


         }*/
        public OwnersRepo owners { get; }
        public AptDetailRepo AptDetail { get; }
        public TouristsRepo Tourists { get; }
        public DalManager()
        {
            // באן הגדרנו אוסף של מחלקות שרות
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
            owners = (OwnersRepo)serviceProvider.GetRequiredService<IOwnersRepo>();


        }

    }
}
