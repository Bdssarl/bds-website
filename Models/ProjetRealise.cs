using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace bds_site_web_version7_.Models
{
    public partial class ProjetRealise
    {
        public string Id { get; set; } = null!;

        public string Intitule_Projet { get; set;} 
        public string Donneur_Ordre { get; set;} 
        public string Duree { get; set; }
        public string TacheExecute { get; set; }
        public string Annee { get; set; }
        public string ChemImageProjetRealise { get; set;}
        [NotMapped]
        public IFormFile FormFile { get; set;}
    }
}