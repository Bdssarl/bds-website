using Bds_site_web.Models;
using bds_site_web_version2_.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace bds_site_web_version2_.Controllers
{
    public class MessageController : Controller
    {
        public SiteWebBdsDbContext _siteWebBdsDbContext;
        public MessageController(SiteWebBdsDbContext siteWebBdsDbContext) {
            _siteWebBdsDbContext = siteWebBdsDbContext;
        }
        public IActionResult Message(MessageUser messageUser)
        {
            var user = new User
            {
                Email = messageUser.Email,
                LastName = messageUser.LastName,
                FirstName = messageUser.FirstName,
                PhoneNumber = messageUser.PhoneNumber,
                civilite = messageUser.civilite,

                Messages = new List<Message>
                {
                   new Message{ IdMessage="foifieofoefi", ObjetMessage = messageUser.ObjetMesage,
                    DescriptionMessage=messageUser.DescriptionMessage,
                   }


                }
            };
          
            
                _siteWebBdsDbContext.Add(user);
                 _siteWebBdsDbContext.SaveChanges();
            return View("~/Views/Acceuil/Acceuil.cshtml");
        }
    }
}
