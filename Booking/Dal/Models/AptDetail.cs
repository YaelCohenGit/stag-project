using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class AptDetail
{
    public int AptDetailsId { get; set; }

    public string? Country { get; set; }

    public string? City { get; set; }

    public string? Street { get; set; }

    public string AptStyle { get; set; } = null!;

    public string? Beds { get; set; }

    public string? PricePerNight { get; set; }

    public virtual ICollection<Owner> Owners { get; set; } = new List<Owner>();
}
