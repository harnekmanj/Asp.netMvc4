using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.APIPlumbing
{
    internal class ApiHttp : IApiHttp
    {
        public System.Net.Http.HttpClient GetHttpClient()
        {
            System.Net.Http.HttpClient httpClient = new System.Net.Http.HttpClient();
            httpClient.BaseAddress = new Uri(@"http://localhost:60736/");
            httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            return httpClient;
        }
    }
}