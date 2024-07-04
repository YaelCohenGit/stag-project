using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BL.Models
{
    public class AptDetailsDTO
    {
        [JsonConstructor]
        public AptDetailsDTO() {}

        public AptDetailsDTO(string country, string city, string street, string aptStyle, string beds, string pricePerNight)
        {
            this.country = country;
            this.city = city;
            this.street = street;
            this.aptStyle = aptStyle;
            this.beds = beds;
            this.pricePerNight = pricePerNight;
        }
        public string? country { get; set; }
        public string? city { get; set; }
        public string? street { get; set; }
        public string aptStyle { get; set; }
        public string? beds { get; set; }
        public string? pricePerNight { get; set; }

    }
}
