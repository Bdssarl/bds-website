using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bds_site_web_version7_.Models;

public partial class Actualite
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set; } = null!;
    [StringLength(100, ErrorMessage = "la taille ne doit pas dépasser 100 caractères")]
    public string LibelleActualite { get; set; } = null!;
    [StringLength(255, ErrorMessage = "la taille ne doit pas dépasser 255 caractères")]
    public string DescriptionActualite { get; set; } = null!;

    public string CheminMediaActualite { get; set; } = null!;
    [StringLength(100, ErrorMessage = "la taille ne doit pas dépasser 55 caractères")]
    public string NomPageActualite { get; set; } = null!;
    public DateTime dateCreation { get; set; }
    [NotMapped]
    public IFormFile FormFile { get; set; }
    
}
