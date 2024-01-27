using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace bds_site_web_version7_.Models;

public partial class Partenaire
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set; } = null!;

    public string NomPartenaire { get; set; } = null!;

    public string? CheminImageTemoignage { get; set; }
    [NotMapped]
    public IFormFile formFile { get; set; }
}
