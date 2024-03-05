using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.API
{
    internal interface IAptDetailRepo //: IRepository<AptDetails>
    {
        // public void Create(string? country, string? city, string? street, string aptStyle, string? beds, string? pricePerNight);

        public void Create(AptDetails item);
        public void Updete(AptDetails aptDetail, string? country, string? city, string? street, string aptStyle, string? beds, string? pricePerNight);

        //public void Delete(Owner t)

        public string Read(AptDetails a);

    }
}
