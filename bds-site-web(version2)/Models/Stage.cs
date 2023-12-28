using System;
using System.Collections.Generic;

namespace Bds_site_web.Models;

public partial class Stage
{
    public string IdStage { get; set; } = null!;

    public string TypeStage { get; set; } = null!;

    public string? DomaineStage { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
