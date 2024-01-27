using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Bds_site_web.Models;

namespace bds_site_web_version7_.Models;

public partial class Ebook
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set; } = null!;

    public string NomEbook { get; set; } = null!;

    public string TailleEbook { get; set; } = null!;

    public string ExtensionEbook { get; set; } = null!;

    public string CheminEbook { get; set; } = null!;

    public DateTime DateCreationEbook { get; set; }

   // public virtual ICollection<Consulter> Consulters { get; set; } = new List<Consulter>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
