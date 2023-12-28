using System;
using System.Collections.Generic;

namespace Bds_site_web.Models;

public partial class Emploi
{
    public string IdEmploi { get; set; } = null!;

    public string TypeEmploi { get; set; } = null!;

    public string? DomaineEmploi { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
