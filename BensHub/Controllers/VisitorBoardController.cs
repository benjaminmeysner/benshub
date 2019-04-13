using BensHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BensHub.Controllers
{
    public class VisitorBoardController : Controller
    {
        [HttpPost]
        public ActionResult PostMessage(HomeViewModel homeViewModel)
        {
            BHubDbEntities db = new BHubDbEntities();

            if (ModelState.IsValid)
            {
                VisitorMessage newMessage = homeViewModel.VisitorMessage;

                newMessage.DateTime = DateTime.Now;

                db.VisitorMessages.Add(newMessage);
                db.SaveChanges();
            }

            homeViewModel.VisitorMessages = db.VisitorMessages.OrderByDescending(x => x.Id).ToList();

            return PartialView("_visitorMessagesPartialView", homeViewModel);
        }
    }
}