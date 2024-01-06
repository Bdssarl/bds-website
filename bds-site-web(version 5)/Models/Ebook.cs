using System;
using System.Collections.Generic;
using Bds_site_web.Models;

namespace Bds_site_web.Models;

public partial class Ebook
{
    public string Id { get; set; } = null!;

    public string NomEbook { get; set; } = null!;

    public string TailleEbook { get; set; } = null!;

    public string ExtensionEbook { get; set; } = null!;

    public string CheminEbook { get; set; } = null!;

    public DateTime DateCreationEbook { get; set; }

   // public virtual ICollection<Consulter> Consulters { get; set; } = new List<Consulter>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
