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
        public List<AptDetail> GetAll()
        {
            return context.AptDetails.ToList();
        }
        public AptDetail Get(int id)
        {
            try
            {
                return context.AptDetails.Where(AptDetail => AptDetail.AptDetailsId == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in getting single AptDetails {id} data");
            }
        }

        public AptDetail Add(AptDetail aptDetail)
        {
            try
            {
                context.AptDetails.Add(aptDetail);
                context.SaveChanges();
                return aptDetail;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception("Failed to add a new AptDetail");
            }
        }
        public AptDetail Delete(int id)
        {
            try
            {
                var aptDetailToDelete = context.AptDetails.Where(aptDetail => aptDetail.AptDetailsId == id).FirstOrDefault();
                context.AptDetails.Remove(aptDetailToDelete);
                context.SaveChanges();
                return aptDetailToDelete;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in deleting");
            }
        }

        public AptDetail Update(AptDetail owner)
        {
            foreach (AptDetail c in context.AptDetails.ToList())
            {
                if (c.AptDetailsId == owner.AptDetailsId)
                {
                    c.AptStyle = owner.AptStyle;
                    c.Beds = owner.Beds;
                    break;
                }
            }
            context.SaveChanges();
            return owner;
        }

        //public Owner Update(Owner owner)
        //{
        //    foreach (Owner o in context.Owners.ToList())
        //    {
        //        if (o.OwnerId == owner.OwnerId)
        //        {
        //            o.Tel = owner.Tel;
        //            break;
        //        }
        //    }
        //    context.SaveChanges();
        //    return owner;
        //}


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
