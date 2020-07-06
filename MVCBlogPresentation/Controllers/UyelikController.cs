using BlogBLL.Models;
using BlogDAL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBlogPresentation.Controllers
{
    public class UyelikController : Controller
    {
        // GET: Uyelik
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UyeGiris()
        {
            return View();
        }
        [HttpPost]
        public string UyeGiris(string Email, string Sifre)
        {
            UyeService us = new UyeService();
            Uye uye = (Uye)us.UyeKontrol(Email, Sifre);
            if (uye == null) return "Hatalı email yada şifre girişi!";
            return "";
        }
    }
}