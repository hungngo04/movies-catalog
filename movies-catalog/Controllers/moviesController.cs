using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace movies_catalog.Controllers
{
    public class moviesController : Controller
    {
        // GET: movies
        public ActionResult Index()
        {
            return View();
        }
    }
}