using Dal;
using Dal.API;
using Dal.Implementation;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BLImplementation
{
    public class OwnerToAptDetailsRepo
    {
        IOwnersRepo ownersRepo;
        IAptDetailRepo AptDetail;  
        public OwnerToAptDetailsRepo(DalManager dalManager)
        {
            this.ownersRepo = dalManager.owners;
            this.AptDetail = dalManager.AptDetail;
        }

        public async Task<Owner> AddOwner(Owner owner)
        {
            Owner newOwner = new Owner(owner.Tel, owner.Email ,owner.AptDetails);
            await ownersRepo.AddAsync(newOwner);
            return newOwner;
        }

        //public List<Owner> GetOwners(BaseQueryParams queryParams)
        //{
        //    //Task<PagedList<Owner>> pagedOwners = ownersRepo.GetSingleAsync(queryParams);
        //    List<Owner> OwnersList = new List<Owner>();
        //    //foreach (var Owner in pagedOwners.Result)
        //    {
        //        Owner newOwner = new Owner();
        //        //newOwner.FirstName = Owner.Name.Split(' ')[0];
        //        //newOwner.LastName = Owner.Name.Split(" ")[1];
        //        //newOwner.Email = Owner.Email;
        //        //newOwner.Password = Owner.Password;
        //        OwnersList.Add(newOwner);
        //    }
        //    return OwnersList;
        //}

        public Owner GetById(int id)
        {
            Task<Owner> Owner = ownersRepo.GetSingleAsync(id);
            Owner newOwner = new Owner();
            //newOwner.FirstName = Owner.Result.Name.Split(' ')[0];
            //newOwner.LastName = Owner.Result.Name.Split(" ")[1];
            //newOwner.Email = Owner.Result.Email;
            //newOwner.Password = Owner.Result.Password;
            return newOwner;
        }

    }
}
