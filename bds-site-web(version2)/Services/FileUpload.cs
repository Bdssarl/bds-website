namespace bds_site_web_version2_.Services
{
    public class FileUpload:IFileUpload
    {
        public async Task<bool> uploadfile(IFormFile file)
        {
            string path = string.Empty;
            try
            {
                if (file.Length > 2097152)
                {
                    path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "CV_Demande_Stage"));
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                }
                string extension = Path.GetExtension(file.FileName);
                string randomfile = Path.GetRandomFileName();

                using (var fileStream = new FileStream(Path.Combine(path, randomfile), FileMode.Create))
                {
                    await fileStream.CopyToAsync(fileStream);
                }
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("erreur", ex);

            }
        }
    }
}
