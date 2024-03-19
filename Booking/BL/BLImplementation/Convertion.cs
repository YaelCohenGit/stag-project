using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BLImplementation
{
    public class Convertion
    {
        #region Convert SimpleAutoMapper function

        public static T SimpleAutoMapper<T, U>(U obj)
        {
            try
            {
                if (obj != null)
                {
                    var config = new MapperConfiguration(cfg => cfg.CreateMap<U, T>().ReverseMap());
                    var mapper = config.CreateMapper();
                    return mapper.Map<T>(obj);
                }
                else { throw new ArgumentNullException("obj is null!"); }
            }
            catch (ArgumentNullException ex) { throw ex; }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }

}
