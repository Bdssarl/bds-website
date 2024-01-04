using System;
using System.Collections.Generic;

namespace Bds_site_web.Models;

public partial class Temoignage
{
    public string IdTemoignage { get; set; } = null!;

    public string NomTemoignage { get; set; } 

    public string DescriptionTemoignage { get; set; } 

    public string? RoleTemoignage { get; set; }

    public string? CheminImageTemoignage { get; set; }
}
