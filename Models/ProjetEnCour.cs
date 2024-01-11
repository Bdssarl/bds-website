using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bds_site_web.Models;

public partial class ProjetEnCour
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set; } = null!;

    public string NomProjetEnCours { get; set; } = null!;

    public string DureeProjetEnCours { get; set; } = null!;

    public string ObjectifResultatRealise { get; set; } = null!;

    public string ResumeDuProjetEnCours { get; set; } = null!;

    public DateTime DateDebutProjetEnCours { get; set; }

    public DateTime DateFinProjetEnCours { get; set; }

    public string NomImageProjetEnCours { get; set; } = null!;

    public string CheminImageProjetEnCours { get; set; } = null!;
}
