﻿using BL.Models;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.API
{
    public interface IAptDetailsService : IService<BLAptDetails>
    {
        public Task<BLAptDetails?> GetById(int id);

    }
}
