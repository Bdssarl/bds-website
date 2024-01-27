using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace bds_site_web_version7_.Models;

public partial class ProjetAVenir
{
    public string Id { get; set; } = null!;
    public string Idee { get; set; }
    public string cheminImage { get; set;}

    [NotMapped]
    public IFormFile FormFile { get; set; }
}
