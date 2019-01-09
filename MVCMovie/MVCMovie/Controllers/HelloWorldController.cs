using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }


        public string Welcome(String firstName, String lastName, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Welcome to The Movie app " + firstName + " " + lastName + " " + ID);
        }

       
    }
}