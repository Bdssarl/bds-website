﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace bds_site_web_version7_.Models
{
    public class TypeEmploi
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; } = null!;

        [StringLength(255, ErrorMessage = "vous avez atteint la taille limite ")]
        public string LibelleTypeEmploi { get; set; } = null!;
        [NotMapped]
        public string DomaineEmploi { get; set; } = null!;
        public virtual ICollection<Emploi> Emplois { get; set; } = new List<Emploi>();
    }
}