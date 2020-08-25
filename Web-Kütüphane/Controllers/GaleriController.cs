using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Kütüphane.Models.Entity;
namespace Web_Kütüphane.Controllers
{
    public class GaleriController : Controller
    {
        // GET: Galeri
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Galeri()
        {
            return View();        
        }
        [HttpPost]
        public ActionResult resimyukle(HttpPostedFileBase dosya)
        {
            if (dosya.ContentLength > 0)
            {
                string dosyayolu = Path.Combine(Server.MapPath("/web/galeri/"), Path.GetFileName(dosya.FileName));
                dosya.SaveAs(dosyayolu);
            }
            return RedirectToAction("Galeri");

        }
    }
}