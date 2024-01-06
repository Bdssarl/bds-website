using System;
using System.Collections.Generic;

namespace Bds_site_web.Models;

public partial class Telecharger
{
    public string Id { get; set; } = null!;

    public string IdEbook { get; set; } = null!;

    public DateTime DateTelechargement { get; set; }

    public string? Avis { get; set; }

    public string idUser { get; set; } = null!;
}
