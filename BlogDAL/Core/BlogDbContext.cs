using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL.Core
{
    public class BlogDbContext : DbContext
    {
        //Veritabanımızda oluşmasını istediğimiz tablolara karşılık gelmek üzere tüm sınıflarımızı DBSet içerisinde çağırmalıyız.
        public DbSet<Uye> Uyes { get; set; }
        public DbSet<Makale> Makales { get; set; }
        public DbSet<Yorum> Yorums { get; set; }
        public DbSet<Etiket> Etikets { get; set; }
    }
}
