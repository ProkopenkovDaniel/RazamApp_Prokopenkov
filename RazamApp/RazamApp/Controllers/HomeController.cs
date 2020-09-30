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
        MessageContext db = new MessageContext();
        public ActionResult Index()
        {
           IEnumerable<Message> messages = db.Messages;
           ViewBag.Messages = messages;
           // ViewBag.MessageId = "0001";
            return View(db.Messages);
        }

        public ActionResult GetHtml()
        {

            //использование класса результата дейтсвий
            return new HtmlResult("<h2>Привет мир!</h2>");
        }

        public ActionResult GetContext()
        {
            string browser = HttpContext.Request.Browser.Browser;
            string user_agent = HttpContext.Request.UserAgent;
            string url = HttpContext.Request.RawUrl;
            string ip = HttpContext.Request.UserHostAddress;
            string referrer = HttpContext.Request.UrlReferrer == null ? "" : HttpContext.Request.UrlReferrer.AbsoluteUri;
            return Content("<p>Browser: " + browser + "</p><p>User-Agent: " + user_agent + "</p><p>Url запроса: " + url +
                "</p><p>Реферер: " + referrer + "</p><p>IP-адрес: " + ip + "</p>");
        }

        [HttpPost]
        public ActionResult Send(string[] countries)
        {
            string result=null;
            foreach (string contry in countries)
            {
                result += contry;
                result += ";";

            }
            return Content(result);
        }

        [HttpPost]
        public ActionResult MyAction(string product, string action)
        {
            string response=null;
            if (action == "add")
            {
                response = "Add";
            }
            else if (action == "delete")
            {
                response = "delete";
            }
            return Content(response);
        }

        [HttpGet]
        public ActionResult EditBook(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Message message = db.Messages.Find(id);
            if (message != null)
            {
                return View(message);
            }
            return HttpNotFound();
        }

    }
}