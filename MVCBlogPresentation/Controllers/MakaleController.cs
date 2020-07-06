using BlogBLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBlogPresentation.Controllers
{
    public class MakaleController : Controller
    {
        // GET: Makale
        public ActionResult Index()
        {
            MakaleService ms = new MakaleService();
            return View(ms.TumMakaleler());
        }
    }
}