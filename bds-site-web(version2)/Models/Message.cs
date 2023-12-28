using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Bds_site_web.Models;

public partial class Message
{
    public string IdMessage { get; set; } = null!;

    public string ObjetMessage { get; set; } = null!;

    public string DescriptionMessage { get; set; } = null!;

    public DateTime DateMessage { get; set; }
    public string IdUser { get; set; } = null!;
    public User user { get; set; } = null!;
}
