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
            this.ownersRepo = dalManager.Owners;
            this.AptDetail = dalManager.AptDetail;
        }

    }
}
