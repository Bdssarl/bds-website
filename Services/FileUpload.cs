using Microsoft.AspNetCore.Routing.Constraints;

namespace bds_site_web_version7_.Services
{
    public class FileUpload:IFileUpload
    {

        private readonly IWebHostEnvironment _env;
        public FileUpload(IWebHostEnvironment env)
        {
            _env = env;
        }
        public string uploadfile(IFormFile file,string typedemande)
        {
            string path = string.Empty;
            try
            {
                if (file.Length <= 2097152)
                {
                    if (typedemande == "emploi")
                    {
                        path = Path.GetFullPath(Path.Combine(_env.WebRootPath,"CV", "CV_Demande_Emploi"));
                    }
                    else
                    {
                        if (typedemande == "stage")
                        {
                            path = Path.GetFullPath(Path.Combine(_env.WebRootPath, "CV", "CV_Demande_Stage"));
                        }
                    }
                    
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                }
                string fileName = $"{DateTime.Now.ToFileTime()}-{file.FileName}";

                using (var fileStream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                {
                   
                    
                    file.OpenReadStream().CopyTo(fileStream);
                }
                return fileName;
            }
            catch (Exception ex)
            {

                throw new Exception("erreur", ex);

            }
        }

        public string uploadimage(IFormFile file, string TypeImage)
        {
            string path = string.Empty;
            try
            {
                if (file.Length > 0)
                {
                    if (TypeImage == "banniere") {
                        path = Path.GetFullPath(Path.Combine(_env.WebRootPath, "Images","Banniere"));
                    }
                    else
                    {
                        if (TypeImage == "projet")
                        {
                            path = Path.GetFullPath(Path.Combine(_env.WebRootPath, "Images", "Projet"));

                        }
                        else
                        {
                            if (TypeImage == "temoignage")
                            {
                                path = Path.GetFullPath(Path.Combine(_env.WebRootPath, "Images", "Temoignage"));
                            }
                            else
                            {
                                if (TypeImage == "metier")
                                {
                                    path = Path.GetFullPath(Path.Combine(_env.WebRootPath, "Images", "Metier"));
                                }
                                else
                                {
                                    if (TypeImage == "formation")
                                    {
                                        path = Path.GetFullPath(Path.Combine(_env.WebRootPath, "Images", "Formation"));
                                    }
                                    else
                                    {
                                        if (TypeImage == "partennaire")
                                        {
                                            path = Path.GetFullPath(Path.Combine(_env.WebRootPath, "Images", "Partennaires"));
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            
                string fileName = $"{DateTime.Now.ToFileTime()}-{file.FileName}";

                using (var fileStream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                


                    file.OpenReadStream().CopyTo(fileStream);
                
                return fileName;
            }
            catch (Exception ex)
            {

                throw new Exception("erreur", ex);

            }
        }
        public string uploadVideo(IFormFile file)
        {
            string path = string.Empty;
            try
            {
                if (file.Length > 0)
                {
                    path = Path.GetFullPath(Path.Combine(_env.WebRootPath, "Videos"));
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                }
                string fileName = $"{DateTime.Now.ToFileTime()}-{file.FileName}";

                using (var fileStream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                {


                    file.OpenReadStream().CopyTo(fileStream);
                }
                return fileName;
            }
            catch (Exception ex)
            {

                throw new Exception("erreur", ex);

            }
        }
    }
}
