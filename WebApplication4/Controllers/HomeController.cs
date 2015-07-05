using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult PersonDo()
        {
            var person = new Person
            {
                name = "ali",
                surname = "veli",
                birthdate = new DateTime(1988, 2, 1),
                likesmusic = true,
                skills = new List<string>() { "math", "science", "history" }

            };
            return View(person);
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}