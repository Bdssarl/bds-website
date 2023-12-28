
using Microsoft.AspNetCore.Identity;

namespace Bds_site_web.Models
{
    public class User : IdentityUser
    {
        public string civilite { get; set; }
        public ICollection<Message> Messages { get; } = new List<Message>();
        public virtual ICollection<Ebook> Ebooks { get; set; } = new List<Ebook>();
        public virtual ICollection<Stage> Stages { get; set; } = new List<Stage>();
        public virtual ICollection<Emploi> Emplois { get; set; } = new List<Emploi>();
        public virtual ICollection<AnnonceRecrutement> AnnonceRecrutements { get; set; } = new List<AnnonceRecrutement>();
    }
}