using Dal;
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
        OwnersRepo ownersRepo;
        AptDetailRepo AptDetail;  
        public OwnerToAptDetailsRepo(DalManager dalManager)
        {
            this.ownersRepo = dalManager.owners;
            this.AptDetail = dalManager.AptDetail;
        }

    }
}
