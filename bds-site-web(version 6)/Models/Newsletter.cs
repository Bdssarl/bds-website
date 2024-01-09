using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bds_site_web.Models;

public partial class Newsletter
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set; } = null!;

    public string NomNewsletter { get; set; } = null!;

    public string CheminMediaNewsletter { get; set; } = null!;

    public string DescriptionNewsletter { get; set; } = null!;
    public virtual ICollection<UserNewsletter> UserNewsletters { get;  }=new List<UserNewsletter>();
}
