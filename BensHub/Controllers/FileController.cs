using BensHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BensHub.Controllers
{
    public class FileController : Controller
    {
        // GET: File
        public ActionResult CollectFile(int id)
        {
            BHubDbEntities db = new BHubDbEntities();

            var file = db.Files.Find(id);
            file.DownloadCount += 1;

            db.SaveChanges();

            return new FilePathResult(file.URL, "application/pdf");
        }
    }
}