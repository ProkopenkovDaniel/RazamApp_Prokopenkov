using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RazamApp.Models;

namespace RazamApp.Controllers
{
    public class HomeController : Controller
    {
        MessageContext db = new MessageContext();
        public ActionResult Index()
        {
            IEnumerable<Message> messages = db.Messages;
            ViewBag.Messages = messages;
            return View();
        }
    }
}