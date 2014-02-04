using System.Web.Mvc;
using System;
using System.Collections.Generic;

namespace MvcApplication1.Controllers
{
   public class HomeController : Controller
   {
      private Models.Interface.IGenerateMathEquation _generateMathEquation;
      private APIPlumbing.IApiHttp _apiHttp;

      public HomeController(Models.Interface.IGenerateMathEquation generateMathEquation, APIPlumbing.IApiHttp apiHttp)
      {
          _generateMathEquation = generateMathEquation;
          _apiHttp = apiHttp;
      }

      public ActionResult Index()
      {
         ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
         Models.IntDataModel intDataModel = new Models.IntDataModel();
         foreach (int number in GetNumbers())
         {
             intDataModel.Add(number);
         }
         return View(intDataModel);
      }

      public ActionResult AdditionPractice()
      {
          Models.AdditionModel add = new Models.AdditionModel();
          return View(add);
      }

      public ActionResult SubtractionPractice()
      {
          Models.Interface.IGenerateMathEquation generateMathEquation = new Models.GenerateMathEquation();
          return View(_generateMathEquation.GetSubtractEquations());
      }

      public ActionResult ExpandedFormPractice()
      {
          Models.ExpandedFormModel expandedForm = new Models.ExpandedFormModel();
          return View(expandedForm);
      }

      public ActionResult NumberFormPractice()
      {
          Models.ExpandedFormModel expandedForm = new Models.ExpandedFormModel();
          return View(expandedForm);
      }

      public ActionResult PatternFormPractice()
      {
          return View();
      }


      public ActionResult About()
      {
         ViewBag.Message = "Your app description page.";

         return View();
      }

      public ActionResult Contact()
      {
         ViewBag.Message = "Your contact page.";

         return View();
      }

      private IEnumerable<int> GetNumbers()
      {
          System.Net.Http.HttpResponseMessage response = _apiHttp.GetHttpClient().GetAsync("Api/MathApi/GetNumbers").Result;
          var ret = response.Content.ReadAsStringAsync().Result;
          return GetReturnType<List<int>>(ret);
      }

      private T GetReturnType<T>(string result)
      {
          return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(result);
      }
   }
}
