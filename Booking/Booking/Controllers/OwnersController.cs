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
    public class OwnersController : ControllerBase
    {
        public void Create(string? Tel, string? Email, AptDetails AptDetail)
        {
            Owner o = new Owner(Tel, Email, AptDetail);
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
