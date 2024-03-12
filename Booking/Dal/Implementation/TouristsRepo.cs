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
    public class TouristsRepo : ITouristsRepo
    {
        DBContext context;
        public TouristsRepo(DBContext context)
        {
            this.context = context;
        }
        public async Task<Tourist> AddAsync(Tourist entity)
        {
            try
            {
                context.Tourists.Add(entity);
                context.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception("Failed to add a new Tourist");
            }
        }


        public async Task<Tourist> DeleteAsync(int id)
        {
            Tourist t = context.Tourists.FirstOrDefault(t => t.TouristId == id);
            if (t != null)
                context.Tourists.Remove(t);
            context.SaveChanges();
            return t;
        }
        //public async Task<PagedList<Tourist>> IRepository<Tourist>.GetAllAsync(BaseQueryParams queryParams)
        //{
        //    var queryable = context.Tourists.AsQueryable();
        //    return PagedList<Tourist>.ToPagedList(queryable, queryParams.PageNumber, queryParams.PageSize);
        //}

        public async Task<Tourist> GetSingleAsync(int id)
        {
            try
            {
                return await context.Tourists.Where(Tourist => Tourist.TouristId == id).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in getting single Tourist {id} data");
            }
        }

        public async Task<Tourist> UpdateAsync(int id, Tourist entity)
        {
            Tourist? Tourist = context.Tourists.FirstOrDefault(c => c.TouristId == id);
            if (Tourist != null)
            {
                Tourist = entity;
                context.SaveChanges();
            }
            return Tourist;
        }


    }
}
