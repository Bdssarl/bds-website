using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bds_site_web.Models;

public partial class AnnonceRecrutement
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set; } = null!;

    public string LibelleAnnonceRecrutement { get; set; } = null!;

    public string DescriptionAnnonceRecrutement { get; set; } = null!;

    public DateTime DateLimiteAnnonceRecrutement { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
