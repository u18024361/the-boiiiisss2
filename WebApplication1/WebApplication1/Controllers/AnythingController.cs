using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class AnythingController : Controller
    {
        // GET: Anything
        public ActionResult Index()
        {
            return View();
        }
    }
}