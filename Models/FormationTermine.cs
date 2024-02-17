using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bds_site_web_version7_.Models;

public partial class FormationTermine
{
    public string Id { get; set; }
    [StringLength(255, ErrorMessage = "vous avez atteint la taille limite")]
    public string IntituleFormation { get; set; }
    [StringLength(255, ErrorMessage = "vous avez atteint la taille limite")]
    public string ObjectifVise { get; set; }
    [StringLength(255, ErrorMessage = "vous avez atteint la taille limite")]
    public string CompetenceAcquise { get; set; }
    [StringLength(255, ErrorMessage = "vous avez atteint la taille limite")]
    public string Participants  { get; set; }
    [StringLength(255, ErrorMessage = "vous avez atteint la taille limite")]
    public string PartenaireTechnique { get; set;}
    [StringLength(25, ErrorMessage = "vous avez atteint la taille limite")]
    public string Periode { get; set; }
    [StringLength(4, ErrorMessage = "vous avez atteint la taille limite")]
    public string Annee { get; set; }
    public string CheminImage { get; set; }
    [NotMapped]
    public IFormFile FormFile { get; set; }
}
