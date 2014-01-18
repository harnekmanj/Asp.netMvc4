using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class AdditionPracticeController : Controller
    {
        //
        // GET: /AdditionPractice/

		 public ActionResult AdditionPractice()
		 {
			 Models.AdditionModel add = new Models.AdditionModel();
			 System.Random random = new Random();
			 add.Rhs = random.Next(15);
			 add.Lhs = random.Next(25);
			 return View(add);
		 }

    }
}
