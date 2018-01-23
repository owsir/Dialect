using System;
using System.Configuration;
using System.IO;
using System.Web;
using System.Web.Mvc;
using Dialect.Infrustructure;

namespace Dialect.Web.Controllers
{
    public class UpLoadController : Controller
    {
        private static readonly string UploadPath = ConfigurationManager.AppSettings["UploadPath"];
        [HttpPost]
        public JsonResult UpLoadFile()
        {
            try
            {
                var file = Request.Files[0];
                if (file == null) return null;
                var fileName = string.Concat(Guid.NewGuid().ToString(), file.FileName);
                var filePath = Path.Combine(Server.MapPath(UploadPath), fileName);
                file.SaveAs(filePath);
                var photo = new {url = fileName};
                return Json(photo);
            }
            catch (Exception e)
            {
                return Json(new {e.Message});
            }
        }

    }
}