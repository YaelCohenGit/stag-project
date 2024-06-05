using Dal.API;
using Dal.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Dal.Implementation
{

    public class AptDetailsRepo : IAptDetailRepo
    {


        DBContext context;
        public AptDetailsRepo(DBContext context)
        {
            this.context = context;
        }
        public AptDetailsRepo()
        {
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

        List<AptDetail> IAptDetailRepo.GetAll()
        {
            throw new NotImplementedException();
        }

        AptDetail IAptDetailRepo.GetById(int id)
        {
            throw new NotImplementedException();
        }

        public AptDetail Add(AptDetail owner)
        {
            throw new NotImplementedException();
        }

        public AptDetail Update(AptDetail owner)
        {
            throw new NotImplementedException();
        }

        AptDetail IAptDetailRepo.Delete(int id)
        {
            throw new NotImplementedException();
        }




        //DBContext context;
        //public AptDetailsRepo(DBContext context)
        //{
        //    this.context = context;
        //}

        //public async Task<AptDetails> AddAsync(AptDetails entity)
        //{
        //    try
        //    {
        //        context.AptDetails.Add(entity);
        //        context.SaveChanges();
        //        return entity;
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex.ToString());
        //        throw new Exception("Failed to add a new AptDetails");
        //    }
        //}

        ////public async Task<PagedList<AptDetails>> GetAllAsync(BaseQueryParams queryParams)
        ////{
        ////    var queryable = context.AptDetails.AsQueryable();
        ////    return PagedList<AptDetails>.ToPagedList(queryable, queryParams.PageNumber, queryParams.PageSize);
        ////}
        //public async Task<AptDetails> GetSingleAsync(int id)
        //{
        //    AptDetails? returnValue = null;

        //    try
        //    {
        //        //return new AptDetails("1","2","3","4","5","6");
        //        returnValue = await context.AptDetails.Where(AptDetails => AptDetails.AptDetailsId == id).FirstOrDefaultAsync();              
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex.ToString());
        //        throw new Exception($"Error in getting single AptDetails {id} data");
        //    }

        //    return returnValue;
        //}


        //public async Task<AptDetails> DeleteAsync(int id)
        //{
        //    AptDetails c = context.AptDetails.FirstOrDefault(c => c.AptDetailsId == id);
        //    if (c != null)
        //        context.AptDetails.Remove(c);
        //    context.SaveChanges();
        //    return c;
        //}

        //public async Task<AptDetails> UpdateAsync(int id, AptDetails entity)
        //{
        //    AptDetails? AptDetails = context.AptDetails.FirstOrDefault(c => c.AptDetailsId == id);
        //    if (AptDetails != null)
        //    {
        //        AptDetails = entity;
        //        context.SaveChanges();
        //    }
        //    return AptDetails;
        //}

    }
}
