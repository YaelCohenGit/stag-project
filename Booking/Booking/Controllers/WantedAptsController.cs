using BL;
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
    public class WantedAptsController : ControllerBase
    {
        IWantedAptsService wantedAptsService;
        public WantedAptsController(IWantedAptsService wantedAptsService)
        {
            this.wantedAptsService = wantedAptsService;
        }







        //[HttpGet("getAllEmployees")]
        //public List<WantedApt> Get()
        //{
        //    return WantedAptsService.GetAllEmployees();
        //}

        //[HttpGet("employeeId/{employeeId}")]
        //public Employees GetById(int employeeId)
        //{
        //    return WantedAptsService.GetById(employeeId);
        //}

        //[HttpGet("checkIdAndName/{id}/{fullName}")]
        //public int checkIdAndName(int id, string fullName)
        //{
        //    return WantedAptsService.checkIdAndName(id, fullName);
        //}

        //[HttpPost("addEmployee")]
        //public int AddEmployee(WantedApt wa)
        //{
        //    return WantedAptsService.AddEmployee(wa);
        //}
        //[HttpGet("getByCode/{code}")]
        //public WantedApt GetByCode(int code)
        //{
        //    return WantedAptsService.GetByCode(code);
        //}
    }
}
