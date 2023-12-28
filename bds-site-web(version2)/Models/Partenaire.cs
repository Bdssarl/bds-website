using System;
using System.Collections.Generic;

namespace Bds_site_web.Models;

public partial class Partenaire
{
    public string IdPartenaire { get; set; } = null!;

    public string NomPartenaire { get; set; } = null!;

    public string? CheminImageTemoignage { get; set; }
}
