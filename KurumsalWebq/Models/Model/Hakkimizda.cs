using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace KurumsalWebq.Models.Model
{
    [Table("Hakkimizda")]
    public class Hakkimizda
    {
        [Key]
        public int HakkimizdaId { get; set; }
        [Required]
        [DisplayName("Hakkımızda Açıklama")]
        public string Aciklama { get; set; }
        [Required]
        [DisplayName("Vizyon")]
        public string Vizyon { get; set; }
        [Required]
        public string VizyonResim { get; set; }
        [Required]
        [DisplayName("Misyon")]
        public string Misyon { get; set; }
        [Required]
        public string MisyonResim { get; set; }

    }
}