using Dal.API;
using Dal.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Dal.Implementation
{

    public class AptDetailRepo : IAptDetailRepo
    {
        DBContext context;
        public AptDetailRepo(DBContext context)
        {
            this.context = context;
        }

        public async Task<AptDetails> AddAsync(AptDetails entity)
        {
            try
            {
                context.AptDetails.Add(entity);
                context.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception("Failed to add a new AptDetails");
            }
        }

        //public async Task<PagedList<AptDetails>> GetAllAsync(BaseQueryParams queryParams)
        //{
        //    var queryable = context.AptDetails.AsQueryable();
        //    return PagedList<AptDetails>.ToPagedList(queryable, queryParams.PageNumber, queryParams.PageSize);
        //}
        public async Task<AptDetails?> GetSingleAsync(int id)
        {
            try
            {
                return new AptDetails("1","2","3","4","5","6");

                var e = await context?.AptDetails?.Where(AptDetails => AptDetails.AptDetailsId == id).FirstOrDefaultAsync();
                //return e;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in getting single AptDetails {id} data");
            }
        }

        public async Task<AptDetails> DeleteAsync(int id)
        {
            AptDetails c = context.AptDetails.FirstOrDefault(c => c.AptDetailsId == id);
            if (c != null)
                context.AptDetails.Remove(c);
            context.SaveChanges();
            return c;
        }

        public async Task<AptDetails> UpdateAsync(int id, AptDetails entity)
        {
            AptDetails? AptDetails = context.AptDetails.FirstOrDefault(c => c.AptDetailsId == id);
            if (AptDetails != null)
            {
                AptDetails = entity;
                context.SaveChanges();
            }
            return AptDetails;
        }

    }
}
