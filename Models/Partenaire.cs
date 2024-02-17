using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bds_site_web_version7_.Models;

public partial class Partenaire
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set; } = null!;
    [StringLength(45, ErrorMessage = "vous avez atteint la taille limite ")]
    public string NomPartenaire { get; set; } = null!;
    [StringLength(255, ErrorMessage = "vous avez atteint la taille limite ")]
    public string? CheminImageTemoignage { get; set; }
    [NotMapped]
    public IFormFile formFile { get; set; }
}
