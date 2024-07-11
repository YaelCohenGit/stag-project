using BL.DTO;
using Dal.Implementation;
using Dal.Models;
using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.API;
using BL.API;

namespace BL.BLImplementation
{
    public class OwnerService : IOwnerService
    {
        OwnersRepo owners;
        public OwnerService(DalManager manager)
        {
            this.owners = manager.Owners;
        }
        public OwnerDTO Add(OwnerDTO apt)
        {
            Owner c = new();
            c.Tel = apt.Tel;
            c.Email = apt.Email;
            owners.Add(c);
            return apt;
        }
        public List<OwnerDTO> GetAll()
        {
            List<Owner> list = owners.GetAll();
            List<OwnerDTO> result = new List<OwnerDTO>();
            for (int i = 0; i < list.Count; i++)
            {
                result.Add(new OwnerDTO(list[i].Tel, list[i].Email));
            }
            return result;
        }
        public OwnerDTO Get(int id)
        {
            Owner c = owners.Get(id);
            if (c == null)
            {
                return null;
            }
            OwnerDTO apt = new OwnerDTO(c.Tel, c.Email);
            return apt;
        }
        public OwnerDTO Update(OwnerDTO apt)
        {
            Owner c = new();
            c.Tel = apt.Tel;
            c.Email = apt.Email;
            owners.Update(c);
            return apt;
        }
    }
}
