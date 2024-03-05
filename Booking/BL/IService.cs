using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IService<T>
    {
        Task<List<T>> GetAllAsync();

        Task<T> GetSingleAsync(int id);

        Task<string> AddAsync(T objectToUpdate);

        Task<bool> UpdateAsync(T objectToUpdate);

        Task<bool> DeleteAsync(int id);
    }
}
