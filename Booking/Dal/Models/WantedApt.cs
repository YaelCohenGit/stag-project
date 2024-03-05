using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class WantedApt
{
    public int WantedAptId { get; set; }

    public int TouristId { get; set; }

    public int WantedBeds { get; set; }

    public string WantedCountry { get; set; } = null!;

    public int WantedMinPrice { get; set; }

    public int WantedMaxPrice { get; set; }

    public virtual Tourist Tourist { get; set; } = null!;
    
    //public void Create
}
