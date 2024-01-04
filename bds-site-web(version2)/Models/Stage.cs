using bds_site_web_version2_.Models;
using System;
using System.Collections.Generic;

namespace Bds_site_web.Models;

public partial class Stage
{
    
    public string IdStage { get; set; } = null!;
    public string? DomaineStage { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
    public virtual ICollection<TypeStage> TypeStages { get; set; } = new List<TypeStage>();
}
