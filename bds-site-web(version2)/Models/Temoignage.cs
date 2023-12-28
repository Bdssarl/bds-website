using System;
using System.Collections.Generic;

namespace Bds_site_web.Models;

public partial class Temoignage
{
    public string IdTemoignage { get; set; } = null!;

    public string NomTemoignage { get; set; } = null!;

    public string DescriptionTemoignage { get; set; } = null!;

    public string? RoleTemoignage { get; set; }

    public string? CheminImageTemoignage { get; set; }
}
