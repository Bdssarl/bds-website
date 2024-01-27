using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bds_site_web_version7_.Models
{
    public class ProjetAvenirListViewComponent:ViewComponent
    {
        private readonly SiteWebBdsDbContext _context;
        public ProjetAvenirListViewComponent(SiteWebBdsDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var projetAvenirs = await _context.ProjetAVenirs.ToListAsync();
            return View(projetAvenirs);
        }
    }
}
