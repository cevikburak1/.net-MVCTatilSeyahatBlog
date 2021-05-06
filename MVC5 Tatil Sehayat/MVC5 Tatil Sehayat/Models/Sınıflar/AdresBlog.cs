using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5_Tatil_Sehayat.Models.Sınıflar
{
    public class AdresBlog
    {
        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string Acikllama { get; set; }
        public string AdressAcik { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
        public string Konum { get; set; }
    }
}