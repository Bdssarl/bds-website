using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace bds_site_web_version7_.Models
{
    public class MessageListViewComponent:ViewComponent
    {
        private readonly SiteWebBdsDbContext _context;
        public MessageListViewComponent(SiteWebBdsDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var messages = await _context.Users.Include(e => e.Messages).OrderDescending().ToListAsync();      
            return View(messages);
        }

    }
}
