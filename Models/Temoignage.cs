using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bds_site_web_version7_.Models;

public partial class Temoignage
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set; } = null!;
    [StringLength(255, ErrorMessage = "vous avez atteint la taille limite ")]
    public string NomTemoignage { get; set; }
    [StringLength(255, ErrorMessage = "vous avez atteint la taille limite ")]
    public string DescriptionTemoignage { get; set; }
    [StringLength(25, ErrorMessage = "vous avez atteint la taille limite ")]
    public string? RoleTemoignage { get; set; }

    public string? CheminImageTemoignage { get; set; }
    [NotMapped]
    public IFormFile formfile { get; set; }
}
