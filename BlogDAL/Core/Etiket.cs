using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL.Core
{
    public class Etiket
    {
        public int EtiketID { get; set; }

        [Required(ErrorMessage = "Lütfen etiket içeriği giriniz!")]
        [StringLength(20, ErrorMessage = "Etiket 50 karakterden uzun olmamalıdır!")]
        public string Icerik { get; set; }

        //Bir etiket birden fazla makalede kullanılabilir.
        public virtual List<Makale> Makales { get; set; }
    }
}
