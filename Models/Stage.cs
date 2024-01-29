using bds_site_web_version7_.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace bds_site_web_version7_.Models;

public partial class Stage
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set; } = null!;
    public string? DomaineStage { get; set; } = null!;
    [NotMapped]
    public  string TypeStage { get; set; } = null!;
    public string IdTypeStage { get; set; } = null!;
    public virtual TypeStage typestage { get; set; } = null!;
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
