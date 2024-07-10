using AutoMapper;
using BL.API;
using BL.Models;
using Dal;
using Dal.API;
using Dal.Implementation;
using Dal.Models;
using System.Diagnostics;
using System.IO;

namespace BL.BLImplementation
{
    public class AptDetailsService : IAptDetailsService
    {
        AptDetailsRepo aptDetails;
        public AptDetailsService(DalManager manager)
        {
            this.aptDetails = manager.AptDetail;
        }
        public AptDetailsDTO Add(AptDetailsDTO apt)
        {
            AptDetail c = new AptDetail();
            c.Country = apt.country;
            c.City = apt.city;
            c.Street = apt.street;
            c.AptStyle= apt.aptStyle;
            c.Beds = apt.beds;
            c.PricePerNight = apt.pricePerNight;
            aptDetails.Add(c);
            return apt;
        }
        public List<AptDetailsDTO> GetAll()
        {
            List<AptDetail> list = aptDetails.GetAll();
            List<AptDetailsDTO> result = new List<AptDetailsDTO>();
            for (int i = 0; i < list.Count; i++)
            {
                result.Add(new AptDetailsDTO(list[i].Country, list[i].City, list[i].Street, list[i].AptStyle, list[i].Beds, list[i].PricePerNight));
            }
            return result;
        }

        public AptDetailsDTO Get(int id)
        {
            AptDetail c = aptDetails.Get(id);
            if (c == null)
            {
                return null;
            }
            AptDetailsDTO apt = new AptDetailsDTO(c.Country, c.City, c.Street, c.AptStyle, c.Beds, c.PricePerNight);
            return apt;
        }

        public AptDetailsDTO Update(AptDetailsDTO apt)
        {
            AptDetail c = new();
            c.Country = apt.country;
            c.City = apt.city;
            c.Street = apt.street;
            c.AptStyle = apt.aptStyle;
            c.Beds = apt.beds;
            c.PricePerNight = apt.pricePerNight;
            aptDetails.Update(c);
            return apt;
        }
    }
}
