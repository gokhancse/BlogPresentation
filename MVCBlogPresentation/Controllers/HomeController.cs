using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBlogPresentation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SonMakaleler()
        {
            BlogBLL.Models.MakaleService ms = new BlogBLL.Models.MakaleService();
            return PartialView(ms.SonMakaleler());
        }
        public ActionResult SonYorumlar()
        {
            BlogBLL.Models.YorumService ys = new BlogBLL.Models.YorumService();
            return PartialView(ys.SonYorumlar());
        }
        public ActionResult CokKullanilanEtiketler()
        {
            BlogBLL.Models.EtiketService es = new BlogBLL.Models.EtiketService();
            return PartialView(es.CokKullanilanEtiketler());
        }
        public ActionResult MakalelerByEtiket(int etiketID)
        {
            BlogBLL.Models.MakaleService ms = new BlogBLL.Models.MakaleService();
            return View(ms.MakalelerByEtiket(etiketID));
        }
        public ActionResult MakaleByYorum(int yorumID)
        {
            BlogBLL.Models.MakaleService ms = new BlogBLL.Models.MakaleService();
            return View(ms.MakaleByYorum(yorumID));
        }
    }
}