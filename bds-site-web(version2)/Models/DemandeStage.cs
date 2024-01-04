using System;
using System.Collections.Generic;

namespace Bds_site_web.Models;

public partial class DemandeStage
{

    
    public string ObjetMessage { get; set; } = null!;

    public string? DescriptionMessage { get; set; }

    public DateTime? DateEnvoiDemandeStage { get; set; }

    public string NomCvDemandeStage { get; set; } = null!;

    public string CheminCvDemandeStage { get; set; } = null!;

    public virtual Stage IdStageNavigation { get; set; } = null!;
}
