using System;
using System.Collections.Generic;
namespace Bds_site_web.Models
{
    public partial class ProjetRealise
    {
        public string IdProjetRealise { get; set; } = null!;

        public string NomProjetRealise { get; set; } = null!;

        public string DureeProjetRealise { get; set; } = null!;

        public DateTime DateDebutProjetRealise { get; set; }

        public DateTime DateFinProjetRealise { get; set; }

        public string ObjectifResultatRealise { get; set; } = null!;

        public string ResultatProjetRealise { get; set; } = null!;

        public string NomImageProjetRealise { get; set; } = null!;

        public string CheminImageProjetRealise { get; set; } = null!;
    }
}