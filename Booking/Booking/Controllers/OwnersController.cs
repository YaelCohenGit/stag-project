using BL.BLImplementation;
using BL.DTO;
using BL;
using Dal.Models;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnersController : ControllerBase
    {
        OwnerService ownerService;
        public OwnersController(BLManager blManager)
        {
            this.ownerService = blManager.OwnersService;
        }

        [HttpGet]
        public ActionResult<List<OwnerDTO>> GetAll()
        {
            return ownerService.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<OwnerDTO?> Get(int id)
        {
            return ownerService.Get(id);
        }

        [HttpPost]
        public ActionResult<OwnerDTO> Add(OwnerDTO apt)
        {
            return ownerService.Add(apt);
        }

        [HttpPut("{ID}")]
        public ActionResult<OwnerDTO> Update(OwnerDTO apt)
        {
            return ownerService.Update(apt);
        }


    }
}
