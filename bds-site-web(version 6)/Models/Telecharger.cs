using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bds_site_web.Models;

public partial class Telecharger
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set; } = null!;

    public string IdEbook { get; set; } = null!;

    public DateTime DateTelechargement { get; set; }

    public string? Avis { get; set; }

    public string idUser { get; set; } = null!;
}
