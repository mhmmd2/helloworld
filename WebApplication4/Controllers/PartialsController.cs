using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class PartialsController : Controller
    {
        // GET: Partials
        public ActionResult Navigation()
        {
            var navbaritems = new NavbarItems
            {
                categories = new List<string>() { "kategori 1", "kategori 2", "kategori 3"}
            };
            return PartialView("Navigation", navbaritems);
        }
    }
}