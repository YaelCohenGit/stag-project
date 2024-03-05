using Dal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class TouristsController : ControllerBase
    {
        public int TouristId { get; set; }

        public string? Tel { get; set; }

        public string? Email { get; set; }

        public virtual ICollection<WantedApt> WantedApts { get; set; } = new List<WantedApt>();
        public void Tourist(string? Email, string? Tel)
        {
            this.Email = Email;
            this.Tel = Tel;
        }
        public void Tourist()
        {

        }
    }
}
