using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bds_site_web_version7_.Models
{
    public class DemandeStageListView:ViewComponent
    {
        private readonly SiteWebBdsDbContext _context;
        public DemandeStageListView(SiteWebBdsDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var Stages = await _context.DemandeStages.ToListAsync();
            return View(Stages);
        }
    }
}
