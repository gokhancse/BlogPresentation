using BlogBLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBlogPresentation.Controllers
{
    public class YorumController : Controller
    {
        // GET: Yorum
        public ActionResult Index()
        {
            YorumService ys = new YorumService();
            return View(ys.TumYorumlar());
        }
    }
}