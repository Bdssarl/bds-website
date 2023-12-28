using System;
using System.Collections.Generic;

namespace Bds_site_web.Models;

public partial class ProjetAVenir
{
    public string IdProjetAVenir { get; set; } = null!;

    public string NomProjetAVenir { get; set; } = null!;

    public string DureeProjetAVenir { get; set; } = null!;

    public string ObjectifProjetAVenir { get; set; } = null!;

    public DateTime DateDebutProjetAVenir { get; set; }

    public DateTime DateFinProjetAVenir { get; set; }

    public string NomImageProjetAVenir { get; set; } = null!;

    public string CheminImageProjetAVenir { get; set; } = null!;
}
