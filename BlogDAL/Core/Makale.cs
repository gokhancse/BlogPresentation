using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL.Core
{
    public class Makale
    {
        public int MakaleID { get; set; }

        [Required(ErrorMessage ="Lütfen makale başlığını giriniz!")]
        [StringLength(50, ErrorMessage = "Başlık 50 karakterden uzun olmamalıdır!")]
        public string Baslik { get; set; }

        [Required(ErrorMessage = "Lütfen makale içeriğini giriniz!")]
        [DataType(DataType.Html, ErrorMessage = "İçeriği Html formatına uygun giriniz!" )]
        public string Icerik { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Tarih formatına uygun giriniz!")]
        public DateTime Tarih { get; set; }

        //Her makale bir üyeye aittir.
        public virtual Uye Uye { get; set; }

        //Bir makale hakkında çok sayıda yorum olabilir.
        public virtual List<Yorum> Yorums { get; set; }

        //Bir makalede çok sayıda etiket bulunabilir.
        public virtual List<Etiket> Etikets { get; set; }
    }
}
