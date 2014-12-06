using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RenderLib.Controllers
{
    public class RenderController : Controller
    {
        // GET: Render
        public ActionResult Index()
        {
            return View();
        }
    }
}