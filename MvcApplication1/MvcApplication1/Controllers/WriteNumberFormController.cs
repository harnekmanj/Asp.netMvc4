using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class WriteNumberFormController : ApiController
    {
        //
        // GET: /WriteNumberForm/

        public IEnumerable<string> GetNumberInTextFormat()
        {
            Models.ExpandedFormModel expandedFormModel = new Models.ExpandedFormModel();
            //return expandedFormModel.NumberInEnglishForm();
            return new List<string>();
        }

    }
}
