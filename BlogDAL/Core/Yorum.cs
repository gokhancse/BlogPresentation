using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL.Core
{
    public class Yorum
    {
        public int YorumID { get; set; }

        [Required(ErrorMessage = "Lütfen yorumunuzu giriniz!")]
        public string Icerik { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Tarih formatına uygun giriniz!")]
        public DateTime Tarih { get; set; }

        //Her yorumu yazan bir üye vardır.
        public virtual Uye Uye { get; set; }

        //Her yorum bir makaleye aittir.
        public virtual Makale Makale { get; set; }
    }
}
