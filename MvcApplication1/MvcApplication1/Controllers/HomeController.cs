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
          System.Random random = new Random();
          add.Rhs = random.Next(15);
          add.Lhs = random.Next(25);
          return View(add);
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
