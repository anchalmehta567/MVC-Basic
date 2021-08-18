using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Basic.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index1()
        {
            return "Hello inside controller";
        }
        public string Name() 
        { 
            return "Hello Anchal"; 
        }
        public ActionResult Index() { return View(); }
    }
}