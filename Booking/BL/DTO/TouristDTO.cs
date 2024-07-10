using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BL.DTO
{
    public class TouristDTO
    {
        [JsonConstructor]
        public TouristDTO() { }

        public TouristDTO(string tel, string email)
        {
            this.Tel = tel;
            this.Email = email;

        }
        public string? TouristId { get; set; }
        public string? Tel { get; set; }
        public string? Email { get; set; }
    }
}
