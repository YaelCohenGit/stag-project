using BL.BLImplementation;
using BL.Models;
using BL;
using BL.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TouristsController : ControllerBase
{
    TouristService touristService;
    public TouristsController(BLManager blManager)
    {
        this.touristService = blManager.TouristService;
    }

    [HttpGet]
    public ActionResult<List<TouristDTO>> GetAll()
    {
        return touristService.GetAll();
    }

    [HttpGet("{id}")]
    public ActionResult<TouristDTO?> Get(int id)
    {
        return touristService.Get(id);
    }

    [HttpPost]
    public ActionResult<TouristDTO> Add(TouristDTO apt)
    {
        return touristService.Add(apt);
    }

    [HttpPut("{ID}")]
    public ActionResult<TouristDTO> Update(TouristDTO apt)
    {
        return touristService.Update(apt);
    }
}
