using System;
using System.Collections.Generic;


namespace Bds_site_web.Models;

public partial class AnnonceRecrutement
{
    public string Id { get; set; } = null!;

    public string LibelleAnnonceRecrutement { get; set; } = null!;

    public string DescriptionAnnonceRecrutement { get; set; } = null!;

    public DateTime DateLimiteAnnonceRecrutement { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
