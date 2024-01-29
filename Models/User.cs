
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace bds_site_web_version7_.Models
{
    public class User : IdentityUser
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public override string Id { get; set;}
        public string civilite { get; set; } = null!;

        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public ICollection<Message> Messages { get; set; } = new List<Message>();
        public virtual ICollection<Ebook> Ebooks { get; set; } = new List<Ebook>();
        public virtual ICollection<Emploi> Emplois { get; set; } = new List<Emploi>();
        public virtual ICollection<AnnonceRecrutement> AnnonceRecrutements { get; set; } = new List<AnnonceRecrutement>();
        public virtual ICollection<Stage> Stages { get; set; } = new List<Stage>();
    }
}