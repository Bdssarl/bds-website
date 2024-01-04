
using Microsoft.AspNetCore.Identity;

namespace Bds_site_web.Models
{
    public class User : IdentityUser
    {
        public string civilite { get; set; } = null!;

        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public ICollection<Message> Messages { get; set; } = new List<Message>();
        public virtual ICollection<Ebook> Ebooks { get; set; } = new List<Ebook>();
        public virtual ICollection<Stage> Stages { get; set; } = new List<Stage>();
        public virtual ICollection<Emploi> Emplois { get; set; } = new List<Emploi>();
        public virtual ICollection<AnnonceRecrutement> AnnonceRecrutements { get; set; } = new List<AnnonceRecrutement>();
    }
}