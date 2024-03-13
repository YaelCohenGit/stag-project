using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models
{
    public class BLAptDetails
    {
        public string? country { get; set; }
        public string? city { get; set; }
        public string? street { get; set; }
        public string aptStyle { get; set; }
        public string? beds { get; set; }
        public string? pricePerNight { get; set; }

        public BLAptDetails()
        {
           // AptDetails aptDetail = new AptDetails(country, city, street, aptStyle, beds, pricePerNight);
        }

    }
}
