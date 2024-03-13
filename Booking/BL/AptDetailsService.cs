using Dal;
using Dal.API;
using Dal.Implementation;
using Dal.Models;
using System.Diagnostics;

namespace BL
{
    public class AptDetailsService : IAptDetailsService
    {
        IAptDetailRepo _aptDetailRepo;
        public AptDetailsService(DalManager context)
        {
            this._aptDetailRepo = context.AptDetail;
        }
        public async Task<AptDetails?> GetSingleAsync(int id)
        {
            try
            {
                var e = await _aptDetailRepo.GetSingleAsync(id);
                return e;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in getting single AptDetails {id} data");
            }
        }
    }
}
