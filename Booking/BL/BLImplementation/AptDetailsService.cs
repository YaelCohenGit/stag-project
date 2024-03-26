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
    //where to inject DalManager ?
    //do we need to inject the mapper?
    public class AptDetailsService : IAptDetailsService
    {
        IAptDetailRepo _aptDetailRepo;
        IMapper _mapper;
        public AptDetailsService(IAptDetailRepo aptDetailRepo)
        {
            _aptDetailRepo = aptDetailRepo;
        }

        public async Task<BLAptDetails?> GetById(int id)
        {
            //Task<AptDetails> user = _aptDetailRepo.GetSingleAsync(id);
            //AptDetailRepo newAptDetailRepo = new AptDetailRepo();

            return _mapper.Map<BLAptDetails>(await _aptDetailRepo.GetSingleAsync(id));
        }

        //public UserBl GetById(int id)
        //{
        //    Task<User> user = users.GetSingleAsync(id);
        //    UserBl newUser = new UserBl();
        //    newUser.Name = user.Result.Name;
        //    newUser.Email = user.Result.Email;
        //    newUser.Password = user.Result.Password;
        //    return newUser;
        //}
        public static BLAptDetails ToDto(AptDetails employee)
        {
            if (employee != null)
            {
                return new BLAptDetails
                {
                    country = employee.Country,
                    city = employee.City,
                    street = employee.Street,
                    aptStyle = employee.AptStyle,
                    beds = employee.Beds,
                    pricePerNight = employee.PricePerNight,
                };
            }

            return null;
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

        public Task<BLAptDetails> GetSingleAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
