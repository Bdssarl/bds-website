using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bds_site_web_version7_.Models;

public partial class ProjetAVenir
{
    public string Id { get; set; } = null!;
    [StringLength(255, ErrorMessage = "vous avez atteint la taille limite ")]
    public string Idee { get; set; }
    public string cheminImage { get; set;}
    public string Nom_Page { get; set; }
    [NotMapped]
    public IFormFile FormFile { get; set; }
}
