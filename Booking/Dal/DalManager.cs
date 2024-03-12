using Dal.API;
using Dal.Implementation;
using Dal.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class DalManager
    {
        public OwnersRepo owners { get;}
        public AptDetailRepo AptDetail { get;}
        public TouristsRepo Tourists { get;}

        public DalManager()
        {
            // באן הגדרנו אוסף של מחלקות שרות
            ServiceCollection services = new();
            // מוסיפים לאוסף אוביקטים
            services.AddDbContext<DBContext>();
            services.AddScoped<IRepository<Owner>, OwnersRepo>();
            services.AddScoped<IRepository<AptDetails>, AptDetailRepo>();
            services.AddScoped<IRepository<Tourist>, TouristsRepo>();

            // הגדרת מנהל למחלקות השרות שנקרא פרווידר
            ServiceProvider serviceProvider = services.BuildServiceProvider();

            owners = serviceProvider.GetRequiredService<OwnersRepo>();
            AptDetail = serviceProvider.GetRequiredService<AptDetailRepo>();
            Tourists = serviceProvider.GetRequiredService<TouristsRepo>();

        }
    }
}
