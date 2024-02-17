using bds_site_web_version7_.Models;
using bds_site_web_version7_.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace bds_site_web_version7_.Controllers
{
    public class MessageController : Controller
    {
        private readonly SiteWebBdsDbContext _siteWebBdsDbContext;
        private readonly IEmailSender _emailSender;
        public MessageController(SiteWebBdsDbContext siteWebBdsDbContext,IEmailSender emailSender) {
            _siteWebBdsDbContext = siteWebBdsDbContext;
            _emailSender = emailSender;
        }
        [HttpGet]
        public IActionResult Message()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Message( MessageUser messageUser)
        {
            var user = new User
            {
                Email = messageUser.Email,
                 LastName = messageUser.LastName,
                 FirstName = messageUser.FirstName,
                 PhoneNumber = messageUser.PhoneNumber,
                 civilite = messageUser.civilite,

                 Messages = new List<Models.Message>
                 {
                    new Models.Message{ ObjetMessage = messageUser.ObjetMesage,
                     DescriptionMessage=messageUser.DescriptionMessage,
                    }


                 }
            };
          
            
                _siteWebBdsDbContext.Add(user);
                 _siteWebBdsDbContext.SaveChanges();
            var responseObj = new { message = "Données reçues avec succès" };
            var message = new Services.Message(new string[] {"vanleroy53@gmail.com"}, "confirmation de la reception de votre  message ", "l'equipe de bds-sarl tient à vous remercier pour.");
            _emailSender.SendEmail(message);
            return View ();
        }
    }
}
