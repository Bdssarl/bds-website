using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bds_site_web.Models;

public partial class Emploi
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set; } = null!;

    public string TypeEmploi { get; set; } = null!;

    public string? DomaineEmploi { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
