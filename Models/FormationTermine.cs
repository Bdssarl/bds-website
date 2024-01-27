using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace bds_site_web_version7_.Models;

public partial class FormationTermine
{
    public string Id { get; set; } 

    public string IntituleFormation { get; set; } 

    public string ObjectifVise { get; set; } 

    public string CompetenceAcquise { get; set; }

    public string Participants  { get; set; }

    public string PartenaireTechnique { get; set;}
    public string Periode { get; set; }
    public string Annee { get; set; }
    public string CheminImage { get; set; }
    [NotMapped]
    public IFormFile FormFile { get; set; }
}
