using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.API;
using BL.DTO;
using Dal.Implementation;
using Dal.Models;
using Dal;

namespace BL.BLImplementation
{
    public class WantedAptsService : IWantedAptsService
    {
        WantedAptsRepo aptDetails;
        public WantedAptsService(DalManager manager)
        {
            this.aptDetails = manager.WantedApts;
        }
        public WantedAptsDTO Add(WantedAptsDTO apt)
        {
            WantedApt c = new();
            c.WantedBeds = (int)apt.WantedBeds;
            c.WantedCountry = apt.WantedCountry;
            c.WantedMinPrice = (int)apt.WantedMinPrice;
            c.WantedMaxPrice = (int)apt.WantedMaxPrice;
            aptDetails.Add(c);
            return apt;
        }
        public List<WantedAptsDTO> GetAll()
        {
            List<WantedApt> list = aptDetails.GetAll();
            List<WantedAptsDTO> result = new List<WantedAptsDTO>();
            for (int i = 0; i < list.Count; i++)
            {
                result.Add(new WantedAptsDTO(list[i].WantedBeds, list[i].WantedCountry, list[i].WantedMinPrice, list[i].WantedMaxPrice));
            }
            return result;
        }
        public WantedAptsDTO Get(int id)
        {
            WantedApt c = aptDetails.Get(id);
            if (c == null)
            {
                return null;
            }
            WantedAptsDTO apt = new WantedAptsDTO(c.WantedBeds, c.WantedCountry, c.WantedMinPrice, c.WantedMaxPrice);
            return apt;
        }
        public WantedAptsDTO Update(WantedAptsDTO apt)
        {
            WantedApt c = new();
            c.WantedBeds = (int)apt.WantedBeds;
            c.WantedCountry = apt.WantedCountry;
            c.WantedMinPrice = (int)apt.WantedMinPrice;
            c.WantedMaxPrice = (int)apt.WantedMaxPrice;
            aptDetails.Update(c);
            return apt;
        }
    }
}
