using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class Owner
{
    public string OwnerId { get; set; } = null!;

    public int AptDetailsId { get; set; }

    public string? Tel { get; set; }

    public string? Email { get; set; }

    public virtual AptDetails AptDetails { get; set; } = null!;
    public Owner(string? Tel, string? Email, AptDetails AptDetails)
    {
        this.Tel = Tel; 
        this.Email = Email; 
        this.AptDetails = AptDetails;   
    }
}
