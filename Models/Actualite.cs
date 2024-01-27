using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace bds_site_web_version7_.Models;

public partial class Actualite
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set; } = null!;

    public string LibelleActualite { get; set; } = null!;

    public string DescriptionActualite { get; set; } = null!;

    public string CheminMediaActualite { get; set; } = null!;
    public DateTime dateCreation { get; set; } 
    
}
