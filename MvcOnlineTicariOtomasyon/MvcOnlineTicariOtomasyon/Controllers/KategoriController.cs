using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Forms;
using MvcOnlineTicariOtomasyon.Models.Siniflar;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Kategoris.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult KategoriEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KategoriEkle(Kategori k)
        {
            c.Kategoris.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KategoriSil(int id) 
        {
            var ktg = c.Kategoris.Find(id);
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Kategoriyi silmek istediğinize emin misiniz ?", "Evet", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                c.Kategoris.Remove(ktg);
                //this.Close();
            }
            else
            {
                MessageBox.Show("Kategori Silinmedi !");
            }
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KategoriGetir(int id)
        {
            var kategori = c.Kategoris.Find(id);
            return View("KategoriGetir", kategori);
        }

        public ActionResult KategoriGuncelle(Kategori k)
        {
            var ktgr = c.Kategoris.Find(k.KategoriID);
            ktgr.KagetoriAd = k.KagetoriAd;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}