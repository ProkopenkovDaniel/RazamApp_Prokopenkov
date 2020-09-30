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
            /* так, здесь возвращается View, который задан файлос Index.cshtml, 
             * то есть одноимённый с методов. То есть здесь происходит рендеринг
             * некоторой страницы и показывает её пользователю. Это может быть н обязательно
             * та же самая страница, может быть и другая, но суть в том, что возвращается 
             * некоторое представление*/
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
        
    }
}