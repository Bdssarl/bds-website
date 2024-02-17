using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace bds_site_web_version7_.Models;

public partial class Emploi
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set; } = null!;


    public string? DomaineEmploi { get; set; }

    [NotMapped]
    public string TypeEmploi { get; set; } = null!;
    public string IdTypeEmploi { get; set; } = null!;
    public virtual TypeEmploi typeEmploi { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
    
}
