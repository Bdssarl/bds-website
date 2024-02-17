using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace bds_site_web_version7_.Models
{

    public partial class Image
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; } =null!;
       
        public string NomImage { get; set; } =null!;

        public string TailleImage { get; set; } =null;

        public string TypeImage { get; set; } 

        public string ExtensionImage { get; set;}

        public string CheminImage { get; set; } = null;

        public DateTime DateCreation { get; set;}

        public string HauteurImage { get; set;} 

        public string LargeurImage { get; set;} 
        [NotMapped]
        public IFormFile formfile { get; set;}
    }
}