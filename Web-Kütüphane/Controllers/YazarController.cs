using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Kütüphane.Models.Entity;
namespace Web_Kütüphane.Controllers
{
    public class YazarController : Controller
    {
        // GET: Yazar
        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();
        public ActionResult Index()
        {
            var degerler = db.TBLYAZAR.ToList();
            //var degerler = db.TBLYAZAR.Where(x => x.SILINDIMI == false).ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YazarEkle()
        {
            return View();
        }
        public ActionResult YazarEkle(TBLYAZAR p)
        {
            db.TBLYAZAR.Add(p);
            db.SaveChanges();
            return View();
        }
        public ActionResult YazarSil(int id)
        {
            var yazar = db.TBLYAZAR.Find(id);
            yazar.SILINDIMI = true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YazarGetir(int id)
        {
            var yzr = db.TBLYAZAR.Find(id);
            return View("YazarGetir", yzr);
        }
        public ActionResult YazarGuncelle(TBLYAZAR p)
        {
            var yzr = db.TBLYAZAR.Find(p.ID);
            yzr.AD = p.AD;
            yzr.SOYAD = p.SOYAD;
            yzr.DETAY = p.DETAY;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}