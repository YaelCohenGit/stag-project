using BL.DTO;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.API
{
    public interface IOwnerService : IService<OwnerDTO>
    {
        public OwnerDTO Add(OwnerDTO apt);
        public List<OwnerDTO> GetAll();
        public OwnerDTO Get(int id);
        public OwnerDTO Update(OwnerDTO apt);
    }
}
