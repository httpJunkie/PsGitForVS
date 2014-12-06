using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RenderLib.Controllers
{
    public class CommentsController : Controller
    {
        // GET: Comments
        public ActionResult Index()
        {
            return View();
        }
    }
}