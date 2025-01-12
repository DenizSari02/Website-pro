using KurumsalWebq.Models.DataContext;
using KurumsalWebq.Models.Model;
using KurumsalWebq.Models.DataContext;
using KurumsalWebq.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Web.Helpers;
using System.Web.UI.WebControls;

namespace KurumsalWeb.Controllers
{
    public class HakkimizdaController : Controller
    {
        KurumsalDBQContext db = new KurumsalDBQContext();
        // GET: Kimlik
        public ActionResult Index()
        {
            return View(db.Hakkimizda.ToList());
        }



        // GET: Kimlik/Edit/5
        public ActionResult Edit(int id)
        {
            var hakkimizda = db.Hakkimizda.Where(x => x.HakkimizdaId == id).SingleOrDefault();
            return View(hakkimizda);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]

        
        public ActionResult Edit(int id, Hakkimizda hakkimizda, HttpPostedFileBase VizyonResim, HttpPostedFileBase MisyonResim)
        {
            if (ModelState.IsValid)
            {
                var h = db.Hakkimizda.Where(x => x.HakkimizdaId == id).SingleOrDefault();
                if (VizyonResim != null)
                {
                    if (System.IO.File.Exists(Server.MapPath(h.VizyonResim)))
                    {
                        System.IO.File.Delete(Server.MapPath(h.VizyonResim));
                    }
                    WebImage img = new WebImage(VizyonResim.InputStream);
                    FileInfo imginfo = new FileInfo(VizyonResim.FileName);

                    string hakimg = Guid.NewGuid().ToString() + imginfo.Extension;
                    img.Resize(600, 400);
                    img.Save("~/Uploads/Hakkımızda/" + hakimg);

                    h.VizyonResim = "/Uploads/Hakkımızda/" + hakimg;
                }

                if (MisyonResim != null)
                {
                    if (System.IO.File.Exists(Server.MapPath(hakkimizda.MisyonResim)))
                    {
                        System.IO.File.Delete(Server.MapPath(hakkimizda.MisyonResim));
                    }
                    WebImage img = new WebImage(MisyonResim.InputStream);
                    FileInfo imginfo = new FileInfo(MisyonResim.FileName);

                    string hakimg = Guid.NewGuid().ToString() + imginfo.Extension;
                    img.Resize(600, 400);
                    img.Save("~/Uploads/Hakkımızda/" + hakimg);

                    h.MisyonResim = "/Uploads/Hakkımızda/" + hakimg;
                }
                h.Aciklama = hakkimizda.Aciklama;
                h.Vizyon = hakkimizda.Vizyon;
                h.Misyon = hakkimizda.Misyon;
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(hakkimizda);
        }
    }
}
        