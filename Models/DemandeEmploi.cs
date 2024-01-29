using System;
using System.Collections.Generic;

namespace bds_site_web_version7_.Models;

public partial class DemandeEmploi
{
    public DateTime DateEnvoiDemandeEmploi { get; set; }
    public string NomCvDemandeEmploi { get; set; } = null!;

    public string ObjetMessageEmploi { get; set; } = null!;
    public string MessageDemandeEmploi { get; set; } = null!;
    public string UserId { get; set; }
    public string EmploiId { get; set; }
}
