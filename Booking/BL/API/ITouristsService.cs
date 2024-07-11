using BL.DTO;
using Dal.Models;
using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.API
{
    public interface ITouristsService : IService<TouristDTO>
    {
        public TouristDTO Add(TouristDTO apt);
        public List<TouristDTO> GetAll();
        public TouristDTO Get(int id);
        public TouristDTO Update(TouristDTO apt);
    }
}
