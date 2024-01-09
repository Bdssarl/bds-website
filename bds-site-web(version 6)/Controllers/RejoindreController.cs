
using Bds_site_web.Models;
using bds_site_web_version2_.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace bds_site_web_version2_.Controllers
{
    public class RejoindreController : Controller
    {

        public SiteWebBdsDbContext _context { get; set; }
        
        public RejoindreController(SiteWebBdsDbContext context)
        {
            _context = context;
            

        }
        [HttpGet]
        public IActionResult NousRejoindre()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NousRejoindre(UserStage userStage)
        {
            /* création d'un objet user pour stocker les informations d'un user */

            var user = new User();
            user.civilite = userStage.civilite;
            user.Email = userStage.Email;
            user.FirstName = userStage.FirstName;
            user.LastName = userStage.LastName;
            user.PhoneNumber = userStage.PhoneNumber;
            _context.Users.Add(user);
            _context.SaveChanges();
            /*création d'un objet stage  pour stocker les informations du stage*/
            var demandeStage = new DemandeStage();
            string extension = Path.GetExtension(userStage.formFile.Name);
            string randomfile = Path.GetRandomFileName() + extension;

            demandeStage.DescriptionMessage = userStage.DescriptionMessage;
            demandeStage.ObjetMessage = userStage.ObjetMessage;
            demandeStage.NomCvDemandeStage = randomfile;

            demandeStage.DateEnvoiDemandeStage = DateTime.Now;
            ViewBag.Message = "utilisateur ajouté avec succès";

            return View();
        }
        public IActionResult Rejoindre()
        {
            return View();
        }
        [HttpGet]
        public IActionResult PostulerStage(UserStage userStage)
        {

            var user = new User();
            user.civilite = userStage.civilite;
            user.Email = userStage.Email;
            user.FirstName = userStage.FirstName;
            user.LastName = userStage.LastName;
            user.PhoneNumber = userStage.PhoneNumber;
            _context.Users.Add(user);
            _context.SaveChanges();


            return View();
        }

    }
}
