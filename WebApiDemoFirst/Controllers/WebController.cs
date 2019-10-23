using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiDemoFirst.Controllers
{
    public class WebController : ApiController
    {
        private static List<string> myname = new List<string> { "Hridoy", "Suvo", "Joy", "Bijoy" };

        [HttpGet]
        public IEnumerable<string> name()
        {
            return myname;       
        }

        [HttpGet]
        public string namebyid(int id)
        {
            return myname[id];
        }
    }
}
