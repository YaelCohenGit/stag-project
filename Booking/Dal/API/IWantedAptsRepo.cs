using Dal.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.API
{
    public interface IWantedAptsRepo
    {
        public List<WantedApt> GetAll();
        public WantedApt Get(int id);
        public WantedApt Add(WantedApt aptDetail);
        public WantedApt Delete(int id);
        public WantedApt Update(WantedApt owner);
    }
}
