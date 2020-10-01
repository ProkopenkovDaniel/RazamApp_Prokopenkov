using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RazamApp.Models;
using RazamApp.Util;

namespace RazamApp.Controllers
{
    public class HomeController : Controller
    {
        public MessageContext db;
        public ActionResult Index()
        {
            db = new MessageContext();
            return View(db.Messages);
        }
    }
}