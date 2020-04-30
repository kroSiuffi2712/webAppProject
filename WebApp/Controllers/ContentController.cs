using System.Collections.Generic;
using System.Net.Http;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content
        public ActionResult Index()
        {
            var contentList = new List<ContentModel>();
            HttpResponseMessage response = GlobalVariable.webApiClient.GetAsync("Content").Result;
            contentList = response.Content.ReadAsAsync<List<ContentModel>>().Result;
            return View(contentList);
        }
    }
}