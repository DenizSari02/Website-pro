using KurumsalWebq.Models.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KurumsalWebq.Models.DataContext
{
    public class KurumsalDBQContext: DbContext
    {
        public KurumsalDBQContext() : base("KurumsalDBQ")
        {
        }
    public DbSet<Admin> Admin { get; set; }
        public DbSet<Referanslar> Referanslar { get; set; }
        public DbSet<Hakkimizda> Hakkimizda { get; set; }
        public DbSet<Hizmet> Hizmet { get; set; }
        public DbSet<Iletisim> Iletisim { get; set; }
        public DbSet<Kimlik> Kimlik { get; set; }
        public DbSet<Slider> Slider { get; set; }
       

    }

}
