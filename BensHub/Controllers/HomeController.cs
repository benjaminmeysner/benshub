using BensHub.Models;
using System.Linq;
using System.Web.Mvc;

namespace BensHub.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            BHubDbEntities db = new BHubDbEntities();

            // Get hit counts
            var stats = db.SiteStatistics.Find(0);

            stats.NumberOfHits += 1;
            db.SaveChanges();

            HomeViewModel homeVM = new HomeViewModel
            {
                VisitorMessages = db.VisitorMessages.OrderByDescending(x => x.Id),
                VisitorMessage = new VisitorMessage(),
                SiteStatistics = stats,
                Files = db.Files.OrderBy(x => x.FileId)
            };

            return View(homeVM);
        }
    }
}