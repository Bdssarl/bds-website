using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bds_site_web_version7_.Models;

public partial class Video
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set; } = null!;
    [StringLength(255,ErrorMessage ="le nom de la vidéo ne doit pas excéder 255 caractères")]
    public string NomVideo { get; set; } = null!;

    public string TailleVideo { get; set; } = null!;

    public string ExtensionVideo { get; set; } = null!;
    
    public string CheminVideo { get; set; } = null!;

    public DateTime DateCreationVideo { get; set; }
    [NotMapped]
    public IFormFile formFile { get; set; }
}
