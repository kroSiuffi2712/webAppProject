using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content
        public ActionResult Content()
        {
            var contentList = GetContentList();
            return View(contentList);
        }

        private List<ContentViewModel> GetContentList()
        {
            try
            {
                var client = new HttpClient();
                var contentList = new List<ContentViewModel>();
                var getDataTask = client.GetAsync(AppConfig.ApiUrl)
                    .ContinueWith(response =>
                      {
                          var result = response.Result;
                          if (result.StatusCode == System.Net.HttpStatusCode.OK)
                          {
                              var readResult = result.Content.ReadAsAsync<List<ContentViewModel>>();
                              readResult.Wait();
                              contentList = readResult.Result;
                          }
                      });
                getDataTask.Wait();
                return contentList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}