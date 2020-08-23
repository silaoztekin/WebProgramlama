using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Kütüphane.Models.Entity;
using Web_Kütüphane.Models.Siniflarim;

namespace Web_Kütüphane.Controllers
{
    public class VitrinController : Controller
    {
        // GET: Vitrin
        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();

        [HttpGet]
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Deger1 = db.TBLKITAP.ToList();
            cs.Deger2 = db.TBLHAKKIMIZDA.ToList();
            return View(cs);
        }
        [HttpPost]
        public ActionResult Index(TBLİLETİSİM t)
        {
            db.TBLİLETİSİM.Add(t);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}