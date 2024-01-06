using Bds_site_web.Models;
using bds_site_web_version2_.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace bds_site_web_version2_.Controllers
{
    public class RejoindreController : Controller
    {

        public SiteWebBdsDbContext _context { get; set; }
        public UserManager<User>  _userManager { get; set; }
        public RejoindreController(SiteWebBdsDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;

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

            var user=new User();
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
            string randomfile = Path.GetRandomFileName()+extension;
            
            demandeStage.DescriptionMessage = userStage.DescriptionMessage;
            demandeStage.ObjetMessage = userStage.ObjetMessage;
            demandeStage.NomCvDemandeStage = randomfile;

            demandeStage.DateEnvoiDemandeStage = DateTime.Now;
            ViewBag.Message ="utilisateur ajouté avec succès";
           
            return View();
        }
        public IActionResult Rejoindre()
        {
            return View();
        }
        [HttpGet]
        public IActionResult PostulerStage(UserStage userStage)
        {

            var stage = new Stage
            {
                
                DomaineStage = "informatique"
               
            };
            _context.Stages.Add(stage);
            /*création d'un objet stage  pour stocker les informations du stage*/
            
          /*  string extension = Path.GetExtension(userStage.formFile.Name);*/
            /*string randomfile = Path.GetRandomFileName() + extension;*/
            var demandeStage = new DemandeStage
            {
                DescriptionMessage = userStage.DescriptionMessage,
                ObjetMessage = userStage.ObjetMessage,
                /*NomCvDemandeStage = randomfile,*/

                DateEnvoiDemandeStage = DateTime.Now,
                Users = new List<User> {
           new User {
            civilite = userStage.civilite,
            Email = userStage.Email,
            FirstName = userStage.FirstName,
            LastName = userStage.LastName,
            PhoneNumber = userStage.PhoneNumber,
            }

        }
        
        };
            _context.DemandeStages.Add(demandeStage);
            _context.SaveChanges();
            return View();
        }
        
    }
}
