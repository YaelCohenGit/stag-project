using Dal.Models;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnersController : ControllerBase
    {
        
        public void Create(string? Tel, string? Email, int AptDetail)
        {
            Owner o = new Owner() { Tel = Tel, Email = Email, AptDetailsId = AptDetail };
            
        }
        public void Updete(Owner owner, string? Tel, string? Email)
        {
            owner.Email = Email;
            owner.Tel = Tel;
        }

        //public void Delete(Owner t)
        //{

        //}

        public string Read(Owner O)
        {
            return O.Tel + " " + O.Email;
        }
    }
}
