using Dal.Models;
using System.Diagnostics;

namespace Dal.API
{
    public interface IAptDetailRepo
    {
         List<AptDetail> GetAll();
         AptDetail Get(int id);
         AptDetail Add(AptDetail aptDetail);
        AptDetail Delete(int id);
        AptDetail Update(AptDetail owner);
    }
}
