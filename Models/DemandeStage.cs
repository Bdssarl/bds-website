using System;
using System.Collections.Generic;

namespace bds_site_web_version7_.Models;

public partial class DemandeStage
{

 
    public string ObjetMessage { get; set; } = null!;

    public string? DescriptionMessage { get; set; }

    public DateTime? DateEnvoiDemandeStage { get; set; }

    public string NomCvDemandeStage { get; set; } = null!;
    public string UserId { get; set; }
    public string StageId { get; set; }
}
