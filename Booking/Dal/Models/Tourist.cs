using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class Tourist
{
    public int TouristId { get; set; }

    public string? Tel { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<WantedApt> WantedApts { get; set; } = new List<WantedApt>();
}
