using BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.API
{
    public interface IService<T>
    {
        //Task<List<T>> GetAllAsync();

        //Task<T> GetById(int id);

        //Task<T> AddAsync(T objectToUpdate);

        //Task<bool> UpdateAsync(T objectToUpdate);

        //Task<bool> DeleteAsync(int id);
        T Add(T a);
        List<T> GetAll();
        T Get(int id);
        T Update(T a);
    }
}
