using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class AptDetails
{
    public int AptDetailsId { get; set; }

    public string? Country { get; set; }

    public string? City { get; set; }

    public string? Street { get; set; }

    public string AptStyle { get; set; } = null!;

    public string? Beds { get; set; }

    public string? PricePerNight { get; set; }

    public virtual ICollection<Owner> Owners { get; set; } = new List<Owner>();
    public AptDetails(string? Country, string? City, string? Street, string AptStyle, string? Beds, string? PricePerNight)
    {
        this.Country = Country; 
        this.City = City;   
        this.Street = Street;
        this.AptStyle = AptStyle;
        this.Beds = Beds;
        this.PricePerNight = PricePerNight;
        
    }

}
