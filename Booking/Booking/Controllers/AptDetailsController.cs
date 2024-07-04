using BL;
using BL.API;
using BL.BLImplementation;
using BL.Models;
using Microsoft.AspNetCore.Mvc;
namespace Booking.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AptDetailsController : ControllerBase
{
    AptDetailsService aptDetailsService;
    public AptDetailsController(BLManager blManager)
    {
        this.aptDetailsService = blManager.aptDetailsService;
    }

    [HttpGet]
    public ActionResult<List<AptDetailsDTO>> GetAll()
    {
        return aptDetailsService.GetAll();
    }

    [HttpGet("{id}")]
    public async Task<AptDetailsDTO?> GetAsync(int id)
    {
        return await aptDetailsService.GetById(id);
    }


    //public string Read(BLAptDetails a)
    //{
    //    return a.Country + " " + a.City + " " + a.Street + " " + a.AptStyle + " " + a.Beds + " " + a.PricePerNight + " ";
    //}

    //String.Format("{0} {1} {2} {3} {4} {5} ", a.Country, a.City, a.Street, a.AptStyle, a.Beds, a.PricePerNight);
}
