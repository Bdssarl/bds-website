using System;
using System.Collections.Generic;

namespace Bds_site_web.Models;

public partial class Page
{
    public string IdPage { get; set; } = null!;

    public string IdActualite { get; set; } = null!;

    public string LibellePage { get; set; } = null!;

    public DateTime DateTelechargement { get; set; }

    public virtual Actualite IdActualiteNavigation { get; set; } = null!;
}
