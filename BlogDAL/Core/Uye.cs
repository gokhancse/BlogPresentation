using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL.Core
{
    public class Uye
    {
        public int UyeID { get; set; }

        [Required(ErrorMessage = "Lütfen üye adını giriniz!")]
        [StringLength(20, ErrorMessage = "İsim 20 karakterden uzun olmamalıdır!")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Lütfen üye soyadını giriniz!")]
        [StringLength(20, ErrorMessage = "Soyisim 20 karakterden uzun olmamalıdır!")]
        public string Soyad { get; set; }

        [Required(ErrorMessage = "Lütfen email adresini giriniz!")]
        [EmailAddress(ErrorMessage = "Email formatına uygun giriniz!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz!")]
        [DataType(DataType.Password)]
        public string Sifre { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Tarih formatına uygun giriniz!")]
        public DateTime Tarih { get; set; }

        //Bir üye çok sayıda makale yazabilir.
        public virtual List<Makale> Makales{ get; set; }

        //Bir üye çok sayıda yorum yapabilir.
        public virtual List<Yorum> Yorums { get; set; }
    }
}
