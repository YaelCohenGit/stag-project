using Dal.API;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Implementation
{
    public class OwnersRepo : IOwnersRepo
    {

        //public void Create(string? Tel, string? Email, AptDetails AptDetail)
        //{
        //    Owner o = new Owner(Tel, Email, AptDetail);
        //}


        public void Create(Owner item)
        {
            DBContext.Owners.Add(item);
            //DBContext.SaveChanges();
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

        public string Get(Owner O)
        {
            return DBContext.Owners.ToList();
        }

        public void Create(string? Tel, string? Email, AptDetails AptDetail)
        {
            throw new NotImplementedException();
        }
    }
}
