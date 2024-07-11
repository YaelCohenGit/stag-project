using Dal.Models;
using System.Diagnostics;

namespace Dal.API
{
    public interface IOwnersRepo
    {
        public Owner Add(Owner owner);
        public Owner Delete(int id);
        public Owner Get(int id);
        public List<Owner> GetAll();
        public Owner Update(Owner owner);
    }
}




