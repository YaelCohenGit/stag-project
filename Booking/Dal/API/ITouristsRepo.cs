using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.API
{
    public interface ITouristsRepo //: IRepository<Tourist>
    {
        public void Create(string? Email, string? Tel);

        public void Update(Tourist t, string? Email, string? Tel);

        //public void Delete(Tourist t);

    }
}
