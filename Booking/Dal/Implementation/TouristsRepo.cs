using Dal.API;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Implementation
{
    public class TouristsRepo : ITouristsRepo
    {
        public void Create(string? Email, string? Tel)
        {
            Tourist t = new Tourist(Email, Tel);
        }

        public void Update(Tourist t, string? Email, string? Tel)
        {
            t.Email = Email;
            t.Tel = Tel;
        }

        //public void Delete(Tourist t)
        //{

        //}


    }
}
