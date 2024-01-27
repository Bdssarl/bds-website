using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bds_site_web_version7_.Models
{
   
    public class ChiffreListViewComponent:ViewComponent
    {
        private readonly SiteWebBdsDbContext _context;
        public ChiffreListViewComponent(SiteWebBdsDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var chiffres = await _context.Chiffres.FirstAsync();
            return View(chiffres);
        }

    }
}
