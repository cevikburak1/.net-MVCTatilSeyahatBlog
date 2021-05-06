using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5_Tatil_Sehayat.Models.Sınıflar
{
    public class Hakkımızda
    {
        [Key]
        public int ID { get; set; }
        public string FotoURL { get; set; }
        public string Acıklama { get; set; }
    }
}