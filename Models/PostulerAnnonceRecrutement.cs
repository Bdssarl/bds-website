﻿using System;
using System.Collections.Generic;

namespace bds_site_web_version7_.Models;

public partial class PostulerAnnonceRecrutement
{
    public string IdPostulerAnnonceRecrutement { get; set; } = null!;

    public string IdAnnonceRecrutement { get; set; } = null!;

    public string MessagePostulerAnnonceRecrutement { get; set; } = null!;

    public DateTime DateEnvoiPostulerAnnonceRecrutement { get; set; }

}
