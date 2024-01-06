using System;
using System.Collections.Generic;

namespace Bds_site_web.Models;

public partial class Formation
{
    public string Id { get; set; } = null!;

    public string NomFormation { get; set; } = null!;

    public string DescriptionFormation { get; set; } = null!;

    public DateTime DebutFormation { get; set; }

    public DateTime FinFormation { get; set; }

    public string? StatutFormation { get; set; }
}
