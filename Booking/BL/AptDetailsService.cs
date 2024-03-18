using BL.Models;
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

        public async Task<BLAptDetails?> GetSingleAsync(int id)
        {
            try
            {
                var e = await _aptDetailRepo.GetSingleAsync(id);
                
                BLAptDetails bLAptDetails = new BLAptDetails()// אפשר גם בסיטור
                {
                    city = e.City,
                    country = e.Country,
                    pricePerNight = e.PricePerNight,
                };

                return bLAptDetails;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in getting single AptDetails {id} data");
            }
        }

    }
}
