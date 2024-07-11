using Dal.API;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Implementation
{
    public class WantedAptsRepo : IWantedAptsRepo
    {
        DBContext context;
        public WantedAptsRepo(DBContext context)
        {
            this.context = context;
        }
        public List<WantedApt> GetAll()
        {
            return context.WantedApts.ToList();
        }
        public WantedApt Get(int id)
        {
            try
            {
                return context.WantedApts.Where(t => t.TouristId == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in getting single WantedApt {id} data");
            }
        }
        public WantedApt Add(WantedApt aptDetail)
        {
            try
            {
                context.WantedApts.Add(aptDetail);
                context.SaveChanges();
                return aptDetail;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception("Failed to add a new WantedApt");
            }
        }
        public WantedApt Delete(int id)
        {
            try
            {
                var aptDetailToDelete = context.WantedApts.Where(t => t.TouristId == id).FirstOrDefault();
                context.WantedApts.Remove(aptDetailToDelete);
                context.SaveChanges();
                return aptDetailToDelete;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in deleting a WantedApt");
            }
        }
        public WantedApt Update(WantedApt owner)
        {
            foreach (WantedApt c in context.WantedApts.ToList())
            {
                if (c.TouristId == owner.TouristId)
                {
                    c.WantedBeds = owner.WantedBeds;
                    c.WantedCountry = owner.WantedCountry;
                    c.WantedMinPrice = owner.WantedMinPrice;
                    c.WantedMaxPrice = owner.WantedMaxPrice;
                    break;
                }
            }
            context.SaveChanges();
            return owner;
        }
    }
}
