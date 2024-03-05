using Dal.API;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Implementation
{
    public class AptDetailRepo : IAptDetailRepo
    {

        //public void Create(string? country,string? city,string? street, string aptStyle, string? beds, string? pricePerNight)
        //{
        //    AptDetails aptDetail = new AptDetails(country, city, street, aptStyle, beds, pricePerNight);
        //}


        public void Create(AptDetails item)
        {
            DBContext.AptDetails.Add(item);
            //DBContext.SaveChanges();
        }


        public void Updete(AptDetails aptDetail, string? country, string? city, string? street, string aptStyle, string? beds, string? pricePerNight)
        {
            aptDetail.Country = country;
            aptDetail.City = city;
            aptDetail.Street = street;
            aptDetail.AptStyle = aptStyle;
            aptDetail.Beds = beds;
            aptDetail.PricePerNight = pricePerNight;
        }

        //public void Delete(Owner t)
        //{

        //}

        //public string Read(AptDetails a)
        //{
        //    return a.Country + " " + a.City + " "+ a.Street + " " + a.AptStyle + " " + a.Beds + " " + a.PricePerNight + " ";
        //}
        public string Read(AptDetails a)
        {
            return "";
            //DBContext.AptDetails.ToList(a.Country, a.City);
        }

        public void Create(string? country, string? city, string? street, string aptStyle, string? beds, string? pricePerNight)
        {
            throw new NotImplementedException();
        }
    }
}
