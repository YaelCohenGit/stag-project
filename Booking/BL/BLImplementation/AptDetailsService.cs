using AutoMapper;
using BL.API;
using BL.Models;
using Dal;
using Dal.API;
using Dal.Implementation;
using Dal.Models;
using System.Diagnostics;

namespace BL.BLImplementation
{
    public class AptDetailsService : IAptDetailsService
    {
        IAptDetailRepo _aptDetailRepo;
        IMapper _mapper;
        public AptDetailsService(IAptDetailRepo aptDetailRepo)
        {
            _aptDetailRepo = aptDetailRepo;
        }

        public async Task<BLAptDetails> AddAsync(BLAptDetails objectToUpdate)
        {
            throw new NotImplementedException();
            // return await _aptDetailRepo.AddAsync(Convertion.SimpleAutoMapper<AptDetails, BLAptDetails>(objectToUpdate));
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<AptDetails>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<BLAptDetails?> GetSingleAsync(int id)
        {
            return _mapper.Map<BLAptDetails>(await _aptDetailRepo.GetSingleAsync(id));
        }

        public Task<bool> UpdateAsync(AptDetails objectToUpdate)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(BLAptDetails objectToUpdate)
        {
            throw new NotImplementedException();
        }

        Task<List<BLAptDetails>> IService<BLAptDetails>.GetAllAsync()
        {
            throw new NotImplementedException();
        }

       
    }
}
