using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.API
{
    public interface IService<T>
    {
        Task<List<T>> GetAllAsync();

        Task<T> GetSingleAsync(int id);

        Task<T> AddAsync(T objectToUpdate);

        Task<bool> UpdateAsync(T objectToUpdate);

        Task<bool> DeleteAsync(int id);
    }
}
