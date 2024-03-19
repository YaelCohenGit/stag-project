using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class Owner
{
    public int OwnerId { get; set; }

    public int AptDetailsId { get; set; }

    public string? Tel { get; set; }

    public string? Email { get; set; }

    public virtual AptDetail AptDetails { get; set; } = null!;
}
