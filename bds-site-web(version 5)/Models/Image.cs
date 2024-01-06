using System;
using System.Collections.Generic;

namespace Bds_site_web.Models;

public partial class Image
{
    public string Id { get; set; } = null!;

    public string NomImage { get; set; } = null!;

    public string TailleImage { get; set; } = null!;

    public string TypeImage { get; set; } = null!;

    public string ExtensionImage { get; set; } = null!;

    public string CheminImage { get; set; } = null!;

    public DateTime DateCreation { get; set; }

    public string HauteurImage { get; set; } = null!;

    public string LargeurImage { get; set; } = null!;
}
