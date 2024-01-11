using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bds_site_web.Models;

public partial class ProjetAVenir
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set; } = null!;

    public string NomProjetAVenir { get; set; } = null!;

    public string DureeProjetAVenir { get; set; } = null!;

    public string ObjectifProjetAVenir { get; set; } = null!;

    public DateTime DateDebutProjetAVenir { get; set; }

    public DateTime DateFinProjetAVenir { get; set; }

    public string NomImageProjetAVenir { get; set; } = null!;

    public string CheminImageProjetAVenir { get; set; } = null!;
}
