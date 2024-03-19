using Dal.API;
using Dal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Common;
namespace Dal.Implementation
{
    public class OwnersRepo: IOwnersRepo
    {
        DBContext context;
        public OwnersRepo(DBContext context)
        {
            this.context = context;
        }
        public async Task<Owner> AddAsync(Owner entity)
        {
            try
            {
                context.Owners.Add(entity);
                context.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception("Failed to add a new Owner");
            }
        }

        public async Task<Owner> DeleteAsync(int id)
        {
            Owner c = context.Owners.FirstOrDefault(c => c.OwnerId == id);
            if (c != null)
                context.Owners.Remove(c);
            context.SaveChanges();
            return c;
        }


        //public async Task<PagedList<Tourist>> GetAllAsync(BaseQueryParams queryParams)
        //{
        //    var queryable = context.Owners.AsQueryable();
        //    return PagedList<Tourist>.ToPagedList(queryable, queryParams.PageNumber, queryParams.PageSize);
        //}

        public async Task<Owner> GetSingleAsync(int id)
        {
            try
            {
                return await context.Owners.Where(AptDetails => AptDetails.AptDetailsId == id).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in getting single Owner {id} data");
            }
        }

        public async Task<Owner> UpdateAsync(int id, Owner entity)
        {
            Owner? AptDetails = context.Owners.FirstOrDefault(c => c.OwnerId == id);
            if (AptDetails != null)
            {
                AptDetails = entity;
                context.SaveChanges();
            }
            return AptDetails;
        }


        //Task<PagedList<Owner>> IRepository<Owner>.GetAllAsync(BaseQueryParams queryParams)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
