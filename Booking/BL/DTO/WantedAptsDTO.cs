using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BL.DTO
{
    public class WantedAptsDTO
    {
        [JsonConstructor]
        public WantedAptsDTO() { }
        public WantedAptsDTO(int wantedBeds, string wantedCountry, int wantedMinPrice, int wantedMaxPrice)
        {
            this.WantedBeds = wantedBeds;
            this.WantedCountry = wantedCountry;
            this.WantedMinPrice = wantedMinPrice;
            this.WantedMaxPrice = wantedMaxPrice;
        }
        public int? WantedBeds { get; set; }
        public string? WantedCountry { get; set; }
        public int? WantedMinPrice { get; set; }
        public int? WantedMaxPrice { get; set; }
    }
}
