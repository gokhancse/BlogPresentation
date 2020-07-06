using BlogDAL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBLL.Models
{
    public class YorumService
    {
        BlogDbContext ent = new BlogDbContext();

        public List<Yorum> SonYorumlar()
        {
            List<Yorum> yorumListe = ent.Yorums.OrderByDescending(m => m.Tarih).Take(3).ToList();
            return yorumListe;
        }
        public List<Yorum> TumYorumlar()
        {
            List<Yorum> yorumListe = ent.Yorums.OrderByDescending(m => m.Tarih).ToList();
            return yorumListe;
        }
    }
}
