using Dal.API;
using Dal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Dal.Implementation
{
    public class OwnersRepo: IOwnersRepo
    {
        DBContext context;
        public OwnersRepo(DBContext context)
        {
            this.context = context;
        }
        public Owner Add(Owner owner)
        {
            try
            {
                context.Owners.Add(owner);
                context.SaveChanges();
                return owner;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception("Failed to add a new Owner");
            }
        }

        public Owner Delete(int id)
        {
            try
            {
                var ownerToDelete = context.Owners.Where(owner => owner.OwnerId == id).FirstOrDefault();
                context.Owners.Remove(ownerToDelete);
                context.SaveChanges();
                return ownerToDelete;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in deleting Gown {id} data");
            }
        }


        public Owner GetById(int id)
        {
            try
            {
                return context.Owners.Where(owner => owner.OwnerId == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in getting single Gown {id} data");
            }
        }

        public List<Owner> GetAll()
        {
            return context.Owners.ToList();
        }


        public Owner Update(Owner owner)
        {
            foreach (Owner o in context.Owners.ToList())
            {
                if (o.OwnerId == owner.OwnerId)
                {
                    o.Tel = owner.Tel;
                    break;
                }
            }
            context.SaveChanges();
            return owner;
        }
    }
}
