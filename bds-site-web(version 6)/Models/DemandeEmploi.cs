using System;
using System.Collections.Generic;

namespace Bds_site_web.Models;

public partial class DemandeEmploi
{
   

    public DateTime DateEnvoiDemandeEmploi { get; set; }


    public string NomCvDemandeEmploi { get; set; } = null!;

    public string CheminCvDemandeEmploi { get; set; } = null!;

    public string MessageDemandeEmploi { get; set; } = null!;

    public string ObjetMessageEmploi { get; set; } = null!;

    public string? DescriptionMessageEmploi { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
    public virtual ICollection<Emploi> Emplois { get; set; } = new List<Emploi>();
}
