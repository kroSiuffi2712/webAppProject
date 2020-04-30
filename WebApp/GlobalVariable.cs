using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace WebApp
{
    public class GlobalVariable
    {
        public static HttpClient webApiClient = new HttpClient();

        static GlobalVariable()
        {
            webApiClient.BaseAddress = new Uri("https://localhost:44397/api/");
            webApiClient.DefaultRequestHeaders.Clear();
            webApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}