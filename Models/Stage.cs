using bds_site_web_version2_.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bds_site_web.Models;

public partial class Stage
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set; } = null!;
    public string? DomaineStage { get; set; } = null!;
    public virtual ICollection<TypeStage> TypeStages { get; set; } = new List<TypeStage>();
    public virtual ICollection<User> Users { get; set; } = new List<User>();
    public virtual ICollection<DemandeStage> DemandeStages { get; set; } = new List<DemandeStage>();
}
