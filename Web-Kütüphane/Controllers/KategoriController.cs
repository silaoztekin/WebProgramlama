using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Kütüphane.Controllers;
using Web_Kütüphane.Models.Entity;

namespace Web_Kütüphane.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities(); //Veri tabanındaki tablolara ve propertylere ulaşmak için
        public ActionResult Index()
        {
            var degerler = db.TBLKATEGORİ.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult Kategoriekle()
        {
            return View();       
        }
        [HttpPost]
        public ActionResult KategoriEkle(TBLKATEGORİ p)
        {
            db.TBLKATEGORİ.Add(p);
            db.SaveChanges();
            return View();
        }
        public ActionResult KategoriSil(int id)
        {
            var kategori = db.TBLKATEGORİ.Find(id);
            db.TBLKATEGORİ.Remove(kategori);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KategoriGetir(int id)
        {
            var ktg = db.TBLKATEGORİ.Find(id);
            return View("KategoriGetir", ktg);
        }
        public ActionResult KategoriGuncelle(TBLKATEGORİ p)
        {
            var ktg = db.TBLKATEGORİ.Find(p.ID);
            ktg.AD = p.AD;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}