using System;
using System.Collections.Generic;

namespace Bds_site_web.Models;

public partial class Newsletter
{
    public string IdNewsletter { get; set; } = null!;

    public string NomNewsletter { get; set; } = null!;

    public string CheminMediaNewsletter { get; set; } = null!;

    public string DescriptionNewsletter { get; set; } = null!;
    public virtual ICollection<UserNewsletter> UserNewsletters { get;  }=new List<UserNewsletter>();
}
