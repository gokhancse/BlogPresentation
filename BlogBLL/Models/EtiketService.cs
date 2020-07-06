using BlogDAL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBLL.Models
{
    
    public class EtiketService
    {
        BlogDbContext ent = new BlogDbContext();

        public List<Etiket> CokKullanilanEtiketler()
        {
            //En çok makaleyle ilişkilendirilmiş 5 adet etiketi döndürecek list kolleksiyonunu oluşturuyoruz.
            List<Etiket> etiketListe = (from e in ent.Etikets
                                        orderby e.Makales.Count() descending
                                        select e).Take(5).ToList();
            return etiketListe;
        } 
    }
}
