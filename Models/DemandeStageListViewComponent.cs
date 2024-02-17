using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bds_site_web_version7_.Models
{
    public class DemandeStageListViewComponent:ViewComponent
    {
        private readonly SiteWebBdsDbContext _context;
        public DemandeStageListViewComponent(SiteWebBdsDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var demandeStages = _context.DemandeStages.ToList();
            var users = await _context.Users.ToListAsync();
            var stages=_context.Stages.ToList();
            var bannieres = await _context.Images.Where(e => e.TypeImage == "banniere").ToListAsync();
            var output =  from demande in demandeStages
                               join user in users on demande.UserId equals user.Id
                               join stage in stages on demande.StageId equals stage.Id
                               select new { user.LastName,user.FirstName,user.Email,user.civilite,user.PhoneNumber,demande.ObjetMessage,demande.DescriptionMessage,demande.NomCvDemandeStage,demande.DateEnvoiDemandeStage};
            return View(output);
        }
    }
}
