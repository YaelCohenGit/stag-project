using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.API
{
    public interface IOwnersRepo //: IRepository<Owner>
    {
        //public void Create(string? Tel, string? Email, AptDetails AptDetail);
        public void Create(Owner item);

        public void Updete(Owner owner, string? Tel, string? Email);

        //public void Delete(Owner t);

        public string Read(Owner O);
    }
}




