using System;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace Dialect.Web.Controllers
{
    public class UpLoadController : Controller
    {
        [HttpPost]
        public JsonResult UpLoadFile()
        {
            try
            {
                var file = Request.Files[0];
                if (file == null) return null;
                var fileName = string.Concat(Guid.NewGuid().ToString(), file.FileName);
                var filePath = Path.Combine(Server.MapPath("../Upload/"), fileName);
                file.SaveAs(filePath);
                var photo = new {url = fileName};
                return Json(photo);
            }
            catch (Exception e)
            {
                return Json(e);
            }
        }

    }
}