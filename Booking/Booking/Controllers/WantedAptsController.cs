using BL;
using BL.API;
using BL.BLImplementation;
using BL.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WantedAptsController : ControllerBase
{
    WantedAptsService WantedApts;
    public WantedAptsController(BLManager blManager)
    {
        this.WantedApts = blManager.WantedAptService;
    }

    [HttpGet]
    public ActionResult<List<WantedAptsDTO>> GetAll()
    {
        return WantedApts.GetAll();
    }

    [HttpGet("{id}")]
    public ActionResult<WantedAptsDTO?> Get(int id)
    {
        return WantedApts.Get(id);
    }

    [HttpPost]
    public ActionResult<WantedAptsDTO> Add(WantedAptsDTO apt)
    {
        return WantedApts.Add(apt);
    }

    [HttpPut("{ID}")]
    public ActionResult<WantedAptsDTO> Update(WantedAptsDTO apt)
    {
        return WantedApts.Update(apt);
    }
}
