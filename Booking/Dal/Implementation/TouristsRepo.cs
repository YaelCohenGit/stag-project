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
        public List<Tourist> GetAll()
        {
            return context.Tourists.ToList();
        }
        public Tourist Get(int id)
        {
            try
            {
                return context.Tourists.Where(t => t.TouristId == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in getting single Tourist {id} data");
            }
        }
        public Tourist Add(Tourist aptDetail)
        {
            try
            {
                context.Tourists.Add(aptDetail);
                context.SaveChanges();
                return aptDetail;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception("Failed to add a new Tourist");
            }
        }
        public Tourist Delete(int id)
        {
            try
            {
                var aptDetailToDelete = context.Tourists.Where(t => t.TouristId == id).FirstOrDefault();
                context.Tourists.Remove(aptDetailToDelete);
                context.SaveChanges();
                return aptDetailToDelete;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in deleting a Tourist");
            }
        }
        public Tourist Update(Tourist owner)
        {
            foreach (Tourist c in context.Tourists.ToList())
            {
                if (c.TouristId == owner.TouristId)
                {
                    c.Tel = owner.Tel;
                    c.Email = owner.Email;
                    break;
                }
            }
            context.SaveChanges();
            return owner;
        }




        //public async Task<Tourist> AddAsync(Tourist entity)
        //{
        //    try
        //    {
        //        context.Tourists.Add(entity);
        //        context.SaveChanges();
        //        return entity;
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex.ToString());
        //        throw new Exception("Failed to add a new Tourist");
        //    }
        //}



        //public async Task<Tourist> DeleteAsync(int id)
        //{
        //    Tourist t = context.Tourists.FirstOrDefault(t => t.TouristId == id);
        //    if (t != null)
        //        context.Tourists.Remove(t);
        //    context.SaveChanges();
        //    return t;
        //}


        //public async Task<PagedList<Tourist>> IRepository<Tourist>.GetAllAsync(BaseQueryParams queryParams)
        //{
        //    var queryable = context.Tourists.AsQueryable();
        //    return PagedList<Tourist>.ToPagedList(queryable, queryParams.PageNumber, queryParams.PageSize);
        //}

        //public async Task<Tourist> GetSingleAsync(int id)
        //{
        //    try
        //    {
        //        return await context.Tourists.Where(Tourist => Tourist.TouristId == id).FirstOrDefaultAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex.ToString());
        //        throw new Exception($"Error in getting single Tourist {id} data");
        //    }
        //}


        //public async Task<Tourist> UpdateAsync(int id, Tourist entity)
        //{
        //    Tourist? Tourist = context.Tourists.FirstOrDefault(c => c.TouristId == id);
        //    if (Tourist != null)
        //    {
        //        Tourist = entity;
        //        context.SaveChanges();
        //    }
        //    return Tourist;
        //}


    }
}
