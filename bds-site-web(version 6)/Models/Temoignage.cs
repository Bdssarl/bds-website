using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bds_site_web.Models;

public partial class Temoignage
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set; } = null!;

    public string NomTemoignage { get; set; } 

    public string DescriptionTemoignage { get; set; } 

    public string? RoleTemoignage { get; set; }

    public string? CheminImageTemoignage { get; set; }
}
