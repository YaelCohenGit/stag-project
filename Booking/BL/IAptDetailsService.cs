using Dal.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IAptDetailsService //: IService<AptDetails>
    {
        public Task<AptDetails?> GetSingleAsync(int id);

    }
}
