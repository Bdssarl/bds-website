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
            var Users =  await _context.Users.ToListAsync();
            var Messages= await _context.Messages.ToListAsync();
            var listMessages =  from user in Users
                               join message in Messages on user.Id equals message.Id
                               select new {user.LastName, user.FirstName,user.Email,user.PhoneNumber,message.ObjetMessage,message.DateMessage};
            return View(listMessages);
        }

    }
}
