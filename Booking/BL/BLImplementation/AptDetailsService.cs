using AutoMapper;
using BL.API;
using BL.Models;
using Dal;
using Dal.API;
using Dal.Implementation;
using Dal.Models;
using System.Diagnostics;
using System.IO;

namespace BL.BLImplementation
{
    public class AptDetailsService : IAptDetailsService
    {
        AptDetailsRepo aptDetails;
        public AptDetailsService(DalManager manager)
        {
            this.aptDetails = manager.AptDetail;
        }
        public AptDetailsDTO Add(AptDetailsDTO client)
        {
            AptDetail c = new AptDetail();
            c.Country = client.country;
            c.City = client.city;
            c.Street = client.street;
            c.AptStyle= client.aptStyle;
            c.Beds = client.beds;
            c.PricePerNight = client.pricePerNight;
            aptDetails.Add(c);
            return client;
        }

        public List<AptDetailsDTO> GetAll()
        {
            List<AptDetail> list = aptDetails.GetAll();
            List<AptDetailsDTO> result = new List<AptDetailsDTO>();
            for (int i = 0; i < list.Count; i++)
            {
                result.Add(new AptDetailsDTO(list[i].Country, list[i].City, list[i].Street, list[i].AptStyle, list[i].Beds, list[i].PricePerNight));
            }
            return result;
        }


        //public async Task<AptDetailsDTO?> GetById(int id)
        //{
        //    //Task<AptDetails> user = _aptDetailRepo.GetSingleAsync(id);
        //    //AptDetailRepo newAptDetailRepo = new AptDetailRepo();

        //    return _mapper?.Map<AptDetailsDTO>( _aptDetailRepo.GetById(id));
        //}

        //public async Task<FlightDTO> GetSingleAsync(string flightCode)
        //{
        //    return _mapper.Map<FlightDTO>(await _flightRepo.GetSingleAsync(flightCode));
        //}

        //public UserBl GetById(int id)
        //{
        //    Task<User> user = users.GetSingleAsync(id);
        //    UserBl newUser = new UserBl();
        //    newUser.Name = user.Result.Name;
        //    newUser.Email = user.Result.Email;
        //    newUser.Password = user.Result.Password;
        //    return newUser;
        //}
        //public static BLAptDetails ToDto(AptDetails employee)
        //{
        //    if (employee != null)
        //    {
        //        return new BLAptDetails
        //        {
        //            country = employee.Country,
        //            city = employee.City,
        //            street = employee.Street,
        //            aptStyle = employee.AptStyle,
        //            beds = employee.Beds,
        //            pricePerNight = employee.PricePerNight,
        //        };
        //    }

        //    return null;
        //}

        public async Task<AptDetailsDTO> AddAsync(AptDetailsDTO objectToUpdate)
        {
            throw new NotImplementedException();
            // return await _aptDetailRepo.AddAsync(Convertion.SimpleAutoMapper<AptDetails, BLAptDetails>(objectToUpdate));
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<AptDetail>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(AptDetail objectToUpdate)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(AptDetailsDTO objectToUpdate)
        {
            throw new NotImplementedException();
        }

        Task<List<AptDetailsDTO>> IService<AptDetailsDTO>.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<AptDetailsDTO> GetSingleAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<AptDetailsDTO?> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
