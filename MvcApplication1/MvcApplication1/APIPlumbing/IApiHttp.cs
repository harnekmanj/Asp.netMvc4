using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcApplication1.APIPlumbing
{
    public interface IApiHttp
    {
        System.Net.Http.HttpClient GetHttpClient();
    }
}
