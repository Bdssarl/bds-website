using bds_site_web_version7_.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace bds_site_web_version7_.Controllers
{
    public class MessageController : Controller
    {
        public SiteWebBdsDbContext _siteWebBdsDbContext;
        public MessageController(SiteWebBdsDbContext siteWebBdsDbContext) {
            _siteWebBdsDbContext = siteWebBdsDbContext;
        }
        [HttpGet]
        public IActionResult Message()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Message([FromBody] MessageUser messageUser)
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
                    new Message{ ObjetMessage = messageUser.ObjetMesage,
                     DescriptionMessage=messageUser.DescriptionMessage,
                    }


                 }
            };
          
            
                _siteWebBdsDbContext.Add(user);
                 _siteWebBdsDbContext.SaveChanges();
            var responseObj = new { message = "Données reçues avec succès" };

           
            return Json(responseObj);
        }
    }
}
