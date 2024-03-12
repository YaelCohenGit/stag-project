using BL;
using Dal.Implementation;
using Dal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// these Controllers are in the right place
namespace Dal.API
{
    //הקונטרולר ניגש לסרביס והסרביס ניגש לרפו

    [Route("api/[controller]")]
    [ApiController]
    public class AptDetailsController : ControllerBase
    {
        IAptDetailsService aptDetailsService;
        public AptDetailsController(IAptDetailsService aptDetailsService)
        {
            this.aptDetailsService = aptDetailsService;
        }

        DBContext dbContext;

        [HttpGet("getAllAptDetails/{id}")]
        public async Task<AptDetails?> GetAsync(int id)
        {
            AptDetailRepo a = new(dbContext);
            var e = await a.GetSingleAsync(id);
            return e;
        }


        public void Create(string? country, string? city, string? street, string aptStyle, string? beds, string? pricePerNight)
        {
            AptDetails aptDetail = new AptDetails(country, city, street, aptStyle, beds, pricePerNight);
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

        public string Read(AptDetails a)
        {
            return a.Country + " " + a.City + " " + a.Street + " " + a.AptStyle + " " + a.Beds + " " + a.PricePerNight + " ";
        }
    }
}
