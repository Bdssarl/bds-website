using System;
using System.Collections.Generic;


namespace Bds_site_web.Models;

public partial class Actualite
{
    public string IdActualite { get; set; } = null!;

    public string LibelleActualite { get; set; } = null!;

    public string DescriptionActualite { get; set; } = null!;

    public string CheminMediaActualite { get; set; } = null!;

    public virtual ICollection<Page> Pages { get; set; } = new List<Page>();
}
