using System;
using System.Collections.Generic;

namespace Bds_site_web.Models;

public partial class DemandeEmploi
{
    public string IdDemandeEmploi { get; set; } = null!;

    public string IdEmploi { get; set; } = null!;

    public DateTime DateEnvoiDemandeEmploi { get; set; }

    public string TypeEmploi { get; set; } = null!;

    public string Periode { get; set; } = null!;

    public string NomCvDemandeEmploi { get; set; } = null!;

    public string CheminCvDemandeEmploi { get; set; } = null!;

    public string MessageDemandeEmploi { get; set; } = null!;

    public string ObjetMessageEmploi { get; set; } = null!;

    public string? DescriptionMessageEmploi { get; set; }

    public virtual Emploi IdEmploiNavigation { get; set; } = null!;
}
