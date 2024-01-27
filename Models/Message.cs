﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace bds_site_web_version7_.Models;

public partial class Message
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set; } = null!;

    public string ObjetMessage { get; set; } = null!;

    public string DescriptionMessage { get; set; } = null!;

    public DateTime DateMessage { get; set; }
    public string IdUser { get; set; } = null!;
    public User user { get; set; } = null!;
}
