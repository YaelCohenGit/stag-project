using Dal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.API
{
    public interface ITouristsRepo
    {
        public List<Tourist> GetAll();
        public Tourist Get(int id);
        public Tourist Add(Tourist aptDetail);
        public Tourist Delete(int id);
        public Tourist Update(Tourist owner);

    }
}
