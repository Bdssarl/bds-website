using bds_site_web_version7_.Models;

namespace bds_site_web_version7_.Services
{
    public interface IFileUpload
    {
        public string uploadimage(IFormFile formFile, string TypeImage);
        public string uploadVideo(IFormFile formfile);
        public string uploadfile(IFormFile formfile,string typedemande);
    }
}
