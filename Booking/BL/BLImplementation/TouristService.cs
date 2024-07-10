using BL.API;
using BL.Models;
using Dal.Implementation;
using Dal.Models;
using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.DTO;
using Dal.API;

namespace BL.BLImplementation
{
    public class TouristService : ITouristsService
    {
        TouristsRepo aptDetails;
        public TouristService(DalManager manager)
        {
            this.aptDetails = manager.Tourists;
        }
        public TouristDTO Add(TouristDTO apt)
        {
            Tourist c = new();
            c.Tel = apt.Tel;
            c.Email = apt.Email;
            aptDetails.Add(c);
            return apt;
        }
        public List<TouristDTO> GetAll()
        {
            List<Tourist> list = aptDetails.GetAll();
            List<TouristDTO> result = new List<TouristDTO>();
            for (int i = 0; i < list.Count; i++)
            {
                result.Add(new TouristDTO(list[i].Tel, list[i].Email));
            }
            return result;
        }

        public TouristDTO Get(int id)
        {
            Tourist c = aptDetails.Get(id);
            if (c == null)
            {
                return null;
            }
            TouristDTO apt = new TouristDTO(c.Tel, c.Email);
            return apt;
        }

        public TouristDTO Update(TouristDTO apt)
        {
            Tourist c = new();
            c.Tel = apt.Tel;
            c.Email = apt.Email;
            aptDetails.Update(c);
            return apt;
        }
    }
}
