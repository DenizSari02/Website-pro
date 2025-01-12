using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KurumsalWebq.Models.Model
{
    [Table("Referanslar")]
    public class Referanslar
    {
        public int ReferanslarId { get; set; }
        public string Sirket { get; set; }
        public string Tel { get; set; }
        public string Adres { get; set; }
        
    }
}