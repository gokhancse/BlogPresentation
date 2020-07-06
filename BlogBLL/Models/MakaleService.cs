using BlogDAL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBLL.Models
{
    
    public class MakaleService
    {
        BlogDbContext ent = new BlogDbContext();
        public List<Makale> SonMakaleler()
        {
            List<Makale> makaleListe = ent.Makales.OrderByDescending(m => m.Tarih).Take(3).ToList();
            return makaleListe;
        }
        public List<Makale> MakalelerByEtiket(int etiketID)
        {
            var makaleListe = (from e in ent.Etikets
                               where e.EtiketID == etiketID
                               select e.Makales).ToList();
            return makaleListe[0]; //Sonuç içiçe koleksiyonlar şeklinde olduğu için aradığımız etikete ait makale kolleksiyonu ilk eleman içindedir. [0])
        }
        public Makale MakaleByYorum(int yorumID)
        {
            Makale yorumMakale = (from y in ent.Yorums
                          where y.YorumID == yorumID
                          select y.Makale).FirstOrDefault();
            return yorumMakale;
        }
        public List<Makale> TumMakaleler()
        {
            List<Makale> makaleListe = ent.Makales.OrderByDescending(m => m.Tarih).ToList();
            return makaleListe;
        }
    }
}
