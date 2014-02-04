using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApplication2.Controllers
{
    public class ExpandedFormController : ApiController
    {
        public IEnumerable<string> GetNumberInTextFormat()
        {
            Models.ExpandedFormModel expandedFormModel = new Models.ExpandedFormModel();
            return expandedFormModel.NumberInEnglishForm;
        }
    }
}