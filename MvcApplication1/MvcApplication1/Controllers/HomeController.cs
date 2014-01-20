using System.Web.Mvc;
using System;

namespace MvcApplication1.Controllers
{
   public class HomeController : Controller
   {
      public ActionResult Index()
      {
         ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

         return View();
      }

      public ActionResult AdditionPractice()
      {
          Models.AdditionModel add = new Models.AdditionModel();
          return View(add);
      }

      public ActionResult SubtractionPractice()
      {
          Models.SubtractModel subtract = new Models.SubtractModel();
          return View(subtract);
      }

      public ActionResult ExpandedFormPractice()
      {
          Models.ExpandedFormModel expandedForm = new Models.ExpandedFormModel();
          return View(expandedForm);
      }

      public ActionResult WriteNumberFormPractice()
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
   }
}
