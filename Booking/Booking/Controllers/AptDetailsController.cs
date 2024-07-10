using BL;
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
    public ActionResult<AptDetailsDTO?> Get(int id)
    {
        return aptDetailsService.Get(id);
    }

    [HttpPost]
    public ActionResult<AptDetailsDTO> Add(AptDetailsDTO apt)
    {
        return aptDetailsService.Add(apt);
    }

    [HttpPut("{ID}")]
    public ActionResult<AptDetailsDTO> Update(AptDetailsDTO apt)
    {
        return aptDetailsService.Update(apt);
    }

}
