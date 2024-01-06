using System;
using System.Collections.Generic;

namespace Bds_site_web.Models;

public partial class Consulter
{
    public string Id { get; set; } = null!;

    public string IdConsulter { get; set; } = null!;

    public DateTime DateConsulter { get; set; }

    public string IdUser { get; set; } = null!;
}
