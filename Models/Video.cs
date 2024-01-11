using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bds_site_web.Models;

public partial class Video
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set; } = null!;

    public string NomVideo { get; set; } = null!;

    public string TailleVideo { get; set; } = null!;

    public string ExtensionVideo { get; set; } = null!;

    public string CheminVideo { get; set; } = null!;

    public DateTime DateCreationVideo { get; set; }
}
