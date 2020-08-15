using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Cari
    {
        [Key]
        public int CariID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(25,ErrorMessage ="Max 25 Karakter Yazabilirsiniz...")]
        public string CariAd { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(25, ErrorMessage = "Max 25 Karakter Yazabilirsiniz...")]
        public string CariSoyad { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(13, ErrorMessage = "Max 13 Karakter Yazabilirsiniz...")]
        public string CariSehir { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(40, ErrorMessage = "Max 40 Karakter Yazabilirsiniz...")]
        public string CariMail { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string CariSifre { get; set; }
        public ICollection<SatisHareket> SatisHarekets { get; set; }
        public bool Durum { get; set; }
    }
}