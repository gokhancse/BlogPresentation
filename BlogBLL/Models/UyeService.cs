using BlogDAL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBLL.Models
{
    public class UyeService
    {
        BlogDbContext ent = new BlogDbContext();

        public Uye UyeKontrol(string Email, string Sifre)
        {
            Uye uye = (from u in ent.Uyes
                       where u.Email == Email && u.Sifre == Sifre
                       select u).FirstOrDefault();
            return uye;
        }
    }
}
