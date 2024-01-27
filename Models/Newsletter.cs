using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace bds_site_web_version7_.Models;

public partial class Newsletter
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set; } = null!;

    public string NomNewsletter { get; set; } = null!;

    public string CheminMediaNewsletter { get; set; } = null!;

    public string DescriptionNewsletter { get; set; } = null!;
    public virtual ICollection<UserNewsletter> UserNewsletters { get;  }=new List<UserNewsletter>();
}
