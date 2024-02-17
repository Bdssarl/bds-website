using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bds_site_web_version7_.Models
{
    public class DemandeEmploiListViewComponent:ViewComponent
    {
        private readonly SiteWebBdsDbContext _context;
        public DemandeEmploiListViewComponent(SiteWebBdsDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var demandeEmplois = await _context.DemandeEmplois.ToListAsync();
            var users = await _context.Users.ToListAsync();
            var emplois = await _context.Emplois.ToListAsync();
            var output = from demande in demandeEmplois
                         join user in users on demande.UserId equals user.Id
                         join stage in emplois on demande.EmploiId equals stage.Id
                         select new { user.LastName, user.FirstName, user.Email, user.civilite, user.PhoneNumber, demande.ObjetMessageEmploi, demande.MessageDemandeEmploi, demande.NomCvDemandeEmploi, demande.DateEnvoiDemandeEmploi};
            return View(output);
        }
    }
}
