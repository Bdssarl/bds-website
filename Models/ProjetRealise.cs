using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bds_site_web_version7_.Models
{
    public partial class ProjetRealise
    {
        public string Id { get; set; } = null!;
        [StringLength(255, ErrorMessage = "vous avez atteint la taille limite ")]
        public string Intitule_Projet { get; set;}
        [StringLength(255, ErrorMessage = "vous avez atteint la taille limite ")]
        public string Donneur_Ordre { get; set;}
        [StringLength(255, ErrorMessage = "vous avez atteint la taille limite ")]
        public string Duree { get; set; }
        [StringLength(255, ErrorMessage = "vous avez atteint la taille limite ")]
        public string TacheExecute { get; set; }
        [StringLength(4, ErrorMessage = "vous avez atteint la taille limite ")]
        public string Annee { get; set; }
        public string ChemImageProjetRealise { get; set;}
        [NotMapped]
        public IFormFile FormFile { get; set;}
    }
}